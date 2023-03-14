using System;
using System.Net.NetworkInformation;

namespace Server_Status
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Check_BTN_Click(object sender, EventArgs e)
        {
            Status_LBL.Text = "trying...";
            try
            {
                string Hostname = URL_TXT.Text;
                Ping ping = new();
                PingReply reply = ping.Send(Hostname);
                if (reply.Status == IPStatus.Success)
                {
                    Console.WriteLine("Success");
                    Status_LBL.ForeColor = Color.DarkGreen;
                    Status_LBL.Text = reply.Status.ToString();
                    listBox1.Items.Add(Hostname + " | " + reply.Status + " | "+ reply.RoundtripTime + "ms" + " | " + DateTime.Now);
                }
                else
                {
                    Console.WriteLine("failed");
                    Status_LBL.ForeColor = Color.DarkRed;
                    Status_LBL.Text = reply.Status.ToString();
                    listBox1.Items.Add(Hostname + " | " + reply.Status + " | " + DateTime.Now);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex.Message);
                Status_LBL.ForeColor = Color.DarkRed;
                Status_LBL.Text = ex.Message;
            }
        }
    }
}