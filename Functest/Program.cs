using System;

namespace FuncTest
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Func<int> func1 = () => 10; //입력매개변수x, 무조건 10반환
            Console.WriteLine($"func1() : {func1()}"); //10 출력

            Func<int, int> func2 = (x) => x*2; //입력매개변수 int형식 한개, 반환형식도 int
            Console.WriteLine($"func2(4) : {func2(4)}"); // 8출력

            Func<double, double, double> func3 = (x,y) => x/y; //입력매개변수 double형식2개, 반환형식도 double형식
            Console.WriteLine($"func3(22,7) : {func3(22,7)}"); // 3.14 출력


        }
    }
}