using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiosk
{
    public partial class Choiceservice : Form
    {

        public Choiceservice()
        {
            InitializeComponent();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            nowtime.Text = DateTime.Now.ToLongTimeString();
            date.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void Choiceservice_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void On_site_Click(object sender, EventArgs e)
        {
            Destination destination = new Destination(this);
            destination.Show();

        }

        // ─── 온라인 예매 발권 버튼 클릭 ───
        private void Online_Click(object sender, EventArgs e)
        {
            Ticket ticket = new Ticket(this);
            ticket.Show();
        }

        // ─── 환불 버튼 클릭 ───
        private void Refund_Click(object sender, EventArgs e)
        {
            Refund refund = new Refund();
            refund.Show();
        }
    }
}