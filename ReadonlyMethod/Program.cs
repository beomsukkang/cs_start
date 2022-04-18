using System;

namespace ReadonlyMethod
{
    struct ACSetting
    {
        public double currentInCelsius; //현재 온도(섭씨)
        public double target;
        public readonly double  GetFahrenheit()
        {
            target = currentInCelsius * 1.8 + 32; //화씨 계산결과를 타겟에 저장
            return target; //target 반환
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            ACSetting acs;
            acs.currentInCelsius = 25;
            acs.target = 25;

            Console.WriteLine($"{acs.GetFahrenheit()}");
            Console.WriteLine($"{acs.target}");
        }
    }
}
//컴파일불가. 77/25가 나오기 위해선 어떻게 해야하는가