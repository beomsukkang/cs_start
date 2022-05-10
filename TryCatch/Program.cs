using System;

namespace TryCatch
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };

            try
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(arr[i]); //i가 3이되면 IndexOutOfRangeException 객체가 던져지고 18행의 catch 블록이 이를 받아낸다.
                }
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine($"예외가 발생했습니다 : {e.Message}");
            }

            Console.WriteLine("종료");
        }
    }
}