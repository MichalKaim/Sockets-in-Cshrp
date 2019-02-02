using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace SterowanieTCP
{
    public partial class Form1 : Form
    {

        int port = 10100;

        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int a = 1;

            SendMess(a);

        }

        public void SendMess(int a) 
        {
            TcpClient client = new TcpClient("localhost", port);

            byte[] sendData = new byte[4];

            sendData = BitConverter.GetBytes(a);

            NetworkStream stream = client.GetStream();

            stream.Write(sendData, 0, sendData.Length);

            stream.Close();
            client.Close();

        }

        private void Down_Click(object sender, EventArgs e)
        {
            int a = -1;

            SendMess(a);
        }

        private void Right_Click(object sender, EventArgs e)
        {
            int a = 2;

            SendMess(a);
        }

        private void Left_Click(object sender, EventArgs e)
        {
            int a = -2;

            SendMess(a);
        }

        private void Jump_Click(object sender, EventArgs e)
        {
            int a = 3;

            SendMess(a);
        }
    }
}
