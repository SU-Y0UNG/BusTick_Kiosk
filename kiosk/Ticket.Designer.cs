namespace Kiosk
{
    partial class Ticket
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            topBar = new TextBox();
            lblTitle = new Label();
            lblGuide = new Label();
            txtPhone = new TextBox();
            btnSearch = new Button();
            panelKeypad = new Panel();
            panelResult = new Panel();
            lblResultTitle = new Label();
            dgvReservations = new DataGridView();
            btnPrint = new Button();
            lblMessage = new Label();
            btnBack = new Button();
            btnHome = new Button();
            panelResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReservations).BeginInit();
            SuspendLayout();
            // 
            // topBar
            // 
            topBar.BackColor = Color.SandyBrown;
            topBar.Dock = DockStyle.Top;
            topBar.Location = new Point(0, 0);
            topBar.Multiline = true;
            topBar.Name = "topBar";
            topBar.ReadOnly = true;
            topBar.Size = new Size(558, 47);
            topBar.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.SandyBrown;
            lblTitle.Font = new Font("맑은 고딕", 18.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(558, 47);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "온라인 예매 발권";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGuide
            // 
            lblGuide.Font = new Font("맑은 고딕", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblGuide.ForeColor = Color.FromArgb(50, 50, 50);
            lblGuide.Location = new Point(39, 75);
            lblGuide.Name = "lblGuide";
            lblGuide.Size = new Size(474, 35);
            lblGuide.TabIndex = 2;
            lblGuide.Text = "예매 시 등록한 핸드폰 번호를 입력하세요";
            lblGuide.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("맑은 고딕", 20F, FontStyle.Regular, GraphicsUnit.Point);
            txtPhone.Location = new Point(69, 120);
            txtPhone.MaxLength = 13;
            txtPhone.Name = "txtPhone";
            txtPhone.PlaceholderText = "010-0000-0000";
            txtPhone.Size = new Size(300, 43);
            txtPhone.TabIndex = 3;
            txtPhone.TextAlign = HorizontalAlignment.Center;
            txtPhone.KeyPress += txtPhone_KeyPress;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.RoyalBlue;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("맑은 고딕", 13F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(379, 120);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(100, 44);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "조회";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // panelKeypad
            // 
            panelKeypad.Location = new Point(69, 180);
            panelKeypad.Name = "panelKeypad";
            panelKeypad.Size = new Size(410, 260);
            panelKeypad.TabIndex = 5;
            // 
            // panelResult
            // 
            panelResult.AutoScroll = true;
            panelResult.Controls.Add(lblResultTitle);
            panelResult.Controls.Add(dgvReservations);
            panelResult.Controls.Add(btnPrint);
            panelResult.Location = new Point(19, 175);
            panelResult.Name = "panelResult";
            panelResult.Size = new Size(514, 370);
            panelResult.TabIndex = 6;
            panelResult.Visible = false;
            // 
            // lblResultTitle
            // 
            lblResultTitle.Font = new Font("맑은 고딕", 13F, FontStyle.Bold, GraphicsUnit.Point);
            lblResultTitle.ForeColor = Color.RoyalBlue;
            lblResultTitle.Location = new Point(5, 5);
            lblResultTitle.Name = "lblResultTitle";
            lblResultTitle.Size = new Size(500, 30);
            lblResultTitle.TabIndex = 0;
            lblResultTitle.Text = "📋 예매 내역";
            // 
            // dgvReservations
            // 
            dgvReservations.AllowUserToAddRows = false;
            dgvReservations.AllowUserToDeleteRows = false;
            dgvReservations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReservations.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.RoyalBlue;
            dataGridViewCellStyle1.Font = new Font("맑은 고딕", 10F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvReservations.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvReservations.ColumnHeadersHeight = 35;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("맑은 고딕", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvReservations.DefaultCellStyle = dataGridViewCellStyle2;
            dgvReservations.EnableHeadersVisualStyles = false;
            dgvReservations.Location = new Point(5, 40);
            dgvReservations.Name = "dgvReservations";
            dgvReservations.ReadOnly = true;
            dgvReservations.RowHeadersVisible = false;
            dgvReservations.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReservations.Size = new Size(500, 260);
            dgvReservations.TabIndex = 1;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.RoyalBlue;
            btnPrint.FlatAppearance.BorderSize = 0;
            btnPrint.FlatStyle = FlatStyle.Flat;
            btnPrint.Font = new Font("맑은 고딕", 13F, FontStyle.Bold, GraphicsUnit.Point);
            btnPrint.ForeColor = Color.White;
            btnPrint.Location = new Point(130, 310);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(240, 50);
            btnPrint.TabIndex = 2;
            btnPrint.Text = "선택한 승차권 발권";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click;
            // 
            // lblMessage
            // 
            lblMessage.Font = new Font("맑은 고딕", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblMessage.ForeColor = Color.Red;
            lblMessage.Location = new Point(39, 535);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(474, 25);
            lblMessage.TabIndex = 7;
            lblMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Gray;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(69, 560);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(180, 50);
            btnBack.TabIndex = 8;
            btnBack.Text = "← 뒤로가기";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.Chocolate;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnHome.ForeColor = Color.White;
            btnHome.Location = new Point(299, 560);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(180, 50);
            btnHome.TabIndex = 9;
            btnHome.Text = "🏠 처음으로";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // Ticket
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(558, 664);
            Controls.Add(btnHome);
            Controls.Add(btnBack);
            Controls.Add(lblMessage);
            Controls.Add(panelResult);
            Controls.Add(panelKeypad);
            Controls.Add(btnSearch);
            Controls.Add(txtPhone);
            Controls.Add(lblGuide);
            Controls.Add(lblTitle);
            Controls.Add(topBar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Ticket";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "온라인 예매 발권";
            Load += Ticket_Load;
            panelResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvReservations).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox topBar;
        private Label lblTitle;
        private Label lblGuide;
        private TextBox txtPhone;
        private Button btnSearch;
        private Panel panelKeypad;
        private Panel panelResult;
        private Label lblResultTitle;
        private DataGridView dgvReservations;
        private Button btnPrint;
        private Label lblMessage;
        private Button btnBack;
        private Button btnHome;
    }
}