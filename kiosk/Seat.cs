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


    public partial class Seat : Form
    {
        List<string> selectedSeatList = new List<string>();

        string saveData;
        public Seat()
        {
            InitializeComponent();
        }
        //public Seat(ChoiceChungbuk cb)
        //{
        //    InitializeComponent();
        //    this.cb = cb;
        //}
        public void UpdateData(string data)
        {
            arrive.Text = data;
            saveData = data;
        }
        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void Seat_Load(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            nowdate.Text = DateTime.Now.ToString("yyyy-MM-dd(ddd)");
            timelb.Text = DateTime.Now.ToShortTimeString();
        }

        int price = 14200;
        int totalPrice = 0;
        int totalcount = 0;

        private void Seat_Click(object sender, EventArgs e)
        {
            PictureBox seat = sender as PictureBox;

            int remain = int.Parse(lbremain.Text);

            if (seat == null) return;

            if (seat.BackColor == Color.White || seat.BackColor == SystemColors.Control)
            {
                seat.BackColor = Color.Orange;
                totalPrice += price;
                remain -= 1;
                totalcount += 1;


                if (seat != null && seat.Tag != null)
                {
                    string seatNum = seat.Tag.ToString();
                    selectedSeatList.Add(seatNum);
                    MessageBox.Show(seatNum + "번 좌석을 선택했습니다.");
                }
            }
            else
            {
                seat.BackColor = SystemColors.Control;
                totalPrice -= price;
                remain += 1;
                totalcount -= 1;
                string seatNum = seat.Tag.ToString();
                selectedSeatList.Remove(seatNum);
            }
            lbpay.Text = totalPrice.ToString();
            lbremain.Text = remain.ToString();
            count.Text = totalcount.ToString();

            Pay ticket = new Pay();
            ticket.Update(totalPrice.ToString());

        }
        public void SetPrice(int price)
        {
            this.price = price;

        }

        public void btchoice_Click(object sender, EventArgs e)
        {
            string seatData = string.Join(", ", selectedSeatList);

            Pay pay= new Pay();
            
            pay.Update(totalPrice.ToString());
            pay.Updateseat(seatData);
            pay.UpdateCount(totalcount.ToString());
            pay.TopMost = true;
            pay.UpdateData(saveData);
            pay.Show();
            this.Close();
        }

        private void btnpre_Click(object sender, EventArgs e)
        {
            Time t1 = new Time();
            t1.TopMost = true;
            t1.Show();
            Close();
        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
