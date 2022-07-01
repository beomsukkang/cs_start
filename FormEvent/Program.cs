using System;
using System.Windows.Forms;

namespace FormEvent
{
    class MainApp : Form
    {
        public void MyMouseHandler(object sender, MouseEventArgs e)
        {
            Console.WriteLine($"Sender : {((Form)sender).Text}");
            Console.WriteLine($"X:{e.X}:{e.Y}"); //마우스 이벤트가 발생한 좌표
            Console.WriteLine($"Button:{e.Button}, Clicks:{e.Clicks}"); //어떤버튼에서 이벤트가 발생했는지, 몇번 클릭했는지
            Console.WriteLine();
        }

        public MainApp(string title)
        {
            this.Text = title;
            this.MouseDown +=
                new MouseEventHandler(MyMouseHandler);
        }

        static void Main(string[] args)
        {
            Application.Run(new MainApp("Mouse Event Test"));
        }
    }
}