using System;
namespace ExceptionFiltering
{
    class FilterableException : Exception
    {
        public int ErrorNo
        {
            get; set;
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number Between 0~10");
            string input = Console.ReadLine();
            try
            {
                int num = Int32.Parse(input);

                if (num < 0 || num > 10)
                    throw new FilterableException() { ErrorNo = num }; //num이 0보다 작거나 10보다 크면 예외 객체 던짐
                else
                    Console.WriteLine($"Output :{num}");
            }
            catch (FilterableException e) when (e.ErrorNo < 0) //예외 객체가 0보다 작은 경우만 거름
            {
                Console.WriteLine("Negative input is not allowed");
            }
            catch (FilterableException e) when (e.ErrorNo > 10) //예외 객체가 10보다 크면 거름
            {
                Console.WriteLine("Too big number is not allowed");
            }

        }
    }
}
