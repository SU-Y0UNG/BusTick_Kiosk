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
    public partial class ChoiceGangwon : Form
    {
        Seat s1;
        Time t1;
        public ChoiceGangwon()
        {
            InitializeComponent();
        }


        private void Incheon_Click(object sender, EventArgs e)
        {
           
            ChoiceIncheon Incheon = new ChoiceIncheon();
            Incheon.TopMost = true;
            Incheon.Show();
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            nowtime.Text = DateTime.Now.ToLongTimeString();
            date.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void ChoiceGangwon_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Daejeon_Click_1(object sender, EventArgs e)
        {
            
            ChoiceDajeon Daejeon = new ChoiceDajeon();
            Daejeon.TopMost = true;
            Daejeon.Show();
            Close();
        }

        private void Chungbuk_Click(object sender, EventArgs e)
        {
            
            ChoiceChungbuk Chungbuk = new ChoiceChungbuk();
            Chungbuk.TopMost = true;
            Chungbuk.Show();
            Close();
        }

        private void All_Click_1(object sender, EventArgs e)
        {
            
            DesnationChoice def = new DesnationChoice();
            def.TopMost = true;
            def.Show();
            Close();
        }

        private void Seoul_Click_1(object sender, EventArgs e)
        {
            
            ChoiceSeoul Seoul = new ChoiceSeoul();
            Seoul.TopMost = true;
            Seoul.Show();
            Close();
        }

        private void Jeonbuk_Click_1(object sender, EventArgs e)
        {
           
            ChoiceJeonbuk jeonbuk = new ChoiceJeonbuk();
            jeonbuk.TopMost = true;
            jeonbuk.Show();
            Close();
        }

        private void Daegu_Click_1(object sender, EventArgs e)
        {
            
            ChoiceDaegu daegu = new ChoiceDaegu();
            daegu.TopMost = true;
            daegu.Show();
            Close();
        }

        private void Gangwon_Click_1(object sender, EventArgs e)
        {
            
            ChoiceGangwon Gangwon = new ChoiceGangwon();
            Gangwon.TopMost = true;
            Gangwon.Show();
            Close();
        }

        private void gangwon(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null && btn.Tag != null)
            {
                string bt1str = btn.Tag.ToString();

                Time t1=new Time();
                t1.TopMost = true;
                t1.UpdataData(bt1str);
                t1.Show();

                Close();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gohome_Click(object sender, EventArgs e)
        {
            Destination des = new Destination();
            des.TopMost = true;
            des.Show();
            Close(); 
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
