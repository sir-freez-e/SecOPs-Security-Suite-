using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecOPs_Suite
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeComponent();

            notifyIcon1 = new NotifyIcon();
            notifyIcon1.Text = "SecOPs Suite";
            notifyIcon1.Visible = true;

            notifyIcon1.DoubleClick += notifyIcon1_MouseDoubleClick;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button1.Tag.ToString() == "connected")
            {
                button1.Text = "Disconnect";
                button1.Tag = "disconnected";
                // Optional: Disable the button
                button1.Enabled = false;
            }
            else
            {
                button1.Text = "Connect";
                button1.Tag = "connected";
                // Optional: Enable the button
                button1.Enabled = true;
            }

            // Perform other actions when the button is clicked (optional)
            // ... your code here ...
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, EventArgs e)
        {
            // Handle double-click event
            this.Show();
        }
    }
}
