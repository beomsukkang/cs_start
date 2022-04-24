using System;

// 레코드의 상태를 비교하는 Equals()
namespace RecordComp
{
    class CTransaction //Equals()를 명시적으로 구현
    {
        public string From { get; init; }
        public string To { get; init; }
        public int Amount { get; init; }

        public override string ToString() //어떤 객체든 Tostring을 사용하면 객체(field)의 속성값을 알 수 있다.
        {
            return $"{From,-10} -> {To,-10} :${Amount}";
        }
    }

    record RTransaction //Equals를 구현하지 않았지만 같은 상태를 지닌 인스턴스 두개를 비교하면 참(TRUE)이 반환된다.
    {
        public string From { get; init; }
        public string To { get; init; }
        public int Amount { get; init; }

        public override string ToString()
        {
            return $"{From,-10} -> {To,-10} :${Amount}";
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            CTransaction trA = new CTransaction { From = "Alice", To = "Bob", Amount = 100 };
            CTransaction trB = new CTransaction { From = "Alice", To = "Bob", Amount = 100 };


            Console.WriteLine(trA);
            Console.WriteLine(trB);
            Console.WriteLine($"trA equals to trB : {trA.Equals(trB)}");

            RTransaction tr1 = new RTransaction { From = "Alice", To = "Bob", Amount = 100 };
            RTransaction tr2 = new RTransaction { From = "Alice", To = "Bob", Amount = 100 };

            Console.WriteLine(tr1);
            Console.WriteLine(tr2);
            Console.WriteLine($"tr1 equals to tr2 : {tr1.Equals(tr2)}");
        }
    }
}