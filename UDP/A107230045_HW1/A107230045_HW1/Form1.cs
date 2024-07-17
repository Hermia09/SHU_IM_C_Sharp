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
using System.Threading;

namespace A107230045_HW1
{
    public partial class Form1 : Form
    {
        UdpClient U;
        Thread Th;
        public Form1()
        {
            InitializeComponent();
        }

        private void Listen()
        {
            int Port = int.Parse(textBox1.Text);
            U = new UdpClient(Port);
            IPEndPoint EP = new IPEndPoint(IPAddress.Parse(MyIP()), Port);
            while (true)
            {
                byte[] B = U.Receive(ref EP);
                textBox2.Text = Encoding.Default.GetString(B);
                listBox1.Items.Add("<Receive from>" + EP.Address.ToString() + ":" + EP.Port.ToString() + ":" + textBox2.Text);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            Th = new Thread(Listen);
            Th.Start();
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string IP = textBox3.Text;
            int Port = int.Parse(textBox5.Text);
            byte[] B = Encoding.Default.GetBytes(textBox5.Text);
            UdpClient S = new UdpClient();
            S.Send(B, B.Length, IP, Port);
            listBox1.Items.Add("<Send to>" + textBox3.Text + ":" + textBox4.Text + ":" + textBox5.Text);
            S.Close();
        }
        private string MyIP()
        {
            string hn = Dns.GetHostName();
            IPAddress[] ip = Dns.GetHostEntry(hn).AddressList;
            foreach (IPAddress it in ip)
            {
                if (it.AddressFamily == AddressFamily.InterNetwork)
                {
                    return it.ToString();
                }
            }
            return "";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text += " " + MyIP();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Th.Abort();
                U.Close();
                this.Close();
            }
            catch
            {

            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Th.Abort();
                U.Close();
            }
            catch
            {

            }
        }
    }
}
