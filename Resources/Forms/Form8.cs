using System;
using System.IO.Ports;
using System.Text;
using System.Windows.Forms;

namespace Ports
{
    public partial class Form8 : Form
    {
        private StringBuilder incomingData = new StringBuilder();

        public Form8()
        {
            InitializeComponent();
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);
            serialPort1.ReadTimeout = 1000; // Set read timeout to 1000ms
            serialPort1.WriteTimeout = 500; // Optional: Set write timeout
        }

        private void scanBT_Click(object sender, EventArgs e)
        {
            comportCB.Text = "";
            comportCB.Items.Clear();
            String[] ports = SerialPort.GetPortNames();
            comportCB.Items.AddRange(ports);
        }

        private void connectBT_Click(object sender, EventArgs e)
        {
            if (ConnectPort())
            {
                connectBT.Enabled = false;
                disconnectBT.Enabled = true;
                comportCB.Enabled = false;
                baudrateCB.Enabled = false;
                scanBT.Enabled = false;
                sendBT.Enabled = true;
            }
        }

        public bool ConnectPort()
        {
            try
            {
                if (!string.IsNullOrEmpty(comportCB.Text) && !string.IsNullOrEmpty(baudrateCB.Text))
                {
                    serialPort1.PortName = comportCB.Text;
                    serialPort1.BaudRate = int.Parse(baudrateCB.Text);
                    serialPort1.Open();
                    return true;
                }
                else
                {
                    MessageBox.Show("Please select a COM port and baud rate.", "Warning", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error!", MessageBoxButtons.OK);
            }
            return false;
        }

        private void disconnectBT_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Close();
                }
                connectBT.Enabled = true;
                disconnectBT.Enabled = false;
                comportCB.Enabled = true;
                baudrateCB.Enabled = true;
                scanBT.Enabled = true;
                sendBT.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error!", MessageBoxButtons.OK);
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string data = serialPort1.ReadExisting();
                incomingData.Append(data);
                Invoke(new Action(() => ProcessReceivedData(data)));
            }
            catch (Exception ex)
            {
                // Handle exception if needed
                MessageBox.Show("Data Receive Error: " + ex.Message, "Error!", MessageBoxButtons.OK);
            }
        }

        private void ProcessReceivedData(string data)
        {
            // Update the incoming data text box
            incomingTB.AppendText(data);

            // Check if the received data contains the letter 'A' and append the Khmer letter 'ក' for each 'A'
            foreach (char c in data)
            {
                // Latter English to khmer

                if (c == 'A')
                {
                    khmerTB.AppendText("ក");
                }
                if (c == 'B')
                {
                    khmerTB.AppendText("ខ");
                }
                if (c == 'C')
                {
                    khmerTB.AppendText("គ");
                }
                if (c == 'D')
                {
                    khmerTB.AppendText("ឃ");
                }
                if (c == 'E')
                {
                    khmerTB.AppendText("ង");
                }
                if (c == 'F')
                {
                    khmerTB.AppendText("ច");
                }
                if (c == 'G')
                {
                    khmerTB.AppendText("ឆ");
                }
                if (c == 'H')
                {
                    khmerTB.AppendText("ជ");
                }
                if (c == 'I')
                {
                    khmerTB.AppendText("ឈ");
                }
                if (c == 'J')
                {
                    khmerTB.AppendText("ញ");
                }
                if (c == 'K')
                {
                    khmerTB.AppendText("ដ");
                }
                if (c == 'L')
                {
                    khmerTB.AppendText("ឋ");
                }
                if (c == 'M')
                {
                    khmerTB.AppendText("ឌ");
                }
                if (c == '(')
                {
                    khmerTB.AppendText("ឍ");
                }
                if (c == 'N')
                {
                    khmerTB.AppendText("ណ");
                }
                if (c == 'O')
                {
                    khmerTB.AppendText("ត");
                }
                if (c == 'P')
                {
                    khmerTB.AppendText("ថ");
                }
                if (c == 'Q')
                {
                    khmerTB.AppendText("ទ");
                }
                if (c == 'R')
                {
                    khmerTB.AppendText("ធ");
                }
                if (c == 'S')
                {
                    khmerTB.AppendText("ន");
                }
                if (c == 'T')
                {
                    khmerTB.AppendText("ប");
                }
                if (c == 'U')
                {
                    khmerTB.AppendText("ផ");
                }
                if (c == 'V')
                {
                    khmerTB.AppendText("ព");
                }
                if (c == 'W')
                {
                    khmerTB.AppendText("ភ");
                }
                if (c == 'X')
                {
                    khmerTB.AppendText("ម");
                }
                if (c == 'Y')
                {
                    khmerTB.AppendText("យ");
                }
                if (c == 'Z')
                {
                    khmerTB.AppendText("រ");
                }
                if (c == '&')
                {
                    khmerTB.AppendText("ល");
                }
                if (c == ',')
                {
                    khmerTB.AppendText("វ");
                }
                if (c == '?')
                {
                    khmerTB.AppendText("ស");
                }
                if (c == '!')
                {
                    khmerTB.AppendText("ហ");
                }
                if (c == '/')
                {
                    khmerTB.AppendText("ឡ");
                }
                if (c == '"')
                {
                    khmerTB.AppendText("អ");
                }
                // Number English to khmer
                if (c == '0')
                {
                    khmerTB.AppendText("០");
                }
                if (c == '1')
                {
                    khmerTB.AppendText("១");
                }
                if (c == '2')
                {
                    khmerTB.AppendText("២");
                }
                if (c == '3')
                {
                    khmerTB.AppendText("៣");
                }
                if (c == '4')
                {
                    khmerTB.AppendText("៤");
                }
                if (c == '5')
                {
                    khmerTB.AppendText("៥");
                }
                if (c == '6')
                {
                    khmerTB.AppendText("៦");
                }
                if (c == '7')
                {
                    khmerTB.AppendText("៧");
                }
                if (c == '8')
                {
                    khmerTB.AppendText("៨");
                }
                if (c == '9')
                {
                    khmerTB.AppendText("៩");
                }
            }
        }

        private void clearBT_Click(object sender, EventArgs e)
        {
            incomingTB.Text = "";
            khmerTB.Text = ""; // Clear the Khmer letter text box
            incomingData.Clear();
        }

        private void sendBT_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serialPort1.IsOpen)
                {
                    serialPort1.Open();
                }
                serialPort1.Write(outgoingTB.Text);
                outgoingTB.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Send Error: " + ex.Message, "Error!", MessageBoxButtons.OK);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // No action needed
        }

        private void khmerTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void incomingTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void Ports_Load(object sender, EventArgs e)
        {

        }

        private void outgoingTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
