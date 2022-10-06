using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sample0415 {
    class Program {

        static Form form;
        static PictureBox pb;   //画像表示用
        static Timer timer = new Timer();   //タイマー

        static int xPos, yPos;   //ボールの座標
        static int mX = 10, mY = 10;    //加速度

        static void Main(string[] args)
        {
            //ウィンドウの生成
            form = new Form();
            form.Width = 800;
            form.Height = 600;
            form.BackColor = Color.Green;
            form.MouseClick += Form_MouseClick;

            timer.Tick += Timer_Tick;
            timer.Interval = 5;    //ms

            Application.Run(form);
        }

        private static void Form_MouseClick(object sender, MouseEventArgs e)
        {
            xPos = e.X;
            yPos = e.Y;

            pb = new PictureBox();

            if (e.Button == MouseButtons.Left)
            {
                pb.Image = Image.FromFile(@"picture\soccer_ball.png");  //左クリック
            }
            else
            {
                pb.Image = Image.FromFile(@"picture\tennis_ball.png");  //右クリック
            }

            pb.Size = new Size(50, 50);
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.Location = new Point(xPos, yPos);  //ボールの位置
            pb.Parent = form;   //親の登録

            timer.Start();  //タイマースタート
        }

        //タイマーイベントハンドラ
        private static void Timer_Tick(object sender, EventArgs e)
        {
            xPos += mX;
            yPos += mY;

            Console.WriteLine("x座標：{0}, y座標：{1}", xPos, yPos);  //デバッグ用

            //上下
            if (yPos < 0 || yPos > 500)
            {
                mY = -mY;   //符号の反転
            }

            //左右
            if (xPos < 0 || xPos > 730)
            {
                mX = -mX;
            }

            pb.Location = new Point(xPos, yPos);  //ボールの位置
        }

    }
}
