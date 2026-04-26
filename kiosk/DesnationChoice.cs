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
    public partial class DesnationChoice : Form
    {
        public DesnationChoice()
        {
            InitializeComponent();
        }

        private void DesnationChoice_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            nowtime.Text = DateTime.Now.ToLongTimeString();
            date.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void Seoul_Click(object sender, EventArgs e)
        {

            ChoiceSeoul Seoul = new ChoiceSeoul();
            Seoul.TopMost = true;
            Seoul.Show();
            Close();
        }

        private void Incheon_Click(object sender, EventArgs e)
        {

            ChoiceIncheon Incheon = new ChoiceIncheon();
            Incheon.TopMost = true;
            Incheon.Show();
            Close();
        }

        private void Gangwon_Click(object sender, EventArgs e)
        {

            ChoiceGangwon Gangwon = new ChoiceGangwon();
            Gangwon.TopMost = true;
            Gangwon.Show();
            Close();
        }

        private void Daejeon_Click(object sender, EventArgs e)
        {

            ChoiceDajeon Daejeon = new ChoiceDajeon();
            Daejeon.TopMost = true;
            Daejeon.Show();
            Close();
        }

        private void Chunbuk_Click(object sender, EventArgs e)
        {

            ChoiceChungbuk Chungbuk = new ChoiceChungbuk();
            Chungbuk.TopMost = true;
            Chungbuk.Show();
            Close();
        }

        private void Jeonbuk_Click(object sender, EventArgs e)
        {

            ChoiceJeonbuk jeonbuk = new ChoiceJeonbuk();
            jeonbuk.TopMost = true;
            jeonbuk.Show();
            Close();
        }

        private void Daegu_Click(object sender, EventArgs e)
        {

            ChoiceDaegu daegu = new ChoiceDaegu();
            daegu.TopMost = true;
            daegu.Show();
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

        Seat s1;
        Time2 t2;
        private void all_click(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            if (bt != null && bt.Tag != null)
            {
                string bt1str = bt.Tag.ToString();                                              

                Time2 t2 = new Time2();
                t2.TopMost = true;
                t2.Updatedata(bt1str);
                t2.Show();
                Close();

            }
        }

        private void prebtn_Click(object sender, EventArgs e)
        {
            Destination des= new Destination();
            des.TopMost = true;
            des.Show();
            Close();

        }
    }
}
