using System;

namespace Finally
{
    class MainApp
    {
        static int Divide(int dividend, int divisor)
        {
            try
            {
                Console.WriteLine("Divide() 시작");
                return dividend / divisor; //예외가 일어나지 않고 정상적으로  return을 해도 finally절은 실행된다.
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Divide() 예외 발생");
                throw e; //예외가 발생해도 finally절은 실행된다.
            }
            finally //데이터 커넥션을 닫는 코드
            {
                Console.WriteLine("Divide() 끝");
            }
        }

        static void Main(string[] args)
        {
            try
            {
                Console.Write("제수를 입력하세요. :");
                String temp = Console.ReadLine();
                int dividend = Convert.ToInt32(temp);

                Console.Write("피제수를 입력하세요. :");
                temp = Console.ReadLine();
                int divisor = Convert.ToInt32(temp);

                Console.WriteLine("{0}/{1} = {2}",
                    dividend, divisor, Divide(dividend, divisor));
            }
            catch(FormatException e)
            {
                Console.WriteLine("에러 : " + e.Message);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("에러 : " + e.Message);
            }
            finally
            {
                Console.WriteLine("프로그램을 종료합니다.");
            }
        }
    }
}