using System;
using System.Collections;
using static System.Console;

/*
 * Hashtable은 키와 값의 쌍으로 이뤄진 데이터를 다룰 때 사용한다. 탐색속도가 빠르고 사용이 편하다.
 * 배열은 데이터를 저장할 요소의 위치로 인덱스를 사용하는 반면에, Hashtable 컬렉션은 키 데이터를 그대로 사용한다.
 */

namespace UsingHashtable
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht["하나"] = "one";
            ht["둘"] = "two";
            ht["셋"] = "three";
            ht["넷"] = "four";
            ht["다섯"] = "five";

            WriteLine(ht["하나"]);
            WriteLine(ht["둘"]);
            WriteLine(ht["셋"]);
            WriteLine(ht["넷"]);
            WriteLine(ht["다섯"]);
        }
    }
}