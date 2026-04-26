using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiosk
{
    public partial class Pay : Form
    {
        public Pay()
        {
            InitializeComponent();
        }

        private void cancelpay_Click(object sender, EventArgs e)
        {
            MessageBox.Show("결제가 취소되었습니다.");
            Seat s1= new Seat();
            s1.TopMost = true;
            s1.Show();
            Close();
        }

        public void UpdateData(string data)
        {
            this.arrive.Text= data;
        }

        private int max = 3000;
        private int end = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            date.Text = DateTime.Now.ToString("yyyy-MM-dd");
            nowtime.Text = DateTime.Now.ToShortTimeString();
            date2.Text = DateTime.Now.ToString("yyyy-MM-dd(ddd)");
            
            end += timer1.Interval;
            if (end <= max)
            {
                progressBar1.Value = end;
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("결제가 완료되었습니다.");
                MessageBox.Show("승차권이 발권되었습니다");
                Close();
            }

        }

        private void Ticket_Load(object sender, EventArgs e)
        {
            progressBar1.Maximum = max;
            progressBar1.Value = 0;
            timer1.Start();

        }
        public void Update(string data)
        {
            this.totalprice.Text = data+" 원";

        }
        public void Updateseat(string data)
        {
            this.seatnum.Text = data;
        }
        public void UpdateCount(string count)
        {
            this.ticketcount.Text = count;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
