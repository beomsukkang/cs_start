using System;
/* 배열
 * 데이터형식[] 배열이름 = new 데이터형식[용량];
 * 인덱스는 0부터 시작
 */

//학생들의 점수를 배열안에 입력한 후 foreach문을 이용해 점수를 출력하고 평균을 계산하여 출력하는 프로그램

namespace ArraySample
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int[] scores = new int[5];
            scores[0] = 80;
            scores[1] = 74;
            scores[2] = 81;
            scores[3] = 90;
            scores[4] = 34;

            foreach (int score in scores)
                Console.WriteLine(score);

            int sum =0;
            foreach (int score in scores)
                sum += score;

            int average = sum / scores.Length; //배열 객체의 Length 프로퍼티는 배열의 용량을 나타낸다.
            Console.WriteLine($"Average Score : {average}");
        }
    }
}