using System;



namespace Record
{
    record RTransaction //record 키워드와 전용프로퍼티를 사용, 초기화 전용 자동구현 프로퍼티 뿐만 아니라 쓰기 가능한 프로퍼티와 필드도 자유롭게 선언가능.
    {
        public string From { get; set; }
        public string To { get; set; }

        public int Amount { get; set; }

        public override string ToString()
        {
            return $"{From,-10} -> {To,-10} : ${Amount}"; // 문법이해안가요
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            RTransaction tr1 = new RTransaction { From = "Alice", To = "Bob", Amount = 100 };
            RTransaction tr2 = new RTransaction { From = "Alice", To = "Charlie", Amount = 100 };
            

            Console.WriteLine(tr1);
            Console.WriteLine(tr2);
        }
    }
}