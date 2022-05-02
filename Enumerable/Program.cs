using System;
using System.Collections;

//직접 IEnumerator를 상속하는 클래스를 구현하기. MoveNext(), Reset(), Current프로퍼티를 구현하면 요구사항 충족시킬 수 있음.
//이후 GetEnumerator()를 구현할 땐 그저 자기자신(this)를 반환하면 됨.
namespace Enumerable
{
    class MyList : IEnumerable, IEnumerator
    {
        private int[] array;
        int position = -1;  //컬렉션의 현재 위치를 다루는 변수. 초깃값은 -1이다. 0은 배열의 첫 요소를 가르키는 수.
        //포지션이 0을 가지고 있을 때 foreach문이 첫번째 반복을 수행하면 MoveNext()메소드를 실행하고, 이때 포지션이 1이되어 두번째 요소를 가져오는 문제 발생.

        public MyList()
        {
            array = new int[3];
        }

        public int this[int index]
        {
            get
            {
                return array[index];
            }
            
            set
            {
                if(index >= array.Length)
                {
                    Array.Resize(ref array, index+1);
                    Console.WriteLine($"Array Resized : {array.Length}");
                }

                array[index] = value;
            }
        }

        //IEnumerator 멤버
        public object Current  //IEnumerator로부터 상속받은 Current프로퍼티는 현재 위치의 요소를 반환한다.
        {
            get { return array[position]; }
        }

        //IEnumerator 멤버
        public bool MoveNext() //IEnumerator로부터 상속받은 MoveNext()메소드. 다음 위치의 요소로 이동한다.
        {
            if(position == array.Length-1)
            {
                Reset();
                return false;
            }

            position++;
            return (position < array.Length);
        }

        //IEnumerator 멤버
        public void Reset() //IEnumerator로부터 상속받은 Reset()메소드. 요소의 위치를 첫요소의 앞으로 옮긴다.
        {
            position = -1;
        }

        //IEnumerator 멤버
        public IEnumerator GetEnumerator()
        {
            return this;
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            MyList list =  new MyList();
            for (int i = 0; i < 5; i++)
                list[i] = i;

            foreach (int e in list)
                Console.WriteLine(e);
        }
    }
}