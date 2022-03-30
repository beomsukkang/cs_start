using System;

namespace Switch
{
    class MainApp
    {
        static void Main(string[] args)
        {
            object obj = null;

            string s = Console.ReadLine();
            bool k = int.TryParse(s, out int j); //s가 int형이 아닐 시 j= 0으로 출력
            Console.WriteLine(k); 
            Console.WriteLine(j);   


            if (int.TryParse(s, out int out_i))
                obj = out_i;
            else if (float.TryParse(s, out float out_f))
                obj = out_f;
            else
                obj = s;

            switch (obj)
            {
                case int i:
                    Console.WriteLine($"{i}는 int 형식입니다.");
                    break;
                case float f:
                    Console.WriteLine($"{f}는 float 형식입니다.");
                    break;
                default:
                    Console.Write($"{obj}는 모르는 형식입니다.");
                   
                    break;
            }

        }

    }
}