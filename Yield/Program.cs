using System;
using System.Collections;

/*
 * foreach문은 for문처럼 요소의 위치를 위한 인덱스변수를 선언할 필요가 없다.
 * 배열이나 리스트같은 컬렉션에서만 사용가능하다.
 * IEnumerable를 상속하는 형식만 지원한다.
 * Yield문을 사용하면  IEnumerable를 상속하지 않아도 컴파일러가 자동으로 해당 인터페이스를 구현한 클래스를 생성해준다.
 */
namespace Yield
{
    class MyEnumerator
    {
        int[] numbers = { 1, 2, 3, 4 };
        public IEnumerator GetEnumerator()
        {
            yield return numbers[0]; //현재 메소드의 실행을 일시 정지해놓고 호출자에게 결과 반환
            yield return numbers[1];
            yield return numbers[2];
            yield break;             //현재 메소드 실행중지
            yield return numbers[3]; //실행x
        }
    }
    
    class MainApp
    {
        static void Main(string[] args)
        {
            var obj = new MyEnumerator();
            foreach (int i in obj)
                Console.WriteLine(i);
        }
    }
}