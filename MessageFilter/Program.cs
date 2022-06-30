using System;
using System.Windows.Forms;

namespace MessageFilter
{
    class MessageFilter : IMessageFilter
    {
        public bool PreFilterMessage(ref Message m)
        {
            if (m.Msg == 0x0F || m.Msg == 0xA0 ||
                m.Msg == 0x200 || m.Msg == 0x113) //마우스 움직임 걸러냄
                return false;

            Console.WriteLine($"{m.ToString()} : {m.Msg}");

            if ( m.Msg == 0x201)
                Application.Exit();

            return true;
        }
    }

    class MainApp : Form
    {
        static void Main(string[] args)
        {
            Application.AddMessageFilter(new MessageFilter());
            Application.Run(new MainApp());
        }
    }
}