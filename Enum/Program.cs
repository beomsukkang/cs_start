using System;


namespace Enum
{
    class MainApp
    {
        enum DialogResult { YES, NO, CANCEL, CONFIRM, OK}

        const int RESULT_YES = 1;
        const int RESULT_NO = 2;
        const int RESULT_CONFIRM = 3;
        const int RESULT_CANCEL = 4;
        const int RESULT_OK = 5;

        static void Main(string[] args)
        {
            Console.WriteLine(RESULT_YES);
            Console.WriteLine(RESULT_NO);
            Console.WriteLine(RESULT_CONFIRM);
            Console.WriteLine(RESULT_CANCEL);
            Console.WriteLine(RESULT_OK);

            Console.WriteLine((int)DialogResult.YES);
            Console.WriteLine((int)DialogResult.NO);
            Console.WriteLine((int)DialogResult.CANCEL);
            Console.WriteLine((int)DialogResult.CONFIRM);
            Console.WriteLine((int)DialogResult.OK);
        }
    }
}
