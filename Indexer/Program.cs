using System;
using System.Collections;

/*
 * 인덱서는 인덱스를 이용해서 객체 내의 데이터에 접근하게 해주는 프로퍼티. 객체를 배열처럼 사용할 수 있게 해준다.
 * 프로퍼티처럼 식별자를 따로 가지지 않는다.
 * 인덱스를 통해 데이터를 저장하고자 하는 시도가 이루어질때 지정한 인덱스보다 배열의 크기가 작다면 인덱스에 맞춰 배열의 크기를 재조정한다.
 */

namespace Indexer
{
    class MyList
    {
        private int[] array;

        public MyList()
        {
            array = new int[3];
        }

        public int this[int index]
        {
            get
            {
                return array[index]; //index를 이용해 내부 데이터 변환
            }
            set
            {
                if(index >= array.Length)
                {
                    Array.Resize(ref array, index+1);
                    Console.WriteLine($"Array Resized : {array.Length}");
                } // index 이용해 내부 데이터 저장

                array[index] = value;
            }
        }

        public int Length
        {
            get { return array.Length; }
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            MyList list = new MyList();
            for (int i = 0; i < 5; i++)
                list[i] = i; //배열처럼 인덱스를 통해 데이터를 입력

            for (int i = 0; i < list.Length; i++)
                Console.WriteLine(list[i]); //데이터를 얻어올때도 인덱스 사용
        }
    }
}