using System;
using System.Collections;

/*
 * Queue(대기열) 자료구조는 데이터나 작업을 차례대로 입력해뒀다가 입력된 순서대로 하나씩 꺼내 처리하기 위해 사용된다.
 * 입력(Enqueue)은 오직 뒤에서, 출력(Dequeue)은 앞에서만 이루어진다.
 * OS에서 CPU가 처리해야할 작업을 정리할때, 프린터가 여러문서를 출력할때, 인터넷 동영상 스트리밍 서비스에서 콘텐츠를 버퍼링할때 사용된다.
 */

namespace UsingQueue
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Queue que = new Queue();
            que.Enqueue(1);
            que.Enqueue(2);
            que.Enqueue(3);
            que.Enqueue(4);
            que.Enqueue(5);

            while (que.Count > 0)
                Console.WriteLine(que.Dequeue());
        }
    }
}