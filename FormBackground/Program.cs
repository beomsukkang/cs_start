using System;
using System.Drawing;
using System.Windows.Forms;

namespace FormBackground
{
    class MainApp : Form
    {
        Random rand;
        public MainApp()
        {
            rand = new Random();

            this.MouseWheel += new MouseEventHandler(MainApp_MouseWheel);
            this.MouseDown += new MouseEventHandler(MainApp_MouseDown);
        }

        void MainApp_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)        //마우스 왼쪽버튼으로 랜덤하게 창의 배경색을 변경한다.
            {
                Color oldColor = this.BackColor;
                this.BackColor = Color.FromArgb(rand.Next(0, 255),
                                                rand.Next(0, 255),
                                                rand.Next(0, 255));
            }
            else if (e.Button == MouseButtons.Right) //마우스 오른쪽버튼으로 배경이미지를 표시한다.
            {
                if (this.BackgroundImage != null)
                {
                    this.BackgroundImage = null;
                    return;
                }

                string file = "Sample.jpg";
                if (System.IO.File.Exists(file) == false)
                    MessageBox.Show("이미지 파일이 없습니다.");
                else
                    this.BackgroundImage = Image.FromFile(file); //BackGround 이미지 지정
            }
        }
        void MainApp_MouseWheel(object sender, MouseEventArgs e) //마우스 휠을 굴리면 투명도가 변경된다.
        {
            this.Opacity = this.Opacity + (e.Delta > 0 ? 0.1 : -0.1); //창의 투명도는 Opacity 프로퍼티로 조정한다. 이 프로퍼티는 0~1의 값을 가진다. 0에 가까울수록 투명하다.
            Console.WriteLine($"Opacity: {this.Opacity}");
        }

        static void Main(string[] args)
        {
            Application.Run(new MainApp());
        }
    }
}