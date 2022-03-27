using System;

namespace UsingVar
{
    class MainApp
    {
        static void Main(string[] args)
        {
            var a = 20;
            Console.WriteLine("Type: {0}, Value: {1}", a.GetType(), a);

            var b = 3.14142313;
            Console.WriteLine("Type: {0}, Value: {1}", b.GetType(), b);

            var c = "Hello, World!";
            Console.WriteLine("Type: {0}, Value: {1}", c.GetType(), c);

            var d = new int[] {10,20,30};
            Console.Write("Type: {0}, Value", d.GetType());

            foreach (var e in d) // foreach = in 뒤에 있는 것을 하나씩 빼서 실행해준다.
                //Console.Write("{0}", e);
                Console.Write($"{e}"); // $ : ""안에 변수를 넣을 수 있게 해준다.

            Console.WriteLine();
        }
    }
}
