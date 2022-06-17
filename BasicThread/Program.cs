using System;
using System.Threading;

namespace BasicThread
{
    class MainApp
    {
        static void DoSomething() //스레드가 실행할 메소드
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"DoSomething : {i}");
                Thread.Sleep(10); // Sleep()메소드를 만나면 인수(10)만큼 CPU 사용을 멈춘다. (인수 단위는 밀리초)
            }
        }

        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(DoSomething)); // Thread의 인스턴스 생성

            Console.WriteLine("Starting thread...");
            t1.Start(); //스레드 시작

            for(int i = 0;i < 5;i++) // t1 스레드의 DoSomething() 메소드가 실행되는 동시에 메인 스레드의 이 반복문도 실행된다.
            {
                Console.WriteLine($"Main : {i}");
                Thread.Sleep(10);
            }

            Console.WriteLine("Waiting until thread stops...");
            t1.Join(); //스레드 종료 대기

            Console.WriteLine("Finished");
        }
    }
}