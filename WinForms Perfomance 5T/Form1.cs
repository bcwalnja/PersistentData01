using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace WinForms_Project_5
{
    public partial class Form1 : Form
    {
        PerformanceCounter perfCPUCounter = new PerformanceCounter("Processor Information", "% Processor Time", "_Total");
        PerformanceCounter perfMemCounter = new PerformanceCounter("Memory", "Available MBytes");
        PerformanceCounter perfSystemCounter = new PerformanceCounter("System", "System Up Time");


        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = "       CPU:" + "                        " + (int)perfCPUCounter.NextValue() + " " + "%";
            label2.Text = "Available Memory:" + "      " + (int)perfMemCounter.NextValue() + " MB";
            label3.Text = "System Up Time:" + "        " + (int)perfSystemCounter.NextValue() / 60 /60 + " Hours";
        }
    }
}
