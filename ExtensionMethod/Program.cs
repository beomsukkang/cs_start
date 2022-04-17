using System;
using MyExtension; //확장메소드를 담는 클래스의 네임스페이스 사용

namespace MyExtension
{
    public static class IntegerExtension
    {
        public static int Square(this int myInt)
        { return myInt * myInt; }

        public static int Power(this int myInt, int exponent) //this. 대상 형식식별자 (확장하고자 하는 클래스 또는 형식
        {
            int result = myInt;
            for (int i = 1; i < exponent; i++)
                result = result * myInt;

            return result;
        }
    }
}

namespace ExtensionMethod
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"3^2:{3.Square()}");
            Console.WriteLine($"3^4:{3.Power(4)}"); //Power가 int 형식의 메소드였던것처럼 사용가능
            Console.WriteLine($"2^10:{2.Power(10)}");
        }
    }
}
