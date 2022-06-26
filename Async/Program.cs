using System;
using System.Threading.Tasks;

namespace Async
{
    class MainApp
    {
        async static private void MyMethodAsync(int count)
        {
            Console.WriteLine("C");
            Console.WriteLine("D");

            await Task.Run(async () =>
            {
                for (int i = 1; i <= count; i++)
                {
                    Console.WriteLine($"{i}/{count} ...");
                    await Task.Delay(100);  // Task.Delay()는 Thread.Sleep()의 비동기 버전.
                }
            });

            Console.WriteLine("G");
            Console.WriteLine("H");
        }

        static void Caller()
        {
            Console.WriteLine("A");
            Console.WriteLine("B");

            MyMethodAsync(3);

            Console.WriteLine("E");
            Console.WriteLine("F");
        }

        static void Main(string[] args)
        {
            Caller();
            
            Console.ReadLine(); //프로그램 종료 방지
        }
    }
    
}
/*결과
A
B
C
D
E
F
1/3 ...
2/3 ...
3/3 ...
G
H
*/