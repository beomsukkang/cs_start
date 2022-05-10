using System;

namespace ThrowExpression
{
    class MainApp
    {
        static void Main(string[] args)
        {
            try
            {
                int? a = null;
                int b = a ?? throw new ArgumentNullException(); //a는 null이므로 b에 a를 할당하지 않고 throw 식 실행
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e);
            }

            try
            {
                int[] array = new[] { 1, 2, 3 };
                int index = 4;
                int value = array[
                    index >= 0 && index < 3
                    ? index : throw new IndexOutOfRangeException()
                    ];
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
