using System;

namespace DelegateChains
{
    delegate void Notify(string message); //Notify대리자 선언

    class Notifier //Notify 대리자의 인스턴스, EventOccured를 가지는 클래스 Notifier선언
    {
        public Notify EventOccured;
    }

    class EventListener
    {
        private string name;
        public EventListener(string name)
        {
            this.name = name;
        }
        public void SomethingHappened(string message)
        {
            Console.WriteLine($"{name}.SomethingHappened : {message}");
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Notifier notifier = new Notifier();
            EventListener listener1 = new EventListener("Listener1");
            EventListener listener2 = new EventListener("Listener2");
            EventListener listener3 = new EventListener("Listener3");

            notifier.EventOccured += listener1.SomethingHappened;
            notifier.EventOccured += listener2.SomethingHappened;
            notifier.EventOccured += listener3.SomethingHappened;  //+= 연산자 이용한 체인생성
            notifier.EventOccured("You've got mail.");

            Console.WriteLine();

            notifier.EventOccured -= listener2.SomethingHappened; //+= 연산자 이용한 체인끊기
            notifier.EventOccured("Download complete.");

            Console.WriteLine();

            notifier.EventOccured = new Notify(listener2.SomethingHappened)
                + new Notify(listener3.SomethingHappened); //+, = 연산자 이용한 체인 만들기
            notifier.EventOccured("Nuclear launch detected.");

            Console.WriteLine();

            Notify notify1 = new Notify(listener1.SomethingHappened);
            Notify notify2 = new Notify(listener2.SomethingHappened);

            notifier.EventOccured =
                (Notify)Delegate.Combine(notify1, notify2); //Delegate.Combine()메소드를 이용한 체인만들기
            notifier.EventOccured("Fire!!");

            Console.WriteLine();

            notifier.EventOccured =
                (Notify)Delegate.Remove(notifier.EventOccured, notify2); //Delegate.Remove()메소드를 이용한 체인끊기
            notifier.EventOccured("RPG!");

        }
    }
}
/*출력
 Listener1.SomethingHappened : You've got mail.
Listener2.SomethingHappened : You've got mail.
Listener3.SomethingHappened : You've got mail.

Listener1.SomethingHappened : Download complete.
Listener3.SomethingHappened : Download complete.

Listener2.SomethingHappened : Nuclear launch detected.
Listener3.SomethingHappened : Nuclear launch detected.

Listener1.SomethingHappened : Fire!!
Listener2.SomethingHappened : Fire!!

Listener1.SomethingHappened : RPG!
 */