using System;

/*
 레거시코드
-다른 코드와의 개연성을 무시한 채 due date만 맞춰 작성한 코드
-코드의 종속성.. 디펜던시를 낮추는 노력이 1도 없는 코드
-코맨트 등을 전혀 남기지 않아 더 수정, 보완이 어려운 코드
-기능, 단위의 함수 나아가 모듈 자체가 지나치게 큰 코드

기본구현메소드
-새로운 메소드를 추가할 때 기본적인 구현체를 갖게해서 기존에 있는 파생클래스에서의 컴파일 에러를 막을 수 있다.
-인터페이스 참조로 업캐스팅 했을때만 사용할 수 있다.
 */

namespace DefaultImplementation
{
    interface ILogger
    {
        void WriteLog(string message);

        void WriteError(string error)
        {
            WriteLog($"Error:{error}");
        }
    }

    class ConsoleLogger : ILogger
    {
        public void WriteLog(string message)
        {
            Console.WriteLine(
                $"{DateTime.Now.ToLocalTime()}, {message}");
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            ILogger logger = new ConsoleLogger();
            logger.WriteLog("System Up");
            logger.WriteError("System Fail");

            ConsoleLogger clogger = new ConsoleLogger();
            clogger.WriteLog("System Up"); // OK
            //clogger.WriteError("System Fail"); // 컴파일 에러
        }
    }
}