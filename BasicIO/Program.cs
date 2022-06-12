using System;
using System.IO;

namespace BasicIO
{
    class MainApp
    {
        static void Main(string[] args)
        {
            long someValue = 0x123456789ABCDEF0;
            // X16에서 X는 수를 16진수로 표현하고 뒤의 숫자 16은 열여섯자리 수로 표현한다. X16을 X20으로 바꾸면 아래코드는 20자리의 16진수를 표현하게 된다.
            Console.WriteLine("{0,-1} : 0x{1:X16}", "Original Data", someValue);

            Stream outStream = new FileStream("a.dat", FileMode.Create);
            // someValue의 8바이트를 바이트 배열에 나눠 넣는다.
            byte[] wBytes = BitConverter.GetBytes(someValue);

            Console.Write("{0,-13} : ", "Byte array");

            foreach (byte b in wBytes)
                Console.Write("{0:X2} ", b);
            Console.WriteLine();

            // Write() 메소드를 이용해서 단번에 파일에 기록한다.
            outStream.Write(wBytes, 0, wBytes.Length);
            outStream.Close();

            Stream inStream = new FileStream("a.dat", FileMode.Open);
            byte[] rbytes = new byte[8];

            int i = 0;
            while(inStream.Position < inStream.Length)
                rbytes[i++] = (byte) inStream.ReadByte();

            long readValue = BitConverter.ToInt64(rbytes, 0);

            Console.WriteLine("{0,-13} : 0x{1:X16}", "Read Data", readValue);
            inStream.Close();



        }
    }

}