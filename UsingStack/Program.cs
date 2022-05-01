using System;
using System.Collections;

/*
 * Stack은 Queue와 반대로 먼저 들어온 데이터가 나중에 나가고, 나중에 들어온 데이터는 먼저 나가는 구조의 컬렉션이다.
 * 넣을땐 Push() 메소드를 사용해 데이터를 쌓고, 꺼낼 땐 Pop() 메소드를 호출해 꺼낸다. 꺼내고나면 그 데이터는 컬렉션에서 제거된다.
 */

using System;
using System.Collections;

namespace UsingStack
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            while (stack.Count > 0)
                Console.WriteLine(stack.Pop());
        }
    }
}