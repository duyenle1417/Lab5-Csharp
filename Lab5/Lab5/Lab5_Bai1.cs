using System;
using System.Windows.Forms;

namespace Lab5
{
    public partial class MathGame : Form
    {
        public MathGame()
        {
            InitializeComponent();
        }

        //bool ArePlaying = false;
        private System.Timers.Timer timer;

        //thoi gian choi mac dinh
        private int second = 30;

        // cac bien quiz va result
        private int a, b;

        private int sum, sub, mul, divine;

        //diem
        private int point = 0;

        //tao so random
        private Random rand = new Random();

        private int QuestionSet = 5;//5*4=20 cau hoi

        private void btn_Start_Click(object sender, EventArgs e)
        {
            //khoi dong cac nut va tat cac nut
            GiaoDienGame();
            //chay quiz
            QuizGenerator();
            //bat dau dong ho
            StartTimer();
            //
            QuestionSet--;
            labelQuestion.Text += " " + (5 - QuestionSet).ToString();
        }

        //hoan thanh bai thi
        //choi tiep an nut Continue
        private void btn_Submit_Click(object sender, EventArgs e)
        {
            //tat timer
            timer.Dispose();
            //kiem tra ket qua
            CheckResult();
            NoWrite();//khong viet ket qua duoc
            btn_Submit.Enabled = false;
            ViewResult();
        }

        //Tiep tuc choi, add vao diem co san
        private void btn_Continue_Click(object sender, EventArgs e)
        {
            if (QuestionSet == 0)
            {
                timer.Dispose();
                GiaoDienManHinh();
            }
            else
            {
                QuestionSet--;
                labelQuestion.Text = labelQuestion.Text.Substring(0, labelQuestion.Text.Length - 2)
                                    + " " + (5 - QuestionSet).ToString();
                QuizGenerator();
                StartTimer();
                btn_Submit.Enabled = true;
                btn_Continue.Enabled = false;
            }
        }

        //dong form
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        //thoat tro choi
        //muon choi an nut Start = choi lai tu dau
        private void btn_Quit_Click(object sender, EventArgs e)
        {
            //thoi gian ngung dem nguoc
            timer.Dispose();
            NoWrite();
            //hoi nguoi choi co muon thoat
            DialogResult res = MessageBox.Show("Bạn có muốn thoát trò chơi?\r\nĐiểm của bạn sẽ bị xóa!", "Warning",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                point = 0;
                labelPoint.Text = point.ToString();
                GiaoDienManHinh();
            }
            else
            {
                if (btn_Submit.Enabled != false)//chua an Submit = dang doi nut Continue
                {
                    QuestionSet++;
                }
                //bat nut quay lai tro choi
                btn_Continue.Enabled = true;
                btn_Submit.Enabled = false;
                btn_Continue.Text = btn_Continue.Text.Substring(0, 8);
            }
        }

        //sau khi an Quit quay ve man hinh
        private void GiaoDienManHinh()
        {
            btn_Start.Visible = true;
            btn_Exit.Visible = true;
            btn_Submit.Visible = false;
            btn_Continue.Visible = false;
            btn_Quit.Visible = false;
            groupBoxTimer.Visible = false;
            point = 0;
            QuestionSet = 5;
            labelQuestion.Text = labelQuestion.Text.Substring(0, labelQuestion.Text.Length - 2);
            //sua cac label
            lb_Add1.Text = "A";
            lb_Sub1.Text = "A";
            lb_Mult1.Text = "A";
            lb_Div1.Text = "A";
            lb_Add2.Text = "B";
            lb_Sub2.Text = "B";
            lb_Mult2.Text = "B";
            lb_Div2.Text = "B";
            ClearCheck();
            ClearAnswer();
        }

        //sau khi an nut Start hien giao dien game
        private void GiaoDienGame()
        {
            btn_Start.Visible = false;
            btn_Exit.Visible = false;
            btn_Submit.Visible = true;
            btn_Continue.Visible = true;
            btn_Quit.Visible = true;
            groupBoxTimer.Visible = true;
            btn_Continue.Enabled = false;
            btn_Submit.Enabled = true;
        }

        //tao cac tham so ngau nhien
        //khi an Start va Continue
        private void QuizGenerator()
        {
            InGame();
            ClearCheck();
            ClearAnswer();
            //cong
            a = rand.Next(0, 100);
            b = rand.Next(0, 100);
            lb_Add1.Text = a.ToString();
            lb_Add2.Text = b.ToString();
            sum = a + b;
            //tru
            a = rand.Next(0, 100);
            b = rand.Next(0, 100);
            lb_Sub1.Text = a.ToString();
            lb_Sub2.Text = b.ToString();
            sub = a - b;
            //nhan
            a = rand.Next(0, 20);
            b = rand.Next(0, 20);
            lb_Mult1.Text = a.ToString();
            lb_Mult2.Text = b.ToString();
            mul = a * b;
            //chia
            b = rand.Next(1, 20);
            a = rand.Next(0, 50);
            divine = a;
            a *= b;
            lb_Div1.Text = a.ToString();
            lb_Div2.Text = b.ToString();
        }

