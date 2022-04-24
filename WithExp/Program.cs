using System;
/*
 * C#컴파일러는 레코드 형식을 위한 복사 생성자를 자동으로 작성한다.
 * 하지만 protected로 선언되기에 with식을 이용해 호출할 수 있다.
 */
namespace WithExp
{
    record RTransaction
    {
        public string From {  get; init; }
        public string To { get; init; }
        public int Amount { get; init; }

        public override string ToString()
        {
            return $"{From,-10} -> {To,-10} : ${Amount}";
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            RTransaction tr1 = new RTransaction { From = "Alice", To = "Bob", Amount = 100 }; //alice to bob
            RTransaction tr2 = tr1 with { To = "Charlie" }; //alice to charlie
            RTransaction tr3 = tr2 with { From = "Dave", Amount = 30 }; //dave to charlie

            Console.WriteLine(tr1);
            Console.WriteLine(tr2);
            Console.WriteLine(tr3);
        }
    }
}