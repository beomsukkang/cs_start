using System;
using System.Collections;
using static System.Console;

namespace InitializingCollections
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int[] arr = { 123, 456, 789 };

            ArrayList list = new ArrayList(arr);
            foreach (object item in list)
                WriteLine($"ArrayList :{item}");
            WriteLine();

            Stack stack = new Stack(arr);
            foreach (object item in stack)
                WriteLine($"Stack :{item}");
            WriteLine();

            Queue queue = new Queue(arr); // Queue, stack은 컬렉션초기자 사용불가(IEnumerable인터페이스와 Add()메소드를 구현하는 컬렉션만 지원)
            foreach (object item in queue)
                WriteLine($"Queue :{item}"); //여기까지 배열을 이용한 컬렉션 초기화
            WriteLine();

            ArrayList list2 = new ArrayList() { 11, 22, 33}; //컬렉션 초기자를 이용한 컬렉션 초기화
            foreach (object item in list2)
                WriteLine($"ArrayList2 :{item}");
            WriteLine();
        }
    }
}