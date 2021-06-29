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
    using System.IO;

    namespace SerialPortTerminal
    {
        public partial class Form1 : Form
        {
            private SerialPort serialPort;
        
            
            public Form1()
            {
                InitializeComponent();
                getAvailablePorts();
                ReceivedStrings.Items.Clear();
            }

            private void Form1_Load(object sender, EventArgs e)
            {

            }
            public void getAvailablePorts()
            {
                String[] ports = SerialPort.GetPortNames();
                AvailablePortsBox.Items.AddRange(ports);
            }
            private void button1_Click(object sender, EventArgs e)
            {
                serialPort = new SerialPort();
                serialPort.PortName = AvailablePortsBox.Text;
                serialPort.BaudRate = 9600;
                serialPort.Parity = Parity.None;
                serialPort.DataBits = 8;
                serialPort.StopBits = StopBits.One;
                serialPort.ReadBufferSize = 10000;
           
                serialPort.DataReceived += OnDataReceivedOnSerialPort;

                try
                {
                    if(!serialPort.IsOpen)
                        serialPort.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "...Error");
                }
           
            
            }
            private void OnDataReceivedOnSerialPort(object sender, SerialDataReceivedEventArgs e)
            {
                
                string message = serialPort.ReadLine();
                ReceivedStrings.Items.Add(message);

            }
            private void SendButton_Click(object sender, EventArgs e)
            {
                serialPort.WriteLine(SendingMessageBox.Text.ToString());
            }
        
            private void Form1_FormClosing(object sender, FormClosingEventArgs e)
            {
                try
                {
                    serialPort.Close();
                }
                catch(Exception ex){

                }
            }

            private void DisconnectButton_Click(object sender, EventArgs e)
            {
                try
                { 
                    serialPort.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error when disconnetting from port!");
                    if (Application.MessageLoop)
                    {
                        // WinForms app
                        Application.Exit();
                    }
                    else
                    {
                        // Console app
                        Environment.Exit(1);
                    }
                }
                MessageBox.Show("Disconnected From Port!");
            }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
    }
