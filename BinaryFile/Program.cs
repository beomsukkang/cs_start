using System;
using System.IO;

namespace BinaryFile
{
    class MainApp
    {
        static void Main(string[] args)
        {
            using (BinaryWriter bw =
                new BinaryWriter(
                    new FileStream("a.dat", FileMode.Create)))
            {
                bw.Write(int.MaxValue);
                bw.Write("Good Morning!");
                bw.Write(uint.MaxValue);
                bw.Write("안녕하세요!");
                bw.Write(double.MaxValue);
            }
            //bw 스트림은 19행에서 닫힌다. 21행과 같은 스타일의 using 선언을 이용했다면, a.dat가 열려있는 상태에서 같은 파일을 21에서 다시 열려고 하는 상황이 발생했을것이다.

            using BinaryReader br =
                new BinaryReader(
                    new FileStream("a.dat", FileMode.Open));

            Console.WriteLine($"File size : {br.BaseStream.Length} bytes");
            Console.WriteLine($"{br.ReadInt32()}");
            Console.WriteLine($"{br.ReadString()}");
            Console.WriteLine($"{br.ReadUInt32()}");
            Console.WriteLine($"{br.ReadString()}");
            Console.WriteLine($"{br.ReadDouble()}");

        }
    }
}