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
    public partial class Ticket : Form
    {
        private Choiceservice parentForm;

        // ─── 예매 데이터 ───
        private static List<ReservationInfo> sampleReservations = new List<ReservationInfo>
        {
            new ReservationInfo("010-1234-5678", "R20260425001", "천안 → 서울", "2026-04-25", "09:00", "3", "일반", 15000),
            new ReservationInfo("010-1234-5678", "R20260425002", "천안 → 대전", "2026-04-25", "11:30", "7", "일반", 8000),
            new ReservationInfo("010-3333-4444", "R20260426001", "천안 → 대구", "2026-04-26", "14:00", "12", "우등", 28000),
            new ReservationInfo("010-1111-2222", "R20260425003", "천안 → 인천", "2026-04-25", "16:00", "16", "일반", 18000),
            new ReservationInfo("010-1111-2222", "R20260427001", "천안 → 강릉", "2026-04-27", "08:00", "5", "우등", 32000),
        };

        public Ticket()
        {
            InitializeComponent();
        }

        public Ticket(Choiceservice parent)
        {
            InitializeComponent();
            this.parentForm = parent;
        }

        private void Ticket_Load(object sender, EventArgs e)
        {
            txtPhone.Focus();
            CreateKeypad();
        }

        // ─── 키패드 버튼 동적 생성 ───
        private void CreateKeypad()
        {
            string[] keyLabels = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "삭제", "0", "초기화" };
            int btnW = 126, btnH = 56, gap = 8;
            for (int i = 0; i < 12; i++)
            {
                Button btn = new Button();
                int row = i / 3;
                int col = i % 3;
                btn.Location = new Point(col * (btnW + gap), row * (btnH + gap));
                btn.Size = new Size(btnW, btnH);
                btn.Text = keyLabels[i];
                btn.Font = new Font("맑은 고딕", 14F, FontStyle.Bold, GraphicsUnit.Point);
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderColor = Color.LightGray;
                btn.Name = "btnKey_" + keyLabels[i];
                btn.Tag = keyLabels[i];

                if (keyLabels[i] == "삭제")
                {
                    btn.BackColor = Color.Salmon;
                    btn.ForeColor = Color.White;
                }
                else if (keyLabels[i] == "초기화")
                {
                    btn.BackColor = Color.Gray;
                    btn.ForeColor = Color.White;
                }
                else
                {
                    btn.BackColor = Color.White;
                    btn.ForeColor = Color.Black;
                }

                btn.Click += btnKeypad_Click;
                panelKeypad.Controls.Add(btn);
            }
        }

        // ─── 키패드 버튼 클릭 ───
        private void btnKeypad_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string key = btn.Tag.ToString();

            if (key == "삭제")
            {
                // 마지막 문자 삭제 (하이픈 포함)
                if (txtPhone.Text.Length > 0)
                {
                    txtPhone.Text = txtPhone.Text.Substring(0, txtPhone.Text.Length - 1);
                    // 하이픈이 마지막이면 한 번 더 삭제
                    if (txtPhone.Text.EndsWith("-"))
                        txtPhone.Text = txtPhone.Text.Substring(0, txtPhone.Text.Length - 1);
                }
            }
            else if (key == "초기화")
            {
                txtPhone.Text = "";
                lblMessage.Text = "";
                panelResult.Visible = false;
                panelKeypad.Visible = true;
            }
            else
            {
                // 숫자 입력 + 자동 하이픈
                string digits = txtPhone.Text.Replace("-", "") + key;

                if (digits.Length <= 11)
                {
                    txtPhone.Text = FormatPhoneNumber(digits);
                }
            }
        }

        // ─── 전화번호 자동 포맷 (010-1234-5678) ───
        private string FormatPhoneNumber(string digits)
        {
            if (digits.Length <= 3)
                return digits;
            else if (digits.Length <= 7)
                return digits.Substring(0, 3) + "-" + digits.Substring(3);
            else
                return digits.Substring(0, 3) + "-" + digits.Substring(3, 4) + "-" + digits.Substring(7);
        }

        // ─── 키보드 입력 시 숫자만 허용 ───
        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
            }

            // Enter 키로 조회
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnSearch_Click(sender, e);
                e.Handled = true;
            }
        }

        // ─── 조회 버튼 클릭 ───
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string phone = txtPhone.Text.Trim();

            if (string.IsNullOrEmpty(phone) || phone.Replace("-", "").Length < 10)
            {
                lblMessage.Text = "올바른 핸드폰 번호를 입력해주세요.";
                lblMessage.ForeColor = Color.Red;
                return;
            }

            // 전화번호로 예매 내역 검색
            var results = sampleReservations
                .Where(r => r.Phone == phone)
                .ToList();

            if (results.Count == 0)
            {
                lblMessage.Text = "해당 번호로 예매된 내역이 없습니다.";
                lblMessage.ForeColor = Color.Red;
                panelResult.Visible = false;
                return;
            }

            // 예매 내역을 DataGridView에 표시
            lblMessage.Text = $"총 {results.Count}건의 예매 내역이 있습니다.";
            lblMessage.ForeColor = Color.Green;

            DataTable dt = new DataTable();
            dt.Columns.Add("예약번호", typeof(string));
            dt.Columns.Add("노선", typeof(string));
            dt.Columns.Add("날짜", typeof(string));
            dt.Columns.Add("시간", typeof(string));
            dt.Columns.Add("좌석", typeof(string));
            dt.Columns.Add("등급", typeof(string));
            dt.Columns.Add("금액", typeof(string));

            foreach (var r in results)
            {
                dt.Rows.Add(r.ReservationId, r.Route, r.Date, r.Time, r.Seat, r.Grade, r.Price.ToString("N0") + "원");
            }

            dgvReservations.DataSource = dt;
            panelKeypad.Visible = false;
            panelResult.Visible = true;
        }

        // ─── 발권 버튼 클릭 ───
        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dgvReservations.SelectedRows.Count == 0)
            {
                MessageBox.Show("발권할 예매 내역을 선택해주세요.", "안내",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string reservationId = dgvReservations.SelectedRows[0].Cells["예약번호"].Value.ToString();
            string route = dgvReservations.SelectedRows[0].Cells["노선"].Value.ToString();
            string date = dgvReservations.SelectedRows[0].Cells["날짜"].Value.ToString();
            string time = dgvReservations.SelectedRows[0].Cells["시간"].Value.ToString();
            string seat = dgvReservations.SelectedRows[0].Cells["좌석"].Value.ToString();

            DialogResult result = MessageBox.Show(
                $"아래 승차권을 발권하시겠습니까?\n\n" +
                $"예약번호: {reservationId}\n" +
                $"노선: {route}\n" +
                $"날짜: {date}\n" +
                $"시간: {time}\n" +
                $"좌석: {seat}",
                "발권 확인",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("승차권이 발권되었습니다.\n인쇄 중입니다...", "발권 완료",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 발권 후 해당 예매 삭제 (실제로는 DB 상태 변경)
                sampleReservations.RemoveAll(r => r.ReservationId == reservationId);
                btnSearch_Click(sender, e); // 목록 새로고침
            }
        }

        // ─── 뒤로가기 ───
        private void btnBack_Click(object sender, EventArgs e)
        {
            if (panelResult.Visible)
            {
                // 결과 화면에서 → 번호 입력 화면으로
                panelResult.Visible = false;
                panelKeypad.Visible = true;
                lblMessage.Text = "";
            }
            else
            {
                Close();
            }
        }

        // ─── 처음으로 ───
        private void btnHome_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

    // ─── 예매 정보 클래스 ───
    public class ReservationInfo
    {
        public string Phone { get; set; }
        public string ReservationId { get; set; }
        public string Route { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string Seat { get; set; }
        public string Grade { get; set; }
        public int Price { get; set; }

        public ReservationInfo(string phone, string resId, string route, string date, string time, string seat, string grade, int price)
        {
            Phone = phone;
            ReservationId = resId;
            Route = route;
            Date = date;
            Time = time;
            Seat = seat;
            Grade = grade;
            Price = price;
        }
    }
}