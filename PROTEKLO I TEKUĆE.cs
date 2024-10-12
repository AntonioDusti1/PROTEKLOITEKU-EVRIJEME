using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROTEKLO_I_TEKUĆE
{
    public partial class Form1 : Form
    {
        private DateTime pocetno;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pocetno = DateTime.Now; 
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "Trenutno: " + DateTime.Now.ToLongTimeString();
            TimeSpan proteklo = DateTime.Now - pocetno;
            toolStripStatusLabel1.Text = "Proteklo: " +
                proteklo.Hours.ToString("D2") + ":" +
                proteklo.Minutes.ToString("D2") + ":" +
                proteklo.Seconds.ToString("D2");
        }
    }
}
