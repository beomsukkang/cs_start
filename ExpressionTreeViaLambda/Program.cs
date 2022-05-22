using System;
using System.Linq.Expressions;

//UsingExpressionTree와 동일한 출력, Lambda식을 이용해 더 간편하게 만들기.(Expression형식은 불변이기에 인스턴스 한번 만들어지면 변경불가)
namespace ExpressionTreeViaLambda
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Expression<Func<int, int, int>> expression = 
                (a, b) => 1*2+(a-b);
            Func<int, int, int> func = expression.Compile();

            //x=7, y=8
            Console.WriteLine($"1*2+({7}-{8}) = {func(7, 8)}");

        }
    }
}