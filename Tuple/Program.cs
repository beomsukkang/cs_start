//튜플은 여러 필드를 담을 수 있는 구조체이지만 형식 이름이 없기에 즉석에서 사용할 복합 데이터 형식을 선언할때 적합하다,
using System;

namespace Tuple
{
    class MainApp
    {
        static void Main(string[] args)
        {
            //명명되지 않은 튜플
            var a = ("슈퍼맨", 9999);
            Console.WriteLine($"{a.Item1},{a.Item2}");

            //명명된 튜플
            var b = (Name: "박상현", Age :  17);
            Console.WriteLine($"{b.Name},{b.Age}");

            //분해
            var (name, age) = b;
            Console.WriteLine($"{name},{age}");

            //분해2
            var (name2, age2) = ("박문수",34);
            Console.WriteLine($"{name2},{age2}");

            //명명된 튜플 = 명명되지 않은 튜플
            b = a;
            Console.WriteLine($"{b.Name},{b.Age}");
        }
    }
}