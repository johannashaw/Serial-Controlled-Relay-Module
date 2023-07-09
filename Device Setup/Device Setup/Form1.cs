using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.Xml.Linq;
using System.Reflection;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Device_Setup
{
    public partial class Form_ArduinoRelaySetup : Form
    {
        // class members
        static SerialPort _serialPort = new SerialPort();
        Queue<string> ReceivedStrings = new Queue<string>();
        Thread th_CheckRec = null;
        int editIndex = -1, workingIndex = -1;

        //BindingSource bs_Relays = null;
        List<Relay> ls_Relays = new List<Relay>(); 
        


        public Form_ArduinoRelaySetup()
        {
            InitializeComponent();

            // populate the dropdown menu with availible ports
            foreach (string port in SerialPort.GetPortNames())
            {
                dd_Ports.Items.Add(port);
            }


            //bs_Relays = new BindingSource();
            //bs_Relays = new BindingSource(ls_Relays, null);

            //DGV_Relays.AutoGenerateColumns = true;

            //DGV_Relays.DataSource = ls_Relays;

            // bind event callbacks
            _serialPort.DataReceived += _serialPort_DataReceived;
            trb_delay.ValueChanged += Trb_delay_ValueChanged;
        }

        private void Trb_delay_ValueChanged(object sender, EventArgs e)
        {
            txb_delay.Text = $"{trb_delay.Value/10.0}";
        }


        /// <summary>
        /// User has made a new port selection, update Serial port accordingly
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dd_Ports_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // Try to open the serial connection
            try
            {
                _serialPort.Close();
                _serialPort.PortName = dd_Ports.SelectedItem.ToString();
                _serialPort.Open();
                UI_Enable();
                lb_ErrorOut.Text = "";
            }
            catch (Exception ex)
            {
                // put an error message here idk
                SerialError("Serial Port Connection Failed: \n\t" + ex.Message);
                UI_Disable();
                return;
            }

            // start the thread for receiving data here
            th_CheckRec = new Thread(StringCheck);
            th_CheckRec.IsBackground = true;
            th_CheckRec.Start();



            SendChar(17);
        }



        /// <summary>
        /// SerialPort callback for when it has received data.
        /// Adds the received string to the ReceivedStrings queue since there's no guarentee that the data is a complete line
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // Source: https://learn.microsoft.com/en-us/dotnet/api/system.io.ports.serialport.datareceived?view=dotnet-plat-ext-7.0

            // OKAY! So the data is being received in odd ways, so it looks like we're gonna need to implement our good friend json
            // to make sure we're got good formatting


            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting();

            // 
            Invoke(new Action(() => 
            { 
                ReceivedStrings.Enqueue(indata);
            }));
            
        }

        /// <summary>
        /// Used in the th_CheckRec Thread, Periodically checks if there's more data to process
        /// Then processes the received data
        /// </summary>
        private void StringCheck()
        {
            string working = "";

            // this bad boy will keep looping while the connection is esstablished
            while (true)
            {
                // Since this program isn't high-stakes, it will only check for new info every 0.1 seconds
                Thread.Sleep(100);

                // if Nothing new, do nothing
                if (ReceivedStrings.Count == 0)
                    continue;

                // dequeue everything received
                while (ReceivedStrings.Count != 0)
                    working += ReceivedStrings.Dequeue();

                // check each line 
                int Start = 0;
                for (int i = 0; i < working.Length; i++)
                {
                    // you have a complete line
                    if (working[i] == '\n')
                    {
                        // split the line by commas
                        string line = working.Substring(Start, i - Start + 1);
                        string[] vals = line.Split(',');

                        Invoke(new Action(() =>
                        {
                            if (vals.Length == 3)
                            {
                                AddLine(vals);
                            }
                            lb_in.Items.Add(line);
                        }));

                        Start = i + 1;
                    } 
                }
                if (Start != working.Length)
                    working = working.Substring(Start);
                else
                    working = "";

            }
        }

        private void AddLine(string[] line)
        {
            Relay row = null;

            try
            {
                row = new Relay(line);
            }
            catch (Exception e)
            {
                SerialError("Received bad data " + e.Message);
                return;
            }




            // check to see if there's already data for the relay
            // delete the data if yes

            if (ls_Relays.Contains(row))
            {
                ls_Relays.Remove(row);
                DGV_Relays.Rows.RemoveAt(row.Number);
            }

            // insert the row
            ls_Relays.Add(row);
            DGV_Relays.Rows.Add(row.Number+1, row.Name, row.Delay/10.0);

            // bind and sort
            DGV_Relays.Sort(col_Relay, ListSortDirection.Ascending);
            ls_Relays.Sort();

            //tb_in.Text += row.ToString() + "\n";
        }

        private void butt_Send_Click(object sender, EventArgs e)
        {
            SendString(tb_test.Text);
        }

        /// <summary>
        /// Sends the given string to the device over the established serial port
        /// </summary>
        /// <param name="msg">The string to be sent</param>
        /// <param name="error">The error message to be displayed in the error label</param>
        /// <returns>true if successful, false if error</returns>
        private bool SendString(string msg, string error)
        {

            try
            {
                _serialPort.WriteLine(msg);
            }
            catch
            {
                SerialError(error);
                return false;
            }
            lb_out.Items.Add(msg);
            return true;

        }
        /// <summary>
        /// Sends the given string to the device over the established serial port
        /// </summary>
        /// <param name="msg">The string to be sent</param>
        /// <returns>true if successful, false if error</returns>
        private bool SendString(string msg)
        {
            try
            {
                _serialPort.WriteLine(msg);
            }
            catch (Exception e)
            {
                SerialError(e.Message);
                return false;
            }
            lb_out.Items.Add(msg);
            return true;
        }

        private void SendCharButton_Click(object sender, EventArgs e)
        {
            //
            if (!(sender is System.Windows.Forms.Button))
                return;


            // Refresh sends device control 1 char
            if (sender as System.Windows.Forms.Button == butt_Refresh)
                SendChar(17);
            // Reset sends device control 2 char
            else if (sender as System.Windows.Forms.Button == butt_Reset)
            {
                if (MessageBox.Show("Names will be reset to 'R[x]' and Delays will be reset to 3.5 seconds",
                    "Reset all the relay names and delays to the default?", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                    return;
                SendChar(18);
            }
        }

        /// <summary>
        /// Sends a single character over the
        /// </summary>
        /// <param name="val"></param>
        private void SendChar(byte val)
        {

            byte[] buff = new byte[] {val, (byte)'\n'};

            try
            {
                _serialPort.Write(buff, 0, 1);
            }
            catch (Exception ex)
            {
                // put an error message here too
                SerialError($"Failed to send byte '{val}': \n\t" + ex.Message);
            }
        }
        private void SendChar(char val)
        {
            SendChar((byte)val);
        }



        // *****************************************************************************
        // **************************        UI Changes       **************************
        // *****************************************************************************

        /// <summary>
        /// Changes the Error label text to the specified msg string.
        /// </summary>
        /// <param name="msg"></param>
        private void SerialError(string msg)
        {
            // change colour to redish
            lb_ErrorOut.ForeColor = Color.Maroon;
            // convay error message here
            lb_ErrorOut.Text = msg;
        }


        /// <summary>
        /// Changes the Error label text to the specified msg string.
        /// </summary>
        /// <param name="msg"></param>
        private void DisplayMessage(string msg)
        {
            // change colour to form default
            lb_ErrorOut.ForeColor = ForeColor;
            // convay error message here
            lb_ErrorOut.Text = msg;
        }

        /// <summary>
        /// Disables the Relay changing UI
        /// </summary>
        private void UI_Disable()
        {
            gb_MainUI.Enabled = gb_Edit.Enabled = gb_NerdStuff.Enabled = false;
        }

        /// <summary>
        /// Enables Relay changing UI
        /// </summary>
        private void UI_Enable()
        {
            gb_MainUI.Enabled = true;
        }

        /// <summary>
        /// Resets the Editing group box and its contents to the empty default
        /// </summary>
        private void ClearEditUI()
        {
            editIndex = -1;
            gb_Edit.Enabled = false;
            gb_Edit.Text = $"Edit";

            // clear the labels and text boxes
            lb_EditError.Text = txb_delay.Text = tb_Name.Text = "";
            trb_delay.Value = 0;

        }

        private void cb_NerdStuff_CheckedChanged(object sender, EventArgs e)
        {
            // just save te starting width so that we don't get confused
            Point thing = gb_NerdStuff.Location;

            gb_NerdStuff.Enabled = gb_NerdStuff.Visible = cb_NerdStuff.Checked;

            Width += (gb_NerdStuff.Width + Padding.Right + gb_NerdStuff.Margin.Right) * (gb_NerdStuff.Enabled ?  1 : -1);



            //gb_NerdStuff.Location = thing;
            gb_NerdStuff.Width = Width - MinimumSize.Width;


            SerialError(Width.ToString());
        }

        private void butt_edit_Click(object sender, EventArgs e)
        {
            if (DGV_Relays.SelectedRows.Count == 0)
            {
                SerialError("Select a row to edit");
                return;
            }

            // get the selected relay
            Relay relay = GetRelay();

            if (relay == null)
                return;
            editIndex = workingIndex;


            gb_Edit.Enabled = true;
            gb_Edit.Text = $"Edit Relay {relay.Number + 1}";

            // fill the edit-name textbox with the selected relay name
            tb_Name.Text = relay.Name;
            trb_delay.Value = relay.Delay;
            Trb_delay_ValueChanged(sender, e);
        }

        private Relay GetRelay()
        {
            if (DGV_Relays.SelectedRows.Count == 0)
            {
                SerialError("Select a row to edit");
                return null;
            }

            // get the selected relay

            Relay relay;
            try
            {
                workingIndex = (int)DGV_Relays.SelectedRows[0].Cells[0].Value - 1;

                relay = ls_Relays[workingIndex]; //(int)DGV_Relays.SelectedRows[0].Cells[0].Value;
                                              //int editIndex = DGV_Relays.Rows.IndexOf(DGV_Relays.SelectedRows[0]);
            }
            catch (Exception ex)
            {
                SerialError($"Value error in edit Click event: " + ex.Message);
                return null;
            }
            return relay;
        }


        private void butt_Save_Click(object sender, EventArgs e)
        {
            string name = tb_Name.Text.Trim();
            if (name.Length > 15)
            {
                lb_EditError.Text = "Relay Name needs to be less than 15 characters long";
                return;
            }

            Relay relay = ls_Relays[editIndex];

            // if the name is different, send it to the device
            if (name != relay.Name &&  name != "")
            {
                // name can't contain commas
                if (name.Contains(","))
                {
                    lb_EditError.Text = "Relay name can't contain commas.";
                    return;
                }
                // name can't be the same as another name
                if (ls_Relays.Exists(r => r.Name == name))
                {
                    lb_EditError.Text = "Each relay needs to have a unique name.";
                    return;
                }
                string error = "Name change failed";
                if (!SendString($"cn{editIndex}{name}", error))
                {
                    lb_EditError.Text = error;
                    return;
                }

            }

            //if the delay is different, send it to the device

            // if the name is different, send it to the device
            if (trb_delay.Value != relay.Delay)
            {

                string error = "Delay change failed";
                char delay = (char)(trb_delay.Value + 32);
                if (!SendString($"cd{editIndex}{trb_delay.Value:D3}", error))
                {
                    lb_EditError.Text = error;
                    return;
                }
            }

            // give saved message
            DisplayMessage($"Relay {relay.Number+1} Change Saved!");
            // clear edit UI
            ClearEditUI();
        }

        private void butt_cancel_Click(object sender, EventArgs e)
        {
            // 
            DisplayMessage("Edit Cancelled");
            ClearEditUI();
        }



        /// <summary>
        /// This should copy the cell contents to the clipboard
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DGV_Relays_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }



        /// <summary>
        /// Sends the relay add command to the device
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butt_add_Click(object sender, EventArgs e)
        {
            Relay rel = GetRelay();
            if (rel == null)
            {
                return;
            }

            // send the relay name with a "+" at the end over the serial port
            SendString(rel.Name + "+");
        }

        /// <summary>
        /// Sends the relay stop/clear cache command to the device
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butt_off_Click(object sender, EventArgs e)
        {
            Relay rel = GetRelay();
            if (rel == null)
            {
                return;
            }

            // send the relay name with a "_off" at the end over the serial port
            SendString(rel.Name + "_off");
        }

        private void txb_delay_TextChanged(object sender, EventArgs e)
        {
            // the number is valid
            if (float.TryParse(txb_delay.Text, out float delay) && delay >=0)
            {
                int del = (int)(delay * 10 + 0.01);
                if (del >= 0 && del  <= 255)
                {
                    trb_delay.Value = del;
                    return;
                }
            }
            txb_delay.Text = $"{trb_delay.Value / 10.0}";
        }
    }


}
