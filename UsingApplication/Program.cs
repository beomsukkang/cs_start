using System;
using System.Windows.Forms;

namespace UsingApplication
{
    class MainApp : Form
    {
        static void Main(string[] args)
        {
            MainApp form = new MainApp();

            form.Click += new EventHandler( //Click 이벤트는 윈도우를 클릭했을 때 발생하는 이벤트이다. 윈도우를 클릭하면 Application.Exit()를 호출한다. 
                (sender, eventArgs) =>
                {
                    Console.WriteLine("Closing Window...");
                    Application.Exit();
                });

            Console.WriteLine("Starting window Application...");
            Application.Run(form);

            Console.WriteLine("Exiting Window Application...");
        }
    }
}