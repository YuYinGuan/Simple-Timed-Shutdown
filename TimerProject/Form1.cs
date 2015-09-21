using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TimeView.Text = "Time Until Shutdown";
        }

        Boolean TimerStart = false;
        int TimeCount = 0;
        int oneMinute = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.TimerStart) 
            {
                if (oneMinute > 0)
                {
                    oneMinute--;
                }
                else
                {
                    oneMinute = 60;
                    TimeCount--;
                }

                TimeView.Text = TimeCount.ToString() + " Minute " + oneMinute.ToString() + " Second";

                if (oneMinute <= 0 && TimeCount <= 0)
                {
                    System.Diagnostics.Process.Start("Shutdown", "-s -t 10");
                    this.TimerStart = false;
                }
                
            }
            else
            {
                TimeView.Text = "Time Until Shutdown";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.TimerStart) 
            {
                this.TimerStart = false;
                button1.Text = "Start";
            }
            else
            {
                this.TimerStart = true;
                button1.Text = "Stop";
                Int32.TryParse(Text1.Text, out TimeCount);
                Text1.Clear();
            }
        }

        private void TimeView_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Text1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
