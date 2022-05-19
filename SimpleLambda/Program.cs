using System;

namespace SimpleLambda
{
    class MainApp
    {
        delegate int Calculate(int a, int b); //익명메소드를 만들기 위해 대리자 선언

        static void Main(string[] args)
        {
            Calculate calc = (a, b) => a + b; // C#컴파일러는 Calculator 대리자의 선언코드로부터 이 람다식이 만드는 익명 메소드의 매개변수를 유추해낸다.

            Console.WriteLine($"{3}+{4} : {calc(3, 4)}");
        }
    }
}