using System;
using System.Linq;

namespace From
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int[] numbers = { 9, 2, 6, 4, 5, 3, 7, 8, 1, 10 };

            var result = from n in numbers //numbers 안에 있는 각 데이터로부터
                         where n % 2 == 0 // n % 2가 0인 객체들만 골라
                         orderby n // 순서대로 정리하여
                         select n; // n객체를 추출한다

            foreach (int n in result)
                Console.WriteLine($"짝수 : {n}");

        }
    }
}