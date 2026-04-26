namespace Kiosk
{
    partial class ChoiceSeoul
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChoiceSeoul));
            Daegu = new Button();
            Jeonbuk = new Button();
            Chungbuk = new Button();
            Daejeon = new Button();
            Gangwon = new Button();
            Incheon = new Button();
            Seoul = new Button();
            All = new Button();
            button1 = new Button();
            label2 = new Label();
            button2 = new Button();
            button3 = new Button();
            label8 = new Label();
            button4 = new Button();
            label9 = new Label();
            button8 = new Button();
            label10 = new Label();
            label5 = new Label();
            pictureBox5 = new PictureBox();
            button16 = new Button();
            gohome = new Button();
            textBox3 = new TextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            label7 = new Label();
            date = new Label();
            label1 = new Label();
            nowtime = new Label();
            label4 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Daegu
            // 
            Daegu.BackColor = SystemColors.ButtonHighlight;
            Daegu.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Daegu.Location = new Point(30, 431);
            Daegu.Name = "Daegu";
            Daegu.Size = new Size(79, 38);
            Daegu.TabIndex = 31;
            Daegu.Text = "대구/경북";
            Daegu.UseVisualStyleBackColor = false;
            Daegu.Click += Daegu_Click_1;
            // 
            // Jeonbuk
            // 
            Jeonbuk.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Jeonbuk.Location = new Point(30, 387);
            Jeonbuk.Name = "Jeonbuk";
            Jeonbuk.Size = new Size(79, 38);
            Jeonbuk.TabIndex = 30;
            Jeonbuk.Text = "전북";
            Jeonbuk.UseVisualStyleBackColor = true;
            Jeonbuk.Click += Jeonbuk_Click_1;
            // 
            // Chungbuk
            // 
            Chungbuk.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Chungbuk.Location = new Point(30, 343);
            Chungbuk.Name = "Chungbuk";
            Chungbuk.Size = new Size(79, 38);
            Chungbuk.TabIndex = 29;
            Chungbuk.Text = "충북";
            Chungbuk.UseVisualStyleBackColor = true;
            Chungbuk.Click += Chungbuk_Click;
            // 
            // Daejeon
            // 
            Daejeon.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Daejeon.Location = new Point(30, 299);
            Daejeon.Name = "Daejeon";
            Daejeon.Size = new Size(79, 38);
            Daejeon.TabIndex = 28;
            Daejeon.Text = "대전/충남";
            Daejeon.UseVisualStyleBackColor = true;
            Daejeon.Click += Daejeon_Click_1;
            // 
            // Gangwon
            // 
            Gangwon.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Gangwon.Location = new Point(30, 255);
            Gangwon.Name = "Gangwon";
            Gangwon.Size = new Size(79, 38);
            Gangwon.TabIndex = 27;
            Gangwon.Text = "강원";
            Gangwon.UseVisualStyleBackColor = true;
            Gangwon.Click += Gangwon_Click_1;
            // 
            // Incheon
            // 
            Incheon.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Incheon.Location = new Point(30, 211);
            Incheon.Name = "Incheon";
            Incheon.Size = new Size(79, 38);
            Incheon.TabIndex = 26;
            Incheon.Text = "인천/경기";
            Incheon.UseVisualStyleBackColor = true;
            Incheon.Click += Incheon_Click;
            // 
            // Seoul
            // 
            Seoul.BackColor = Color.DarkBlue;
            Seoul.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Seoul.ForeColor = Color.Transparent;
            Seoul.Location = new Point(30, 167);
            Seoul.Name = "Seoul";
            Seoul.Size = new Size(79, 38);
            Seoul.TabIndex = 32;
            Seoul.Text = "서울";
            Seoul.UseVisualStyleBackColor = false;
            Seoul.Click += Seoul_Click_1;
            // 
            // All
            // 
            All.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point);
            All.Location = new Point(30, 123);
            All.Name = "All";
            All.Size = new Size(79, 38);
            All.TabIndex = 25;
            All.Text = "전체";
            All.UseVisualStyleBackColor = true;
            All.Click += All_Click;
            // 
            // button1
            // 
            button1.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(115, 124);
            button1.Name = "button1";
            button1.Padding = new Padding(0, 0, 25, 0);
            button1.Size = new Size(193, 38);
            button1.TabIndex = 42;
            button1.Tag = "가락시장";
            button1.Text = "가락시장";
            button1.UseVisualStyleBackColor = true;
            button1.Click += seoul_click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightSkyBlue;
            label2.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(121, 173);
            label2.Name = "label2";
            label2.Padding = new Padding(3, 7, 3, 7);
            label2.Size = new Size(42, 29);
            label2.TabIndex = 39;
            label2.Text = "고/시";
            label2.Click += seoul_click;
            // 
            // button2
            // 
            button2.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(115, 168);
            button2.Name = "button2";
            button2.Padding = new Padding(0, 0, 35, 0);
            button2.Size = new Size(193, 38);
            button2.TabIndex = 42;
            button2.Tag = "동서울";
            button2.Text = "동서울";
            button2.UseVisualStyleBackColor = true;
            button2.Click += seoul_click;
            // 
            // button3
            // 
            button3.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(115, 211);
            button3.Name = "button3";
            button3.Padding = new Padding(0, 0, 35, 0);
            button3.Size = new Size(193, 38);
            button3.TabIndex = 42;
            button3.Tag = "장지역";
            button3.Text = "장지역";
            button3.UseVisualStyleBackColor = true;
            button3.Click += seoul_click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.ForestGreen;
            label8.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(121, 216);
            label8.Name = "label8";
            label8.Padding = new Padding(3, 7, 3, 7);
            label8.Size = new Size(41, 29);
            label8.TabIndex = 39;
            label8.Text = "시 외";
            label8.Click += seoul_click;
            // 
            // button4
            // 
            button4.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(323, 124);
            button4.Name = "button4";
            button4.Padding = new Padding(0, 0, 25, 0);
            button4.Size = new Size(193, 38);
            button4.TabIndex = 42;
            button4.Tag = "김포공항";
            button4.Text = "김포공항";
            button4.UseVisualStyleBackColor = true;
            button4.Click += seoul_click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.ForestGreen;
            label9.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(329, 129);
            label9.Name = "label9";
            label9.Padding = new Padding(3, 7, 3, 7);
            label9.Size = new Size(41, 29);
            label9.TabIndex = 39;
            label9.Text = "시 외";
            label9.Click += seoul_click;
            // 
            // button8
            // 
            button8.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button8.Location = new Point(323, 168);
            button8.Name = "button8";
            button8.Padding = new Padding(0, 0, 35, 0);
            button8.Size = new Size(193, 38);
            button8.TabIndex = 42;
            button8.Tag = "잠실역";
            button8.Text = "잠실역";
            button8.UseVisualStyleBackColor = true;
            button8.Click += seoul_click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.ForestGreen;
            label10.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(329, 173);
            label10.Name = "label10";
            label10.Padding = new Padding(3, 7, 3, 7);
            label10.Size = new Size(41, 29);
            label10.TabIndex = 39;
            label10.Text = "시 외";
            label10.Click += seoul_click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.ForestGreen;
            label5.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(121, 129);
            label5.Name = "label5";
            label5.Padding = new Padding(3, 7, 3, 7);
            label5.Size = new Size(41, 29);
            label5.TabIndex = 39;
            label5.Text = "시 외";
            label5.Click += seoul_click;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.RoyalBlue;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(19, 607);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(47, 40);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 139;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // button16
            // 
            button16.BackColor = Color.RoyalBlue;
            button16.FlatAppearance.BorderColor = Color.White;
            button16.FlatAppearance.BorderSize = 2;
            button16.FlatStyle = FlatStyle.Flat;
            button16.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button16.ForeColor = Color.White;
            button16.Location = new Point(12, 602);
            button16.Name = "button16";
            button16.Size = new Size(65, 52);
            button16.TabIndex = 137;
            button16.UseVisualStyleBackColor = false;
            button16.Click += button16_Click;
            // 
            // gohome
            // 
            gohome.BackColor = Color.RoyalBlue;
            gohome.FlatAppearance.BorderColor = Color.White;
            gohome.FlatAppearance.BorderSize = 2;
            gohome.FlatStyle = FlatStyle.Flat;
            gohome.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            gohome.ForeColor = Color.White;
            gohome.Location = new Point(85, 602);
            gohome.Name = "gohome";
            gohome.Size = new Size(448, 52);
            gohome.TabIndex = 138;
            gohome.Text = "이전으로";
            gohome.UseVisualStyleBackColor = false;
            gohome.Click += gohome_Click;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.RoyalBlue;
            textBox3.Location = new Point(-11, 592);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(571, 74);
            textBox3.TabIndex = 136;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.RoyalBlue;
            label7.Font = new Font("맑은 고딕", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(362, 23);
            label7.Name = "label7";
            label7.Size = new Size(29, 26);
            label7.TabIndex = 147;
            label7.Text = "현재\r\n시간";
            // 
            // date
            // 
            date.AutoSize = true;
            date.BackColor = Color.RoyalBlue;
            date.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            date.ForeColor = Color.White;
            date.Location = new Point(410, 8);
            date.Name = "date";
            date.Size = new Size(72, 17);
            date.TabIndex = 148;
            date.Text = "todayDate";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.RoyalBlue;
            label1.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(11, 70);
            label1.Name = "label1";
            label1.Size = new Size(195, 25);
            label1.TabIndex = 144;
            label1.Text = "도착지를 선택하세요.";
            // 
            // nowtime
            // 
            nowtime.AutoSize = true;
            nowtime.BackColor = Color.RoyalBlue;
            nowtime.Font = new Font("맑은 고딕", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            nowtime.ForeColor = Color.White;
            nowtime.Location = new Point(397, 16);
            nowtime.Name = "nowtime";
            nowtime.Size = new Size(54, 30);
            nowtime.TabIndex = 145;
            nowtime.Text = "time";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.RoyalBlue;
            label4.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(111, 20);
            label4.Name = "label4";
            label4.Size = new Size(47, 17);
            label4.TabIndex = 146;
            label4.Text = "NO.44";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.RoyalBlue;
            label3.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Coral;
            label3.Location = new Point(45, 11);
            label3.Name = "label3";
            label3.Size = new Size(55, 30);
            label3.TabIndex = 143;
            label3.Text = "천안";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.RoyalBlue;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(11, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(34, 37);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 142;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.RoyalBlue;
            textBox1.Location = new Point(-11, 52);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(598, 65);
            textBox1.TabIndex = 140;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.RoyalBlue;
            textBox2.Location = new Point(-11, -2);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(584, 65);
            textBox2.TabIndex = 141;
            // 
            // ChoiceSeoul
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 660);
            Controls.Add(label7);
            Controls.Add(date);
            Controls.Add(label1);
            Controls.Add(nowtime);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(textBox1);
            Controls.Add(textBox2);
            Controls.Add(pictureBox5);
            Controls.Add(button16);
            Controls.Add(gohome);
            Controls.Add(textBox3);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label5);
            Controls.Add(label8);
            Controls.Add(label2);
            Controls.Add(button8);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Daegu);
            Controls.Add(Jeonbuk);
            Controls.Add(Chungbuk);
            Controls.Add(Daejeon);
            Controls.Add(Gangwon);
            Controls.Add(Incheon);
            Controls.Add(Seoul);
            Controls.Add(All);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ChoiceSeoul";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChoiceSeoul";
            Load += ChoiceSeoul_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Daegu;
        private Button Jeonbuk;
        private Button Chungbuk;
        private Button Daejeon;
        private Button Gangwon;
        private Button Incheon;
        private Button Seoul;
        private Button All;
        private Button button1;
        private Label label2;
        private Button button2;
        private Button button3;
        private Label label8;
        private Button button4;
        private Label label9;
        private Button button8;
        private Label label10;
        private Label label5;
        private PictureBox pictureBox5;
        private Button button16;
        private Button gohome;
        private TextBox textBox3;
        private System.Windows.Forms.Timer timer1;
        private Label label7;
        private Label date;
        private Label label1;
        private Label nowtime;
        private Label label4;
        private Label label3;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}