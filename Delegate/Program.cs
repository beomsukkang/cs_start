using System;
/*
 * 대리자는 메소드에 대한 참조이다. 대리자에 메소드 주소를 할당한 뒤 대리자를 호출하면 대리자가 메소드를 호출해준다.
 * 메소드는 단순히 코드블록이기에 프로세스가 시작되면 코드메모리 영역에 올라간다.
 * 해당 메소드가 호출되면 메소드 내부의 지역벽수는 스택에 생성된다.(내부에 객체가 있다면 힙에 생성)
 * 스택에 변수가 생겨 해당객체의 참조값을 가지고 있게 된다. 대리자는 메소드를 참조로 사용할 수 있게끔 만든다.
 * 대리자는 인스턴스가 아닌 형식(int, string과 같은)이다. 메소드를 참조하는 그 무엇을 만들려면 대리자의 인스턴스를 따로 만들어야 한다.
 */

namespace Delegate
{
    delegate int MyDelegate(int a, int b); //대리자의 선언

    class Calculator
    {
        public int Plus(int a, int b) //대리자는 인스턴스 메소드를 참조할 수도 있다
        {
            return a + b;
        }

        public static int Minus(int a, int b) //정적 메소드를 참조할 수도 있다
        {
            return a - b ;
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Calculator Calc = new Calculator();
            MyDelegate Callback;

            Callback = new MyDelegate(Calc.Plus);
            Console.WriteLine(Callback(3, 4)); //메소드를 호출하듯 대리자를 사용하면, 참조하고 있는 메소드가 실행된다.

            Callback = new MyDelegate(Calculator.Minus);
            Console.WriteLine(Callback(7, 5));
        }
    }
}

