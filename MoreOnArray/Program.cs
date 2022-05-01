using System;

/*
 * int 기반의 배열은 System.array에서 파생됐기에 System.array의 특성과 메소드를 파악하면 배열의 특성과 메소드를 알게되는것이다.
 * 내부 데이터 원하는순으로 정렬, 특정 데이터 추출방법 등
 * 
 * 정적 메소드
 * 1. Sort()            배열을 정렬한다.
 * 2. BinarySearch<T>() 이진탐색을 수행한다.
 * 3. IndexOf()         배열에서 찾고자하는 특정 데이터의 인덱스를 반환한다.
 * 4. TrueForAll<T>()   배열의 모든 요소가 지정한 조건에 부합하는지의 여부를 반환한다.
 * 5. FindIndex<T>()    배열에서 지정한 조건에 부합하는 첫번째 요소의 인덱스를 반환한다. 지정한 조건에 바탕해 값을 찾는다.
 * 6. Resize<T>()       배열의 크기를 재조정한다.
 * 7. Clear()           배열의 모든 요소를 초기화한다.(배열이 숫자 형식 기반이면 0으로, 논리형식 기반이면 false, 참조 형식 기반이면 null로 초기화.)
 * 8. ForEach<T>()      배열의 모든 요소에 대해 동일한 작업을 수행하게 한다.
 * 9. Copy<T>()         배열의 일부를 다른 배열에 복사한다.
 * 
 * 인스턴스 메소드
 * - GetLength()        배열에서 지정한 차원의 길이를 반환한다. 이 메소드는 나중에 설명할 다차원 배열에서 유용하게 사용된다.
 * 
 *  프로퍼티
 * 1. Length            배열의 길이를 반환한다.
 * 2. Rank              배열의 차원을 반환한다.
 */

namespace MoreOnArray
{
    class MainApp
    {
        static bool CheckPassed(int score)
        {
            return score >= 60;
        }

        private static void Print(int Value)
        {
            Console.Write($"{Value} ");
        }

        static void Main(string[] args)
        {
            int[] scores = new int[] { 80, 74, 81, 90, 34 };

            foreach (int score in scores)
                Console.Write($"{score} ");
            Console.WriteLine();

            Array.Sort(scores);
            Array.ForEach<int>(scores, new Action<int>(Print));
            Console.WriteLine();

            Console.WriteLine($"Number of dimensions : {scores.Rank}");

            Console.WriteLine($"Binary Search : 81 is at"
                + $"{Array.BinarySearch<int>(scores, 81)}");

            Console.WriteLine($"Linear Search : 90 is at"
                + $"{Array.IndexOf(scores, 90)}");

            Console.WriteLine($"Everyone passed ? : "
                + $"{Array.TrueForAll<int>(scores, CheckPassed)}");
            //TrueForAll 메소드는 배열과 함께 조건을 검사하는 메소드를 매개변수로 받는다.
            int index = Array.FindIndex<int>(scores, (score) => score < 60);
            //FindIndex는 특정조건에 부합하는 메소드를 매개변수로 받는다.

            scores[index] = 61;
            Console.WriteLine($"Everyone passed ? : "
                + $"{Array.TrueForAll(scores, CheckPassed)}");

            Console.WriteLine("Old length of scores : " + $"{scores.GetLength(0)}");

            Array.Resize<int>(ref scores, 10); // 5였던 배열의 용량을 10으로 조정
            Console.WriteLine($"New length of scores : {scores.Length}");

            Array.ForEach<int>(scores, new Action<int>(Print));
            Console.WriteLine();

            Array.Clear(scores, 3, 7);
            Array.ForEach<int>(scores, new Action<int>(Print));
            Console.WriteLine();

            int[] sliced = new int[3];
            Array.Copy(scores, 0, sliced, 0, 3); //scores 배열의 0번째부터 3개 요소를 sliced 배열의 0번째~ 2번째 요소에 차례대로 복사한다.
            Array.ForEach(sliced, new Action<int>(Print));
            Console.WriteLine();
        }
    }
}