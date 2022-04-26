using System;
/*배열을 초기화하는 방법 세가지
 *1. 배열의 원소개수 명시, 중괄호(컬렉션 초기자)로 둘러싸인 블록을 붙인뒤 블록 사이에 배열의 각 원소에 입력될 데이터를 입력 
 *2. 첫번째 방법에서 배열의 용량을 생략
 *3. new 연산자, 형식과 대괄호와 배열의 용량을 모두 생략한 채 코드 블록사잉 배열의 각 원소에 할당할 데이터를 넣어준다.
 */
namespace InitializingArray
{
    class MainApp
    {
        static void Main(string[] args)
        {
            string[] array1 = new string[3] { "안녕", "Hello", "Halo" }; //1번방법
            Console.WriteLine("array1...");
            foreach (string greeting in array1)
                Console.WriteLine($"{greeting}");

            string[] array2 = new string[] { "안녕", "Hello", "Halo" }; //2번방법
            Console.WriteLine("\narray2...");
            foreach (string greeting in array2)
                Console.WriteLine($"{greeting}");

            string[] array3 = { "안녕", "Hello", "Halo" }; //3번방법
            Console.WriteLine("\narray3...");
            foreach (string greeting in array3)
                Console.WriteLine($"{greeting}");
        }
    }
}