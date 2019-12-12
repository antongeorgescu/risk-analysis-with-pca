using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R_MessageBroker
{
    public partial class SplashForm : Form
    {

        Timer t = new Timer();
        List<string> jobInfo;
        //int hh = 0;
        int mm = 0;
        int ss = 0;

        public SplashForm()
        {
            InitializeComponent();
        }

        public List<string> InformationText
        {
            set
            {
                jobInfo = new List<string>(value.ToArray<string>());
            }
        }

        void timer_Tick(object sender, EventArgs e)
        {
            //get current time
            //int hh = DateTime.Now.Hour;
            //int mm = DateTime.Now.Minute;
            //int ss = DateTime.Now.Second;

            ss = ss + 1;
            if (ss == 60)
            {
                ss = 0;
                mm = mm + 1;
                if (mm == 60)
                {
                    mm = 0;
                //    hh = hh + 1;
                }
            }

            //time
            string time = "";

            //padding leading zero
            //if (hh < 10)
            //{
            //    time += "0" + hh;
            //}
            //else
            //{
            //    time += hh;
            //}
            //time += ":";

            if (mm < 10)
            {
                time += "0" + mm;
            }
            else
            {
                time += mm;
            }
            time += ":";

            if (ss < 10)
            {
                time += "0" + ss;
            }
            else
            {
                time += ss;
            }

            tbTimer.Text = time;
        }

        private void SplashForm_OnFormClosing(object sender, FormClosingEventArgs e)
        {
            t.Stop();
        }

        public void RestartTimer()
        {
            t.Stop();
            t.Start();
            //hh = 0;
            mm = 0;
            ss = 0;
        }

        private void SplashForm_OnLoad(object sender, EventArgs e)
        {
            t.Interval = 1000; // specify interval time as you want
            t.Tick += new EventHandler(timer_Tick);
            t.Start();
        }

        private void SplashForm_VisibleChanged(object sender, EventArgs e)
        {
            mm = 0;
            ss = 0;
            tbInfo.Clear();
            foreach (var line in jobInfo)
                tbInfo.AppendText(line);
        }
    }
}
