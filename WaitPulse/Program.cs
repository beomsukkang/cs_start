using System;
using System.Threading;

namespace WaitPulse
{
    class Counter
    {
        const int LOOP_COUNT = 1000;

        readonly object thisLock;
        bool lockedCount = false;   //lockedCount와 count는 스레드가 블록될 조건을 검사하기 위해 사용된다.
                                    //lockedCount는 count 변수를 다른 스레드가 사용하고 있는지를 판별하기 위해, count는 각 스레드가 너무 오랫동안 count변수를 혼자 사용하는것을 막기위해 사용되었다. 
        private int count;
        public int Count
        { get { return count; } }

        public Counter()
        {
            thisLock = new object();
            count = 0;
        }

        public void Increase()
        {
            int loopCount = LOOP_COUNT;

            while (loopCount-- > 0)
            {
                lock (thisLock)
                {
                    while (count > 0 || lockedCount == true)
                        Monitor.Wait(thisLock);

                    lockedCount = true;
                    count++;
                    lockedCount = false; //lockedCount를 False로 만든 뒤에 다른 스레드를 깨운다. 깨어난 스레드들은 51행의 while문의 조건검사를 통해 다시 Wait()를 호출할 지, 그 다음 코드를 실행할지 결정한다.

                    Monitor.Pulse(thisLock);
                }
            }
        }

        public void Decrease()
        {
            int loopCount = LOOP_COUNT;

            while (loopCount-- > 0)
            {
                lock (thisLock)
                {
                    while (count < 0 || lockedCount == true)
                        Monitor.Wait(thisLock);

                    lockedCount = true;
                    count--;
                    lockedCount = false;

                    Monitor.Pulse(thisLock);
                }
            }
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            Counter counter = new Counter();

            Thread incThread = new Thread(
                new ThreadStart(counter.Increase));
            Thread decThread = new Thread(
                new ThreadStart(counter.Decrease));

            incThread.Start();
            decThread.Start();

            incThread.Join();
            decThread.Join();

            Console.WriteLine(counter.Count);
        }
    }
}