﻿using System;
using System.Linq;

namespace Join
{
    class Profile
    {
        public string Name { get; set; }
        public int Height { get; set; }
    }

    class Product
    {
        public string Title { get; set; }
        public string Star { get; set; }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Profile[] arrProfile =
            {
                new Profile(){ Name = "정우성", Height = 186 },
                new Profile(){ Name = "김태희", Height = 158 },
                new Profile(){ Name = "고현정", Height = 172 },
                new Profile(){ Name = "이문세", Height = 178 },
                new Profile(){ Name = "하하", Height = 171 }
            };

            Product[] arrProduct =
            {
                new Product(){ Title = "비트", Star = "정우성"},
                new Product(){ Title = "CF 다수", Star = "김태희"},
                new Product(){ Title = "아이리스", Star = "김태희"},
                new Product(){ Title = "모래시계", Star = "고현정"},
                new Product(){ Title = "Solo 예찬", Star = "이문세"}
            };

            var listProfile =
                from profile in arrProfile
                join product in arrProduct on profile.Name equals product.Star
                select new
                {
                    Name = profile.Name,
                    Work = product.Title,
                    Height = profile.Height
                };

            Console.WriteLine("---내부 조인 결과 ---");
            foreach (var profile in listProfile)
            {
                Console.WriteLine("이름 : {0}, 작품 : {1}, 키 : {2}cm",
                    profile.Name, profile.Work, profile.Height);
            }

            listProfile =
                from profile in arrProfile
                join product in arrProduct on profile.Name equals product.Star into ps
                from product in ps.DefaultIfEmpty(new Product() { Title = "그런 거 없음" })
                select new
                {
                    Name = profile.Name,
                    Work = product.Title,
                    Height = profile.Height
                };

            Console.WriteLine();
            Console.WriteLine("---외부 조인 결과---");
            foreach(var profile in listProfile)
            {
                Console.WriteLine("이름 : {0}, 작품 : {1}, 키 : {2}cm",
                   profile.Name, profile.Work, profile.Height);
            }
                
        }
    }
}
/* 결과값
 ---내부 조인 결과 ---
이름 : 정우성, 작품 : 비트, 키 : 186cm
이름 : 김태희, 작품 : CF 다수, 키 : 158cm
이름 : 김태희, 작품 : 아이리스, 키 : 158cm
이름 : 고현정, 작품 : 모래시계, 키 : 172cm
이름 : 이문세, 작품 : Solo 예찬, 키 : 178cm

---외부 조인 결과---
이름 : 정우성, 작품 : 비트, 키 : 186cm
이름 : 김태희, 작품 : CF 다수, 키 : 158cm
이름 : 김태희, 작품 : 아이리스, 키 : 158cm
이름 : 고현정, 작품 : 모래시계, 키 : 172cm
이름 : 이문세, 작품 : Solo 예찬, 키 : 178cm
이름 : 하하, 작품 : 그런 거 없음, 키 : 171cm

C:\Users\bumsu\Desktop\workspace\Join\bin\Debug\net6.0\Join.exe(프로세스 18404개)이(가) 종료되었습니다(코드: 0개).
이 창을 닫으려면 아무 키나 누르세요...*/