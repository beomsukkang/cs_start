using System;
using System.Collections.Generic;

/*
 * 인스턴스를 만들때 형식매개변수 필요, 한 컬렉션에 아무 형식의 객체나 집어넣을 수 없음, 입력한 형식 외엔 입력불가.
 */

namespace UsingGenericList
{
    class MainApp
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < 5; i++)
                list.Add(i);

            foreach(int element in list)
                Console.Write($"{element} ");
            Console.WriteLine();

            list.RemoveAt(2);

            foreach (int element in list)
                Console.Write($"{element} ");
            Console.WriteLine();

            list.Insert(2, 2);

            foreach (int element in list)
                Console.Write($"{element} ");
            Console.WriteLine();

        }
    }
}