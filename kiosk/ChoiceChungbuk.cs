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

    public partial class ChoiceChungbuk : Form
    {
        Seat s1;
        Time2 t2;
        public ChoiceChungbuk()
        {
            InitializeComponent();
        }

        private void All_Click(object sender, EventArgs e)
        {
            
            DesnationChoice def = new DesnationChoice();
            def.TopMost=true;
            def.Show();
            Close();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            nowtime.Text = DateTime.Now.ToLongTimeString();
            date.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void ChoiceChungbuk_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Gangwon_Click_1(object sender, EventArgs e)
        {
            
            ChoiceGangwon Gangwon = new ChoiceGangwon();
            Gangwon.TopMost = true;
            Gangwon.Show();
            Close();
        }

        private void Seoul_Click(object sender, EventArgs e)
        {
            
            ChoiceSeoul Seoul = new ChoiceSeoul();
            Seoul.TopMost = true;
            Seoul.Show(); Close();
        }

        private void Incheon_Click(object sender, EventArgs e)
        {
            
            ChoiceIncheon Incheon = new ChoiceIncheon();
            Incheon.TopMost = true;
            Incheon.Show(); Close();
        }


        private void Daejeon_Click(object sender, EventArgs e)
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
        public ChoiceChungbuk(string data)
        {
            ChoiceChungbuk chungbuk = new ChoiceChungbuk();
            chungbuk.TopMost = true;
            chungbuk.Show();
            Close ();
        }

        private void chungbuk_Click(object sender, EventArgs e)
        {
            Button bt1 = sender as Button;
            if (bt1 != null && bt1.Tag != null)
            {
                string bt1str = bt1.Tag.ToString();

                Time2 t2= new Time2();
                t2.TopMost= true;
                t2.Show();
                t2.Updatedata(bt1str);
                Close();

            }


        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gohome_Click(object sender, EventArgs e)
        {
            Destination des= new Destination();
            des.TopMost= true;
            des.Show();
            Close();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
