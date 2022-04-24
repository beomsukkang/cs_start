using System;

/*
 * 형식에 이름이 필요한 이유: 그 형식의 이름을 이용해서 인스턴스를 만들기때문.
 * 무명 형식은 선언과 동시에 인스턴스를 할당-> 인스턴스를 만들고 다시는 사용하지 않을 때 유용하게 사용가능.
 * 무명 형식의 인스턴스는 만들어지고 난 다음엔 읽기만 가능(변경불가능)
 */
namespace AnnoymousType
{
    class MainApp
    {
        static void Main(string[] args)
        {
            var a = new { Name = "박상현", Age = 123 }; //괄호사이에 임의의 프로퍼티 이름을 적고 값을 할당하면 그대로 새 형식의 프로퍼티가 됨.
            Console.WriteLine($"Name : {a.Name}, Age = {a.Age}");

            var b = new { Subject = "수학", Scores = new int[] { 90, 80, 70, 60 } };

            Console.Write($"Subject : {b.Subject}, Scores = ");
            foreach (var score in b.Scores)
                Console.Write($"{score}");

            Console.WriteLine();
        }
    }
}