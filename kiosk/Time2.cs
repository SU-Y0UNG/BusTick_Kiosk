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
    public partial class Time2 : Form
    {

        string saveData;
        public Time2()
        {
            InitializeComponent();
        }

        public void Updatedata(string data)
        {
            this.timelc.Text = data;
            this.saveData = data;

        }

        private void Time2_Load(object sender, EventArgs e)
        {
            nowdate.Text = DateTime.Now.ToString("yyyy.MM.dd(ddd)");
        }

        private void time_click(object sender, EventArgs e)
        {

            Seat2 s2 = new Seat2();
            s2.TopMost = true;
            string priceText = lb7800.Text.Replace(",", "").Trim();
            if (int.TryParse(priceText, out int price1))
            {
                s2.SetPrice(price1);
            }
            else
            {
                s2.SetPrice(7800);
            }
            s2.UpdateData(this.saveData);
            s2.Show();
            this.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

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
            this.Close();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
