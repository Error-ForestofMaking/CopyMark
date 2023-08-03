using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CopyMark
{
    public partial class main : Form
    {
        //변수
        private Point mCurrentPosition = new Point(0, 0);

        public main()
        {
            InitializeComponent();
        }

        static bool IsPrime(int number)
        {
            if (number <= 1)
                return false;
            if (number <= 3)
                return true;

            // 2 또는 3으로 나누어 떨어지면 소수가 아님
            if (number % 2 == 0 || number % 3 == 0)
                return false;

            int sqrt = (int)Math.Sqrt(number);
            // 6k ± 1 꼴의 수 중에서만 소수 여부를 확인
            for (int i = 5; i <= sqrt; i += 6)
            {
                if (number % i == 0 || number % (i + 2) == 0)
                    return false;
            }

            return true;
        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private async void start_bt_ClickAsync(object sender, EventArgs e)
        {
            start_bt.Visible = false;
            progressBar1.Value = 0;

            int iterations = 5000000; // 작업 반복 횟수
            int numberToCheck = 104729; // 소수 예시 (104729는 알려진 큰 소수)

            int completed = 0;

            // 시작 시간 기록
            long startTimeSeconds = DateTimeOffset.Now.ToUnixTimeSeconds();

            // 작업 반복 (104729가 소수인지 10000번 계산)
            await Task.Run(() =>
            {
                for (int i = 0; i < iterations; i++)
                {
                    bool isPrime = IsPrime(numberToCheck);

                    completed = i + 1; // 작업 완료 비율 설정

                    // UI 업데이트 요청
                    UpdateUI_completed(completed / 50000);
                }
            });

            // 종료 시간 기록
            long endTimeSeconds = DateTimeOffset.Now.ToUnixTimeSeconds();

            // 걸린 시간 계산
            long elapsedTimeSeconds = endTimeSeconds - startTimeSeconds;

            // 점수 계산 및 UI 업데이트 요청
            score_label.Text = (10000 - elapsedTimeSeconds).ToString() + "점";
            time_label.Text = elapsedTimeSeconds.ToString() + "초 소요";

            //UpdateUI_score(score);

            // 테스트 완료 메시지 표시
            //MessageBox.Show("테스트 완료");

            start_bt.Visible = true;
        }

        void UpdateUI_completed(int value)
        {
            // UI 업데이트 요청
            score_label.Invoke((Action)(() =>
            {
                score_label.Text = value.ToString() + "%";
                progressBar1.Value = value;
            }));
        }

        private void menubar_panel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                mCurrentPosition = new Point(-e.X, -e.Y);
        }

        private void menubar_panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(
                this.Location.X + (mCurrentPosition.X + e.X),
                this.Location.Y + (mCurrentPosition.Y + e.Y));
            }
        }

        private void close_bt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
