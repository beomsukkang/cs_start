using System.Collections;
using static System.Console;

namespace NullConditionalOperator
{
    class MainApp
    {
        static void Main(string[] args)
        {
            ArrayList a = null;
            a?.Add("야구");// a?가 null 반환하므로  Add()메소드 호출x
            a?.Add("축구");
            WriteLine($"Count : {a?.Count}");
            WriteLine($"{a?[0]}");
            WriteLine($"{a?[1]}");

            a = new ArrayList(); //a는 더이상 null이 아님.
            a?.Add("야구");// a?가 null 반환하므로  Add()메소드 호출x
            a?.Add("축구");
            WriteLine($"Count : {a?.Count}");
            WriteLine($"{a?[0]}");
            WriteLine($"{a?[1]}");

        }
    }
}
