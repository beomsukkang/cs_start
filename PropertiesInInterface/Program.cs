using System;
/*
 * 인터페이스는 메소드뿐만 아니라 프로퍼티와 인덱서도 가질 수 있다.
 * 이 인터페이스를 상속 할 경우 반드시 해당 프로퍼티와 인덱서를 구현해야한다.
 * 인터페이스에 들어가는 프로퍼티는 구현을 갖지 않는다.
 * 인터페이스의 프로퍼티 선언은 클래스의 자동구현 프로퍼티 선언과 그 모습이 동일하다.
 */
namespace PropertiesInInterface
{
    interface INamedValue
    {
        string Name { get; set; } // 인터페이스는 어떤 구현도 가지지 않기에 프로퍼티에 대해서 자동으로 구현해주지 않는다.
        string Value { get; set; }
    }

    class NamedValue : INamedValue //반드시 Name과 Value를 구현해야 한다. 자동 구현 프로퍼티 이용가능.
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            NamedValue name = new NamedValue()
            { Name = "이름", Value = "박상현" };

            NamedValue height = new NamedValue()
            { Name = "키", Value = "177cm" };
            NamedValue weight = new NamedValue()
            { Name = "몸무게", Value = "90kg" };

            Console.WriteLine($"{name.Name} :{name.Value}");
            Console.WriteLine($"{height.Name} :{height.Value}");
            Console.WriteLine($"{weight.Name} :{weight.Value}");
        }
    }

}
