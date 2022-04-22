using System;

/*
 추상클래스
-"구현"을 가질 수 있지만 "인스턴스"는 가질 수 없다.
-추상메소드를 가질 수 있다. 추상 메소드는 인터페이스 역할도 하게 해주는 장치이다.
 구현을 갖진 못하지만 파생클래스에서 반드시 구현을 하도록 강제하기 때문이다.
-또다른 추상클래스 상속가능. 부모 추상클래스으 추상 메소드를 구현하지 않아도 된다. 클래스에서 구현하기에.
 */

namespace AbstactClass
{
    abstract class AbstractBase
    {
        protected void PrivateMethodA()
        {
            Console.WriteLine("AbstractBase.PrivateMethodA()");
        }

        public void PublicMethodA()
        {
            Console.WriteLine("AbstractBase.PublicMethodA()");
        }

        public abstract void AbstractMethodA();
    }
    class Derived : AbstractBase
    {
        public override void AbstractMethodA()
        {
            Console.WriteLine("Derived.AbstracMethodA()");
            PrivateMethodA();
        }
    }

     class MainApp
     {
         static void Main(string[] args)
         {
             AbstractBase obj = new Derived();
             obj.AbstractMethodA();
             obj.PublicMethodA();
                
         }
     }
}
