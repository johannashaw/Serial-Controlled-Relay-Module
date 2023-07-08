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

namespace Device_Setup
{
    public partial class Form_ArduinoRelaySetup : Form
    {
        // class members
        static SerialPort _serialPort = new SerialPort();
        Queue<string> ReceivedStrings = new Queue<string>();
        Thread th_CheckRec = null;

        //BindingSource bs_Relays = null;
        BindingList<Relay> ls_Relays = new BindingList<Relay>(); 
        


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
                //tb_in.Text += indata; 
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
                            
                            tb_in.Text += line;
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
                SerialError(e.Message);
                return;
            }




            // check to see if there's already data for the relay
            // delete the data if yes


            if (ls_Relays.Contains(row))
            {
                ls_Relays.Remove(row);
                DGV_Relays.Rows.RemoveAt(row.Number);
            }

            ls_Relays.Add(row);
            DGV_Relays.Rows.Add(row.Number+1, row.Name, row.Delay/10.0);



            // insert the row

            // bind and sort (unclear if it needs to be done each time
            DGV_Relays.Sort(col_Relay, ListSortDirection.Ascending);






            tb_in.Text += row.ToString() + "\n";
        }

        private void butt_Send_Click(object sender, EventArgs e)
        {
            _serialPort.WriteLine(tb_test.Text);
            tb_out.Text += tb_test.Text + "\n";
        }

        private void SendCharButton_Click(object sender, EventArgs e)
        {
            //
            if (!(sender is Button))
                return;


            // Refresh sends device control 1 char
            if (sender as Button == butt_Refresh)
                SendChar(17);
            // Reset sends device control 2 char
            else if (sender as Button == butt_Reset)
            {
                if (MessageBox.Show("Reset all the relay names and delays to the default?", 
                    "Names be reset to 'R[x]' and delays will be reset to 3.5 sconds", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
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

            byte[] buff = new byte[] {val};

            try
            {
                _serialPort.Write(buff, 0, 1);

            }
            catch (Exception ex)
            {
                // put an error message here too
                SerialError($"Refresh code failed to send byte '{val}': \n\t" + ex.Message);
            }
        }
        private void SendChar(char val)
        {
            SendChar((byte)val);
        }



        private void SerialError(string msg)
        {
            // convay error message here
            lb_ErrorOut.Text = msg;
        }

        // *****************************************************************************
        // **************************        UI Changes       **************************
        // *****************************************************************************

        /// <summary>
        /// Disables the Relay changing UI
        /// </summary>
        private void UI_Disable()
        {

        }

        /// <summary>
        /// Enables Relay changing UI
        /// </summary>
        private void UI_Enable()
        {

        }

        private void cb_NerdStuff_CheckedChanged(object sender, EventArgs e)
        {
            gb_NerdStuff.Enabled = gb_NerdStuff.Visible = cb_NerdStuff.Checked;
        }

        private void butt_edit_Click(object sender, EventArgs e)
        {
            if (DGV_Relays.SelectedRows.Count == 0)
            {
                SerialError("Select a row to edit");
                return;
            }
            //DGV_Relays.
        }

        private void DGV_Relays_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void butt_add_Click(object sender, EventArgs e)
        {

        }

        private void butt_off_Click(object sender, EventArgs e)
        {

        }
    }


}
