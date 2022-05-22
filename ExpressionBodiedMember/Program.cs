using System;
using System.Collections.Generic;

namespace ExpressionBodiedMember
{
    class FriendList
    {
        private List<string> list = new List<string>();

        public void Add(string name) => list.Add(name);
        public void Remove(string name) => list.Remove(name);
        public void PrintAll()
        {
            foreach (var s in list)
                Console.WriteLine(s);
        }

        public FriendList() => Console.WriteLine("Friend List()"); //생성자
        ~FriendList() => Console.WriteLine("~Friend List()"); //종료자, 언제종료되는지 알수 없어 출력x

        // public int Capacity => list.Capacity; //읽기 전용

        public int Capacity //속성, 읽고쓰기 다됨
        {
            get => list.Capacity;
            set => list.Capacity = value;
        }

        // public string this[int index] => list.[index]; //읽기 전용
        public string this[int index] //인덱서, 읽고쓰기 다됨
        {
            get => list[index];
            set => list[index] = value;
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            FriendList obj = new FriendList();
            obj.Add("Eney");
            obj.Add("Meeny");
            obj.Add("Miny");
            obj.Remove("Eney");
            obj.PrintAll();

            Console.WriteLine($"{obj.Capacity}");
            obj.Capacity = 10;
            Console.WriteLine($"{obj.Capacity}");

            Console.WriteLine($"{obj[0]}");
            obj[0] = "Moe";
            obj.PrintAll();
        }
    }
}