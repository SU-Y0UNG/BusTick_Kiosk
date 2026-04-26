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
    public partial class Seat2 : Form
    {
        List<string> selectedSeatList = new List<string>();
        string saveData;
        public Seat2()
        {
            InitializeComponent();
        }

        private void Seat2_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            nowdate1.Text = DateTime.Now.ToString("yyyy-MM-dd(ddd)");
            timelb.Text = DateTime.Now.ToShortTimeString();
        }
        public void UpdateData(string data)
        {
            this.location1.Text = data;
            this.saveData = data;
        }

        int price1 = 0;
        int totalPrice1 = 0;
        int totalcount = 0;

        private void seat2_click(object sender, EventArgs e)
        {
            PictureBox seat = sender as PictureBox;

            int remain2 = int.Parse(labelremain.Text);

            if (seat == null) return;

            if (seat.BackColor == Color.White || seat.BackColor == SystemColors.Control)
            {
                seat.BackColor = Color.Orange;
                totalPrice1 += price1;
                remain2 -= 1;
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
                totalPrice1 -= price1;
                remain2 += 1;
                totalcount -= 1;
                string seatNum = seat.Tag.ToString();
                selectedSeatList.Remove(seatNum);
            }
            lbpay.Text = totalPrice1.ToString();
            labelremain.Text = remain2.ToString();
            count.Text = totalcount.ToString();

            Pay ticket = new Pay();
            ticket.Update(totalPrice1.ToString());

        }

        public void SetPrice(int price1)
        {
            this.price1 = price1;

        }

        private void btchoice_Click(object sender, EventArgs e)
        {
            string seatData = string.Join(", ", selectedSeatList);
            Pay ticket = new Pay();
            ticket.Update(totalPrice1.ToString());
            ticket.Updateseat(seatData);
            ticket.UpdateCount(totalcount.ToString());
            ticket.TopMost = true;
            ticket.UpdateData(saveData);
            ticket.Show();
            Close();
        }

        private void btnpre_Click(object sender, EventArgs e)
        {
            Time2 t2 = new Time2();
            t2.TopMost = true;
            t2.Show();
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
