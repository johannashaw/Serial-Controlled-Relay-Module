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

namespace Device_Setup
{
    public partial class Form_ArduinoRelaySetup : Form
    {
        // class members
        static SerialPort _serialPort = new SerialPort();
        public Form_ArduinoRelaySetup()
        {
            InitializeComponent();

            _serialPort.DataReceived += _serialPort_DataReceived;
        }


        /// <summary>
        /// 
        /// Source: https://learn.microsoft.com/en-us/dotnet/api/system.io.ports.serialport.datareceived?view=dotnet-plat-ext-7.0
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting();
            Console.WriteLine("Data Received:");
            Console.Write(indata);
        }
    }
}
