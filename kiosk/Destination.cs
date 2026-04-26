using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiosk
{
    public partial class Destination : Form
    {
        Choiceservice ch1;
        public int BorderRadius { get; set; } = 30;
        public Destination()
        {
            InitializeComponent();
        }

        public Destination(Choiceservice ch1)
        {
            InitializeComponent();
            this.ch1 = ch1;
        }

        private void defchoice_Click(object sender, EventArgs e)
        {
            Close();
            DesnationChoice desnationChoice = new DesnationChoice();
            desnationChoice.TopMost = true;
            desnationChoice.Show();
        }

        private void Destination_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            nowtime.Text = DateTime.Now.ToLongTimeString();
            date.Text = DateTime.Now.ToString("yyyy-MM-dd");
            todaydate.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void gohome_Click(object sender, EventArgs e)
        {
            Close();
            
        }

        private void home_Click(object sender, EventArgs e)
        {
            Close();
            
        }

        private void go_home_Click(object sender, EventArgs e)
        {
            Close();
            
        }
    }
}
