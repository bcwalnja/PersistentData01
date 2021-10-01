using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Media;

namespace Winforms_Timer_7
{
    public partial class Form1 : Form
    {
        int hours;
        int minutes;
        int seconds;
        int intervalInSeconds;
        bool timerIsSet = false;
        
        public Form1()
        {
            InitializeComponent();
            SetUp();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = "" + trackBar1.Value;
            CheckScroll();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            label2.Text = trackBar2.Value.ToString();
            CheckScroll();
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            label3.Text = "" + trackBar3.Value;
            CheckScroll();
        }

        private void startStopTimer_Click(object sender, EventArgs e)
        {
            resetTimer.Enabled = false;

            if (timerIsSet == false)
            {
                SetTimer();
            }

            if (timer2.Enabled)
            {
                trackBar1.Enabled = false;
                trackBar2.Enabled = false;
                trackBar3.Enabled = false;
                timer2.Stop();
            }
            else
            {
                timer2.Start();
            }

            if (timerIsSet == true && timer2.Enabled == false)
            {
                resetTimer.Enabled = true;
            }

        }

        private void reset_Click(object sender, EventArgs e)
        {
            ResetTimer();
        }

        public void SetUp()
        {
            resetTimer.Enabled = false;
            startStopTimer.Enabled = false;
                      
        }

        public void CheckScroll()
        {
            if (trackBar1.Value == 0 && trackBar2.Value == 0 && trackBar3.Value == 0)
            {
                startStopTimer.Enabled = false;
            }
            else
                startStopTimer.Enabled = true;
        }

        private bool SetTimer()
        {
            hours = trackBar1.Value;
            minutes = trackBar2.Value;
            seconds = trackBar3.Value;

            intervalInSeconds = (hours * 60 * 60) + (minutes * 60) + seconds;
           
            timerIsSet = true;
            return timerIsSet;
        }

        public void ResetTimer()
        {
            trackBar1.Value = 0;
            trackBar2.Value = 0;
            trackBar3.Value = 0;
            trackBar1.Enabled = true;
            trackBar2.Enabled = true;
            trackBar3.Enabled = true;
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            timerIsSet = false;
            CheckScroll();
        }

      
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (intervalInSeconds == 0)
            {
                return;
            }
            if (intervalInSeconds > 0)
            {
                intervalInSeconds -= 1;
                TimeSpan time = new TimeSpan(0, 0, intervalInSeconds);
                label1.Text = time.Hours.ToString();
                label2.Text = time.Minutes.ToString();
                label3.Text = time.Seconds.ToString();
            }

            if (intervalInSeconds == 0)
            {
                timer2.Enabled = false;
                resetTimer.Enabled = true;
                SystemSounds.Hand.Play();
                MessageBox.Show("Times Up", " ");
                ResetTimer();
            }
        }
    }
}
