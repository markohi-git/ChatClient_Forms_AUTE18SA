using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatClient_Forms_AUTE18SA
{
    public partial class Form1 : Form
    {
        private TcpClient client;
        private NetworkStream ns;
        private Thread thread;
        public Form1()
        {
            InitializeComponent();
        }

        private void yhdistaButton_Click(object sender, EventArgs e)
        {
            IPAddress ip = IPAddress.Parse(IpTextBox.Text);
            int port = int.Parse(portTextBox.Text);
            client = new TcpClient();
            client.Connect(ip, port);
            ns = client.GetStream();
            thread = new Thread(ReceiveData);
            thread.Start(client);
        }

        private void ReceiveData(object o)
        {
            TcpClient client = (TcpClient)o;
            NetworkStream nsInput = client.GetStream();
            byte[] receivedBytes = new byte[1024];
            int byte_count;
            try
            {
                while ((byte_count = nsInput.Read(receivedBytes, 0, receivedBytes.Length)) > 0)
                {
                    String t = Encoding.UTF8.GetString(receivedBytes, 0, byte_count);
                    Console.WriteLine(t);
                    SetText(t);
                }
            }
            catch{ }
        }

        delegate void SetTextCallback(string t);
        private void SetText(string t)
        {
            if (this.textBox1.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                Invoke(d, new object[] { t });
            }
            else
            {
                this.textBox1.AppendText(t);
            }
        }

        private void katkaiseButton_Click(object sender, EventArgs e)
        {
            byte [] buffer = Encoding.UTF8.GetBytes("exit");
            ns.Write(buffer, 0, buffer.Length);
            client.Client.Shutdown(SocketShutdown.Both);
            ns.Close();
            client.Close();
        }

        private void lahetaButton_Click(object sender, EventArgs e)
        {
            byte[] buffer = Encoding.UTF8.GetBytes(lahetaTextBox.Text);
            ns.Write(buffer, 0, buffer.Length);
            lahetaTextBox.Text = "";
        }
    }
}
