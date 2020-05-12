using System;

//usadas no ping
using System.Net;
using System.Net.NetworkInformation;
///
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ping
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// olols
        /// </summary>
        /// <param name="sender">frewdf</param>
        /// <param name="e">fee4fgftg45</param>
        private void Form1_Load(object sender, EventArgs e)
        {
            timer_ping.Enabled = false;
            timer_ping.Interval = 5000;
            ip_textbox.Text = "192.168.1.66";
        }



        private void btn_start_Click(object sender, EventArgs e)
        {
            if (timer_ping.Enabled == false)
            {
                timer_ping.Enabled = true;
                btn_start.Text = "Stop";
                ip_textbox.Enabled = false;
            }
            else
            {
                timer_ping.Enabled = false;
                btn_start.Text = "Start";
                ip_textbox.Enabled = true;
            }

        }

        private void timer_ping_Tick(object sender, EventArgs e)
        {
            sendping(ip_textbox.Text);
        }

      
            // args[0] can be an IPaddress or host name.
        public void sendping(string args)
        {
            Ping pingSender = new Ping();
            PingOptions options = new PingOptions();

            // Use the default Ttl value which is 128,
            // but change the fragmentation behavior.
            options.DontFragment = true;

            // Create a buffer of 32 bytes of data to be transmitted.
            string data = "aaaaaaaaaa";
            byte[] buffer = Encoding.ASCII.GetBytes(data);
            int timeout = 120;
            try
            {
                PingReply reply = pingSender.Send(args, timeout, buffer, options);
                if (reply.Status == IPStatus.Success)
                {
                    Console.WriteLine("Address: {0}", reply.Address.ToString());
                    Console.WriteLine("RoundTrip time: {0}", reply.RoundtripTime);
                    Console.WriteLine("Time to live: {0}", reply.Options.Ttl);
                    Console.WriteLine("Don't fragment: {0}", reply.Options.DontFragment);
                    Console.WriteLine("Buffer size: {0}", reply.Buffer.Length);

                    textout.AppendText("Address: {0}"+ reply.Address.ToString()+"\n");
                    textout.AppendText("RoundTrip time: {0}"+ reply.RoundtripTime + "\n");
                    textout.AppendText("Time to live: {0}"+ reply.Options.Ttl + "\n");
                    textout.AppendText("Don't fragment: {0}"+ reply.Options.DontFragment + "\n");
                    textout.AppendText("Buffer size: {0}"+ reply.Buffer.Length + "\n");

                    

                }
                else
                {
                    Console.WriteLine("host not reached");
                    textout.AppendText("host not reached\n");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error: " );
                timer_ping.Enabled = false;
                
            }

        }
       
    }
}
