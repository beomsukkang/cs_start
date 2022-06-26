using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace UsingTask
{
    class MainApp
    {
        static void Main(string[] args)
        {
            string srcFile = args[0];

            Action<object> FileCopyAction = (object state) => //인수를 받는다.
            {
                String[] paths = (String[])state;
                File.Copy(paths[0], paths[1]);

                Console.WriteLine("TaskID:{0}, ThreadID:{1}, {2} was copied to {3}",
                    Task.CurrentId, Thread.CurrentThread.ManagedThreadId,
                    paths[0], paths[1]);
            };

            Task t1 = new Task(
                FileCopyAction,
                new string[]{ srcFile, srcFile + ".copy1" });

            Task t2 = Task.Run(() =>
            {
                FileCopyAction(new string[] { srcFile, srcFile + ".copy2" });
            });

            t1.Start();

            Task t3 = new Task(
                FileCopyAction,
                new string[]{ srcFile, srcFile + ".copy3" }); //두번째 인수는 FileCopyAction의 인수로 사용된다.

            t3.RunSynchronously();  //Task는 코드의 비동기실행을 위한 Start()메소드뿐 아니라 동기 실행을 위한 RunSynchronously() 메소드도 제공한다.
                                    //이 메소드는 실행이 끝나야 반환되지만, 나쁜 습관을 방지하기 위해 Wait()는 꼬박꼬박 호출해주는게 좋다.

            t1.Wait();
            t2.Wait();
            t3.Wait();

        }
    }
}
/* 결과값
 C:\Users\bumsu\Desktop\workspace\UsingTask\bin\Debug\net6.0>UsingTask a.txt
TaskID:2, ThreadID:6, a.txt was copied to a.txt.copy1
TaskID:1, ThreadID:4, a.txt was copied to a.txt.copy2
TaskID:3, ThreadID:1, a.txt was copied to a.txt.copy3
*/
