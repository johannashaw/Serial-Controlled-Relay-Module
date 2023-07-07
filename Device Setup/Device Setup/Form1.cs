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

namespace Device_Setup
{
    public partial class Form_ArduinoRelaySetup : Form
    {
        // class members
        static SerialPort _serialPort = new SerialPort();
        Queue<string> ReceivedStrings = new Queue<string>();
        Thread th_CheckRec = null;
        


        public Form_ArduinoRelaySetup()
        {
            InitializeComponent();

            // populate the dropdown menu with availible ports
            foreach (string port in SerialPort.GetPortNames())
            {
                dd_Ports.Items.Add(port);
            }

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
                tb_in.Text += indata; 
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


            }
        }

        private void AddLine(string line)
        {
            DGV_Relays.Rows.
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

    }
}
