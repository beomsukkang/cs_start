using System;
using System.Globalization;
using static System.Console;

namespace StringFormatDatetime
{
    class MainApp
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2018, 11, 3, 23, 18, 22);

            WriteLine("12시간 형식: {0:yyyy-MM-dd tt hh:mm:ss (ddd)}", dt); //tt hh: 오전(오후) 시간(12)
            WriteLine("24시간 형식: {0:yyyy-MM-dd HH:mm:ss (dddd)}", dt); //HH 시간(24)

            CultureInfo ciKo = new CultureInfo("ko-KR");
            WriteLine();
            WriteLine(dt.ToString("yyyy-MM-dd HH:mm:ss (ddd)", ciKo)); //ddd:요일만(ex)토)
            WriteLine(dt.ToString("yyyy-MM-dd HH:mm:ss (dddd)", ciKo)); //dddd:풀네임(ex)토요일)
            WriteLine(dt.ToString(ciKo));

            CultureInfo ciEn = new CultureInfo("en-US");
            WriteLine();
            WriteLine(dt.ToString("yyyy-MM-dd tt hh:mm:ss (ddd)", ciEn)); 
            WriteLine(dt.ToString("yyyy-MM-dd HH:mm:ss (dddd)", ciEn));
            WriteLine(dt.ToString(ciEn));
        }
    }
}
