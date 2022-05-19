using System;
//문장을 입력하면 스페이스를 모두 지우는 프로그램
namespace StatementLambda
{
    class MainApp
    {
        delegate string Concatenate(string[] args);

        static void Main(string[] args)
        {
            Concatenate concat =
                ( arr ) =>
                {
                    string result = "";
                    foreach (string s in arr)
                        result += s;

                    return result;
                };
            Console.WriteLine( concat(args) );
        }
    }
}