        //Timer bat dau chay
        private void StartTimer()
        {
            second = 30;
            timer = new System.Timers.Timer();
            timer.Interval = 1000;//1 giay
            timer.Start();//bat dau dong ho
            lbTimer.Text = second.ToString();
            timer.Elapsed += Timer_Elapsed;//Timer xu ly (sau 1s)
        }

        //Dem nguoc
        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                second--;
                lbTimer.Text = second.ToString();
                //neu het thoi gian se game over
                if (second == 0)
                {
                    timer.Dispose();
                    btn_Submit.PerformClick();
                }
            }));
        }

        //thoi gian xem ket qua
        //sau khi an nut Submit
        private void ViewResult()
        {
            second = 3;
            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Start();
            btn_Continue.Text = btn_Continue.Text + "(" + second.ToString() + ")";
            timer.Elapsed += Timer_Elapsed1;
        }

        private void Timer_Elapsed1(object sender, System.Timers.ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                second--;
                btn_Continue.Text = btn_Continue.Text.Substring(0, 8) + "(" + second.ToString() + ")";
                if (second == 0)
                {
                    timer.Dispose();
                    btn_Continue.Text = btn_Continue.Text.Substring(0, 8);
                    btn_Continue.Enabled = true;
                }
            }));
        }

        //ghi ket qua duoc
        //khi an goi ham QuizGenerator
        private void InGame()
        {
            textBoxAdd.Enabled = true;
            textBoxSub.Enabled = true;
            textBoxMult.Enabled = true;
            textBoxDiv.Enabled = true;
        }

        //Xoa dau check
        //khi an Quit hoac goi ham QuizGenerator
        private void ClearCheck()
        {
            labelAns1.Text = "";
            labelAns2.Text = "";
            labelAns3.Text = "";
            labelAns4.Text = "";
        }

        //xoa ket qua
        //khi an Quit hoac goi ham QuizGenerator
        private void ClearAnswer()
        {
            textBoxAdd.Clear();
            textBoxSub.Clear();
            textBoxMult.Clear();
            textBoxDiv.Clear();
        }

        //khong duoc ghi ket qua
        //sau khi an nut Submit hoac Quit
        private void NoWrite()
        {
            textBoxAdd.Enabled = false;
            textBoxSub.Enabled = false;
            textBoxMult.Enabled = false;
            textBoxDiv.Enabled = false;
        }

        //kiem tra ket qua, in ra ket qua dung va tinh diem
        //.khi an Submit
        private void CheckResult()
        {
            int ans;
            int correct = 0;
            try
            {
                ans = int.Parse(textBoxAdd.Text);
                if (ans == sum)
                {
                    //dung
                    point += 5;
                    labelAns1.Text = "✓";
                    correct++;
                }
                else
                {
                    //sai
                    labelAns1.Text = sum.ToString();
                }
            }
            catch
            {
                //chua dien dap an hay dien chua vao khung
                textBoxAdd.Text = "#N/A";
                labelAns1.Text = sum.ToString();
            }

            try
            {
                ans = int.Parse(textBoxSub.Text);
                if (ans == sub)
                {
                    point += 5;
                    labelAns2.Text = "✓";
                    correct++;
                }
                else
                {
                    labelAns2.Text = sub.ToString();
                }
            }
            catch
            {
                //chua dien dap an hay dien chua vao khung
                textBoxSub.Text = "#N/A";
                labelAns2.Text = sub.ToString();
            }

            try
            {
                ans = int.Parse(textBoxMult.Text);
                if (ans == mul)
                {
                    //tra loi dung
                    point += 5;
                    labelAns3.Text = "✓";
                    correct++;
                }
                else
                {
                    //ghi ket qua dung neu tra loi sai
                    labelAns3.Text = mul.ToString();
                }
            }
            catch
            {
                //chua dien dap an hay dien chua vao khung
                textBoxMult.Text = "#N/A";
                labelAns3.Text = mul.ToString();
            }

            try
            {
                ans = int.Parse(textBoxDiv.Text);
                if (ans == divine)
                {
                    point += 5;
                    labelAns4.Text = "✓";
                    correct++;
                }
                else
                {
                    labelAns4.Text = divine.ToString();
                }
            }
            catch
            {
                //chua dien dap an hay dien chua vao khung
                textBoxDiv.Text = "#N/A";
                labelAns4.Text = divine.ToString();
            }

            //diem bonus thoi gian
            //moi cau dung se cong them 0.75*thoi gian con lai
            point += Bonus(correct);

            //hien diem tren man hinh
            labelPoint.Text = point.ToString();
        }

        private int Bonus(int corr)
        {
            int p = 0;
            int time = int.Parse(lbTimer.Text);
            if (corr > 0)
            {
                if (time > 20)
                {
                    p = (int)(time * 0.75 * corr);
                }
                else if (time > 15)
                {
                    p = (int)(time * 0.5 * corr);
                }
                else if (time > 10)
                {
                    p = (int)(time * 0.25 * corr);
                }
                else
                {
                    p = 0;
                }
            }
            return p;
        }
    }
}