namespace Kiosk
{
    partial class Choiceservice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Choiceservice));
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            date = new Label();
            label7 = new Label();
            nowtime = new Label();
            On_site = new Button();
            pictureBox2 = new PictureBox();
            label8 = new Label();
            Online = new Button();
            pictureBox3 = new PictureBox();
            label9 = new Label();
            Refund = new Button();
            pictureBox4 = new PictureBox();
            label10 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.SandyBrown;
            textBox1.Dock = DockStyle.Top;
            textBox1.Location = new Point(0, 0);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(554, 47);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SandyBrown;
            label1.Font = new Font("맑은 고딕", 18.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(59, 2);
            label1.Name = "label1";
            label1.Size = new Size(260, 35);
            label1.TabIndex = 1;
            label1.Text = "[버스 승차권 발매기] ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.SandyBrown;
            label2.Font = new Font("맑은 고딕", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(392, 9);
            label2.Name = "label2";
            label2.Size = new Size(113, 28);
            label2.TabIndex = 2;
            label2.Text = "[카드 전용]";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.RoyalBlue;
            textBox2.Location = new Point(0, 42);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(554, 65);
            textBox2.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.RoyalBlue;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 53);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(34, 37);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.RoyalBlue;
            label3.Font = new Font("맑은 고딕", 17.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Salmon;
            label3.Location = new Point(46, 55);
            label3.Name = "label3";
            label3.Size = new Size(60, 31);
            label3.TabIndex = 5;
            label3.Text = "천안";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.RoyalBlue;
            label4.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(112, 64);
            label4.Name = "label4";
            label4.Size = new Size(47, 17);
            label4.TabIndex = 6;
            label4.Text = "NO.44";
            // 
            // date
            // 
            date.AutoSize = true;
            date.BackColor = Color.RoyalBlue;
            date.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            date.ForeColor = Color.White;
            date.Location = new Point(422, 50);
            date.Name = "date";
            date.Size = new Size(72, 17);
            date.TabIndex = 8;
            date.Text = "todayDate";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.RoyalBlue;
            label7.Font = new Font("맑은 고딕", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(363, 67);
            label7.Name = "label7";
            label7.Size = new Size(29, 26);
            label7.TabIndex = 8;
            label7.Text = "현재\r\n시간";
            // 
            // nowtime
            // 
            nowtime.AutoSize = true;
            nowtime.BackColor = Color.RoyalBlue;
            nowtime.Font = new Font("맑은 고딕", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            nowtime.ForeColor = Color.White;
            nowtime.Location = new Point(403, 67);
            nowtime.Name = "nowtime";
            nowtime.Size = new Size(51, 25);
            nowtime.TabIndex = 6;
            nowtime.Text = "time";
            // 
            // On_site
            // 
            On_site.BackColor = Color.Chocolate;
            On_site.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            On_site.ForeColor = Color.White;
            On_site.ImageAlign = ContentAlignment.TopCenter;
            On_site.Location = new Point(94, 180);
            On_site.Name = "On_site";
            On_site.Padding = new Padding(0, 0, 35, 35);
            On_site.Size = new Size(360, 99);
            On_site.TabIndex = 9;
            On_site.Text = "현장 발권";
            On_site.UseVisualStyleBackColor = false;
            On_site.Click += On_site_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Chocolate;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(115, 197);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(71, 61);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Chocolate;
            label8.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(209, 241);
            label8.Name = "label8";
            label8.Size = new Size(109, 17);
            label8.TabIndex = 6;
            label8.Text = "승차권 바로 구매";
            // 
            // Online
            // 
            Online.BackColor = Color.RoyalBlue;
            Online.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Online.ForeColor = Color.White;
            Online.ImageAlign = ContentAlignment.TopCenter;
            Online.Location = new Point(94, 302);
            Online.Name = "Online";
            Online.Padding = new Padding(35, 0, 0, 35);
            Online.Size = new Size(360, 99);
            Online.TabIndex = 9;
            Online.Text = "온라인 예매 발권";
            Online.UseVisualStyleBackColor = false;
            Online.Click += Online_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.RoyalBlue;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(115, 321);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(78, 60);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.RoyalBlue;
            label9.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(209, 363);
            label9.Name = "label9";
            label9.Size = new Size(122, 17);
            label9.TabIndex = 6;
            label9.Text = "예매한 승차권 찾기\r\n";
            // 
            // Refund
            // 
            Refund.BackColor = Color.DarkOrchid;
            Refund.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Refund.ForeColor = Color.White;
            Refund.ImageAlign = ContentAlignment.TopCenter;
            Refund.Location = new Point(94, 428);
            Refund.Name = "Refund";
            Refund.Padding = new Padding(0, 0, 80, 35);
            Refund.Size = new Size(360, 99);
            Refund.TabIndex = 9;
            Refund.Text = "환불";
            Refund.UseVisualStyleBackColor = false;
            Refund.Click += Refund_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.DarkOrchid;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(115, 449);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(71, 61);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 10;
            pictureBox4.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.DarkOrchid;
            label10.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(209, 489);
            label10.Name = "label10";
            label10.Size = new Size(109, 17);
            label10.TabIndex = 6;
            label10.Text = "구매 승차권 환불\r\n";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Choiceservice
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(554, 660);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(Refund);
            Controls.Add(Online);
            Controls.Add(On_site);
            Controls.Add(label7);
            Controls.Add(date);
            Controls.Add(nowtime);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Choiceservice";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChoiceService";
            Load += Choiceservice_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label4;
        private Label date;
        private Label label7;
        private Label nowtime;
        private Button On_site;
        private PictureBox pictureBox2;
        private Label label8;
        private Button Online;
        private PictureBox pictureBox3;
        private Label label9;
        private Button Refund;
        private PictureBox pictureBox4;
        private Label label10;
        private System.Windows.Forms.Timer timer1;
    }
}