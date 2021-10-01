using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace Winforms_Stopwatch_8
{
    public partial class Form1 : Form
    {
        Stopwatch stopwatch = new Stopwatch();
        string elapsedTime;


        public Form1()
        {
            InitializeComponent();
        }

        private void StartStopButton(object sender, EventArgs e)
        {

            if (stopwatch.IsRunning)
            {
                stopwatch.Stop();
                timer1.Enabled = false;
            }
            else
            {
                stopwatch.Start();
                timer1.Enabled = true;
            }
        }

        private void ResetButton(object sender, EventArgs e)
        {
            DisplayHistory();
            stopwatch.Reset();
            SetUp();
            textBox1.Text = elapsedTime;
        }

        private void ClearHistory(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
                listView1.Items.Clear();
            }
        }

        public void SetUp()
        {
            TimeSpan ts = stopwatch.Elapsed;

            elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                                                ts.Hours, ts.Minutes, ts.Seconds,
                                                ts.Milliseconds / 10);
           
        }

       public void DisplayHistory()
       {
            if (listView1.Items.Count < 40 && stopwatch.ElapsedMilliseconds > 0)
            {
                listView1.Items.Add(elapsedTime);
            }  
       }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SetUp();
            textBox1.Text = elapsedTime;
        }
    }
}
