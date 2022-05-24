using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleLinq
{
    class Profile
    {
        public string Name { get; set; }
        public int Height {  get; set; }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Profile[] arrProfile =
            {
                new Profile(){Name ="정우성", Height=186},
                new Profile(){Name ="김태희", Height=158},
                new Profile(){Name ="고현정", Height=172},
                new Profile(){Name ="이문세", Height=178},
                new Profile(){Name ="하하", Height=171}
            };

            var profiles = from profile in arrProfile
                           where profile.Height < 175 // where는 필터역할, 175 이하 객체만 추출
                           orderby profile.Height ascending // 데이터 정렬수행, Height 오름차순정렬(ascending 생략가능, 내림차순은 descending)
                           select new //최종 결과 추출, 무명형식을 이용해 새로운 형식을 즉석에서 만들 수 있다.
                           {
                               Name = profile.Name,
                               InchHeight = profile.Height * 0.393
                           };

            foreach (var profile in profiles)
                Console.WriteLine($"{profile.Name}, {profile.InchHeight}");
        }
    }

}