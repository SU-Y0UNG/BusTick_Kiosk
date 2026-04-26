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
    public partial class ChoiceDajeon : Form
    {
        Seat s1;
        Time2 t2;
        public ChoiceDajeon()
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


        private void ChoiceDajeon_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            nowtime.Text = DateTime.Now.ToLongTimeString();
            date.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void seoul_Click_1(object sender, EventArgs e)
        {
            
            ChoiceSeoul Seoul = new ChoiceSeoul();
            Seoul.TopMost = true;
            Seoul.Show();
            Close();
        }

        private void Incheon_Click_1(object sender, EventArgs e)
        {
            
            ChoiceIncheon Incheon = new ChoiceIncheon();

            Incheon.TopMost = true;
            Incheon.Show();
            Close();
        }

        private void gangwon_Click_1(object sender, EventArgs e)
        {
            
            ChoiceGangwon Gangwon = new ChoiceGangwon();
            Gangwon.TopMost = true;

            Gangwon.Show();
            Close();
        }

        private void daejeon_Click_1(object sender, EventArgs e)
        {
            
            ChoiceDajeon Daejeon = new ChoiceDajeon();
            Daejeon.TopMost = true;
            Daejeon.Show();
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            ChoiceChungbuk Chungbuk = new ChoiceChungbuk();
            Chungbuk.TopMost = true;
            Chungbuk.Show();
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            ChoiceJeonbuk jeonbuk = new ChoiceJeonbuk();
            jeonbuk.TopMost = true;
            jeonbuk.Show();
            Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            ChoiceDaegu daegu = new ChoiceDaegu();
            daegu.TopMost = true;
            daegu.Show();
            Close();
        }

        private void daejeon_click(object sender, EventArgs e)
        {
            Button bt1 = sender as Button;
            if (bt1 != null && bt1.Tag != null)
            {
                string bt1str = bt1.Tag.ToString();

                
                Time2 t2=new Time2();
                t2.TopMost = true;
                t2.Updatedata(bt1str);
                t2.Show();
                Close();
            }
        }

        private void gohome_Click(object sender, EventArgs e)
        {
            Destination des = new Destination();
            des.TopMost = true;
            des.Show();
            Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
