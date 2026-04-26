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
    public partial class Time : Form
    {
        string saveData;
        public Time()
        {
            InitializeComponent();
        }


        public void UpdataData(string data)
        {
            timelc.Text = data;
            this.saveData = data;
        }

        private void Time_Load(object sender, EventArgs e)
        {
            nowdate.Text = DateTime.Now.ToString("yyyy.MM.dd(ddd)");
        }

        private void time_click(object sender, EventArgs e)
        {

            Seat s1 = new Seat();
            s1.TopMost = true;
            string priceText = lb14200.Text.Replace(",", "").Trim();
            if (int.TryParse(priceText, out int price))
            {
                s1.SetPrice(price);
            }
            else
            {
                s1.SetPrice(14200);
            }

            s1.UpdateData(this.saveData);
            s1.Show();
            Close();
        }

        private void btnpre_Click(object sender, EventArgs e)
        {
            DesnationChoice desnationChoice = new DesnationChoice();
            desnationChoice.TopMost = true;
            desnationChoice.Show();
            Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Close();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
