using System;

namespace StackTrace
{
    class MainApp
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 1;
                Console.WriteLine(3 / --a);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.StackTrace); //문제가 발생한 부분의 소스코드를 알려준다.
            }
        }
    }
}