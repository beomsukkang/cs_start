using System;
using System.IO;

namespace TextFile
{
    class MainApp
    {
        static void Main(string[] args)
        {
            using (StreamWriter sw =
               new StreamWriter(
                   new FileStream("a.txt", FileMode.Create)))
            {
                sw.WriteLine(int.MaxValue); //WriteLine, Write 메소드는 C#이 제공하는 모든 기본 데이터 형식에 대해 오버로딩되어 있다.
                sw.WriteLine("Good morning!");
                sw.WriteLine(uint.MaxValue);
                sw.WriteLine("안녕하세요!");
                sw.WriteLine(double.MaxValue);
            }

            using (StreamReader sr =
               new StreamReader(
                   new FileStream("a.txt", FileMode.Open)))
            {
                Console.WriteLine($"File size : {sr.BaseStream.Length} bytes");

                while (sr.EndOfStream == false) //스트림의 끝에 도착했는지 알려준다.
                {
                    Console.WriteLine(sr.ReadLine());
                }
            }
        }
    }
}