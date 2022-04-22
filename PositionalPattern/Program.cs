using System;
//client 객체가 switch식의 인수로 주어졌고, switch식은 client를 분해해서 분기를 수행한다. 위치 패턴 매칭.
namespace PositionalPattern
{
    class MainApp
    {
        private static double GetDiscountRate(object client)
        {
            return client switch
            {
                ("학생", int n) when n < 18 => 0.2, //학생&18세미만
                ("학생", _) => 0.1, //학생&18세 이상, _는 매개변수의 위치파악
                ("일반", int n) when n < 18 => 0.1,
                ("일반", _) => 0.05, //일반&18세 이상
                _ => 0,
            };
        }
        static void Main(string[] args)
        {
            var alice    = (job: "학생", age: 17);
            var bob      = (job: "학생", age: 23);
            var charlie  = (job: "일반", age: 15);
            var dave     = (job: "일반", age: 21);

            Console.WriteLine($"alice   :   {GetDiscountRate(alice)}");
            Console.WriteLine($"bob     :   {GetDiscountRate(bob)}");
            Console.WriteLine($"charie  :   {GetDiscountRate(charlie)}");
            Console.WriteLine($"dave    :   {GetDiscountRate(dave)}");
         
        }
    }
}