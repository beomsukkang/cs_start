using System;
using System.Windows.Forms;

namespace FormAndControl
{
    class MainApp : Form
    {
        static void Main(string[] args)
        {
            Button button = new Button(); //컨트롤의 인스턴스 생성

            button.Text = "Click me!"; //컨트롤의 프로퍼티에 값 지정
            button.Left = 100;
            button.Top = 50;

            button.Click +=             //컨트롤의 이벤트에 이벤트 처리기 등록
                (object sender, EventArgs e) =>
                {
                    MessageBox.Show("딸깍!");
                };

            MainApp form = new MainApp();   //폼에 컨트롤 추가
            form.Text = "Form & Control";
            form.Height = 150;

            form.Controls.Add(button);

            Application.Run(form);
        }
    }
}