using System;
/*
 * 추상클래스는 클래스처럼 구현된 프로퍼티를 가질 수 있는 한편, 인터페이스처럼 구현되지 않은 프로퍼티도 가질 수 있다.(추상 프로퍼티)
 */

namespace PropertiesInAbstractClass
{
    abstract class Product
    {
        private static int serial = 0;
        public string SerialID //구현을 가진 프로퍼티
        {
            get { return String.Format("{0:d5}", serial++); }
        }

        abstract public DateTime ProductDate //구현이 없는 추상 프로퍼티
        { get; set; }

    }

    class MyProduct : Product
    {
        public override DateTime ProductDate //파생클래스는 기반 추상 클래스의 모든 추상 메소드 뿐만이 아니라 추상 프로퍼티를 재정의해야 한다.
        {
            get; set;
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Product product_1 = new MyProduct()
            {
                ProductDate = new DateTime(2018, 1, 10)
            };

            Console.WriteLine("Product:{0}, Product Date :{1}",
                product_1.SerialID, product_1.ProductDate);

            Product product_2 = new MyProduct()
            {
                ProductDate = new DateTime(2018, 2, 3)
            };

            Console.WriteLine("Product:{0}, Product Date :{1}",
                product_2.SerialID, product_2.ProductDate);

        }
    }
}
