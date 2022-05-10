using System;

namespace KillingProgram
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(arr[i]); //i가 배열의 크기-1을 넘어서면 예외를 일으키고 종료된다. 이후 코드는 실행되지 않는다.
            }
            Console.WriteLine("종료"); //13행에서 예외가 발생하기에 실행되지 않는다.
        }
    }
}