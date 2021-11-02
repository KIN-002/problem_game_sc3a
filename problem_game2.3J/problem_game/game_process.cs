using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace problem_game
{
	public partial class game_process : Form
	{
        public int qn = 1;
        public int mk = 0;
        public Form controlform;  //通往失敗的變數
		int timeLeft = 900;//計時變數
		Random randomizer = new Random();//計時變數
       
            public void buttonrand() {
                
                Random r = new Random();
                int[] h = new int[3] { 0, 220, 150 };
                int[] w = new int[3] { 0, 30, 220 };
                int b1h = 0, b1w = 0, b2h = 0, b2w = 0, b3h = 0, b3w = 0, b4h = 0, b4w = 0;
                do
                {
                    b1h = h[r.Next(1, 3)];
                    b1w = w[r.Next(1, 3)];
                    b2h = h[r.Next(1, 3)];
                    b2w = w[r.Next(1, 3)];
                    b3h = h[r.Next(1, 3)];
                    b3w = w[r.Next(1, 3)];
                    b4h = h[r.Next(1, 3)];
                    b4w = w[r.Next(1, 3)];
                } while (b1h + b1w == b2h + b2w || b1h + b1w == b3h + b3w || b2h + b2w == b3h + b3w || b1w + b1h == b4h + b4w || b2w + b2h == b4w + b4h || b3w + b3h == b4h + b4w);

                button1.Location = new Point(b1w, b1h);
                button2.Location = new Point(b2w, b2h);
                button3.Location = new Point(b3w, b3h);
                button4.Location = new Point(b4w, b4h);
            qn++;
            Qn.Text = "問題" + qn + "：";
            if (qn == 31) {
                controlform = new game_win();
                controlform.Show();
                this.Close();
            }
        }  //點擊按鈕隨機位置
        public void clickflase() {                      
            int lf = Convert.ToInt32(life.Text);
            lf--;
            if (lf == 0)
            {                                                   //生命歸零時跳轉至lose
                controlform = new game_lose();
                controlform.Show();
                this.Close();
            }
            life.Text = Convert.ToString(lf);
        } //點擊錯誤答案時扣血



        public game_process()
		{
			InitializeComponent();
			string[] topic = new string[50];
			string[] ans1= new string[50];
			string[] ans2 = new string[50];
			string[] ans3 = new string[50];
			string[] ans4 = new string[50];
            
        }
		
		private void timer1_Tick(object sender, EventArgs e)
		{

            if (timeLeft > 0)//判斷timeLeft變數是否大於0
            {
                timeLeft = timeLeft - 1;
                timelabel.Text = timeLeft + "秒";
            }
            else//當timeLeft = 0時
            {
                controlform = new game_lose();
                controlform.Show();
                this.Close();

            }
        }//計時用程式

        private void button1_Click(object sender, EventArgs e)
		{
            buttonrand();
            mk += 10;
            mark.Text = Convert.ToString(mk);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            buttonrand();
            clickflase();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            buttonrand();
            clickflase();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            buttonrand()