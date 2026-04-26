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
    public partial class ChoiceSeoul : Form
    {
        public ChoiceSeoul()
        {
            InitializeComponent();
        }

        private void Incheon_Click(object sender, EventArgs e)
        {
            Close();
            ChoiceIncheon Incheon = new ChoiceIncheon();
            Incheon.TopMost = true;
            Incheon.Show();
        }



        private void All_Click(object sender, EventArgs e)
        {
            Close();
            DesnationChoice def = new DesnationChoice();
            def.TopMost=true;
            def.Show();
        }

        private void ChoiceSeoul_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            nowtime.Text = DateTime.Now.ToLongTimeString();
            date.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void Chungbuk_Click(object sender, EventArgs e)
        {
            Close();
            ChoiceChungbuk Chungbuk = new ChoiceChungbuk();
            Chungbuk.TopMost = true;
            Chungbuk.Show();
        }

        private void Jeonbuk_Click_1(object sender, EventArgs e)
        {
            Close();
            ChoiceJeonbuk jeonbuk = new ChoiceJeonbuk();    
            jeonbuk.TopMost = true;
            jeonbuk.Show();
        }

        private void Daegu_Click_1(object sender, EventArgs e)
        {
            Close();
            ChoiceDaegu daegu = new ChoiceDaegu();
            daegu.TopMost = true;
            daegu.Show();
        }

        private void Gangwon_Click_1(object sender, EventArgs e)
        {
            Close();
            ChoiceGangwon Gangwon = new ChoiceGangwon();   
            Gangwon.TopMost = true;
            Gangwon.Show();
        }

        private void Seoul_Click_1(object sender, EventArgs e)
        {
            Close();
            ChoiceSeoul seoul= new ChoiceSeoul();
            seoul.TopMost = true;
            seoul.Show();
        }

        private void Daejeon_Click_1(object sender, EventArgs e)
        {
            Close();
            ChoiceDajeon Daejeon = new ChoiceDajeon();
            Daejeon.TopMost = true;
            Daejeon.Show();
        }

        Seat s1;
        Time2 t2;
        private void seoul_click(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            if (bt != null && bt.Tag != null)
            {
                string bt1str = bt.Tag.ToString();              

                Time2 t2 = new Time2();
                t2.TopMost = true;
                t2.Updatedata(bt1str);
                t2.Show();

                this.Close();

            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Destination des = new Destination();
            des.TopMost = true;
            des.Show();
            Close();
        }

        private void gohome_Click(object sender, EventArgs e)
        {
            Destination des = new Destination();
            des.TopMost = true;
            des.Show();
            Close();
        }
    }
}
