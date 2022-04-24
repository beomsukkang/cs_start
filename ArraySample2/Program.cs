using System;
//배열의 길이를 알아내고 역순으로 인덱스를 지정하는 방법.

//학생들의 점수를 배열안에 입력한 후 foreach문을 이용해 점수를 출력하고 평균을 계산하여 출력하는 프로그램2

namespace ArraySample2
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int[] scores = new int[5];
            scores[0] = 80;
            scores[1] = 74;
            scores[2] = 81;
            scores[^2] = 90; //배열의 마지막-1
            scores[^1] = 34; //배열의 마지막 scores[scores.Length-1] = 34;와 동일

            foreach (int score in scores)
                Console.WriteLine(score);

            int sum = 0;
            foreach (int score in scores)
                sum += score;

            int average = sum / scores.Length;
            Console.WriteLine($"Average Score : {average}");
        }
    }
}