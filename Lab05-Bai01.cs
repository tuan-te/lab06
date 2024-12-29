using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Lab6_Nhóm5_23521757
{
    public partial class Lab05_Bai01 : Form
    {
        private Random random = new Random();
        private int timeLeft;
        private int sum1, sum2, diff1, diff2, prod1, prod2, div1, div2;
        public Lab05_Bai01()
        {
            InitializeComponent();
            pbBai1.Image = Properties.Resources.gif11;
        }
        private void GenerateQuiz()
        {
            sum1 = random.Next(10, 50);
            sum2 = random.Next(10, 50);
            diff1 = random.Next(50, 100);
            diff2 = random.Next(10, 50);
            prod1 = random.Next(1, 10);
            prod2 = random.Next(1, 10);
            div2 = random.Next(1, 10);
            div1 = div2 * random.Next(1, 10);
            lblSum.Text = $"{sum1} + {sum2} = ";
            lblDiff.Text = $"{diff1} - {diff2} = ";
            lblProd.Text = $"{prod1} x {prod2} = ";
            lblDiv.Text = $"{div1} ÷ {div2} = ";
            numSum.Value = 0;
            numDiff.Value = 0;
            numProd.Value = 0;
            numDiv.Value = 0;
            timeLeft = 20;
            lblTimeLeft.Text = $"{timeLeft} seconds";
        }
        private void StartTimer()
        {
            Thread timerThread = new Thread(() =>
            {
                while (timeLeft > 0)
                {
                    Thread.Sleep(1000);
                    timeLeft--;
                    Invoke(new Action(() =>
                    {
                        lblTimeLeft.Text = $"{timeLeft} seconds";
                        if (timeLeft == 0)
                        {
                            CheckAnswers();
                        }
                    }));
                }
            });
            timerThread.IsBackground = true;
            timerThread.Start();
        }
        private void CheckAnswers()
        {
            bool isCorrect = true;
            if (numSum.Value != sum1 + sum2)
                isCorrect = false;
            if (numDiff.Value != diff1 - diff2)
                isCorrect = false;
            if (numProd.Value != prod1 * prod2)
                isCorrect = false;
            if (numDiv.Value != div1 / div2)
                isCorrect = false;
            if (isCorrect)
            {
                MessageBox.Show("Chúc mừng! Bạn đã trả lời đúng tất cả các câu hỏi.", "Thành công");
            }
            else if (timeLeft == 0)
            {
                MessageBox.Show("Hết giờ! Hãy thử lại.", "Hết giờ");
            }
        }

        private void btnStart_Click_1(object sender, EventArgs e)
        {
            GenerateQuiz();
            StartTimer();
        }
    }
}
