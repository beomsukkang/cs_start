using System;
/*
 * 일반화 메소드나 일반화 클래스가 입력받는 형식 매개변수T는 모든 데이터 형식을 대신할 수 있다.
 * 하지만 종종 특정 조건을 갖춘 형식에만 대응하는 형식 매개변수가 필요할 때도 있다.
 * Where T : struct             //T는 값형식이어야 함
 * Where T : class              //T는 참조형식이어야 함
 * Where T : new()              //T는 반드시 매개변수가 없는 생성자가 있어야 한다.
 * Where T : 기반_클래스_이름   //T는 명시한 기반 클래스의 파생 클래스여야 한다.
 * Where T : 인터페이스_이름    //T는 명시한 인터페이스를 반드시 구현해야 한다. 인터페이스_이름에는 여러개의 인터페이스를 명시할 수도 있다.
 * Where T : U                  //T는 또다른 형식 매개변수 U로부터 상속받은 클래스여야한다.
 */
namespace ConstraintOnTypeParameters
{
    class StructArray<T> where T : struct
    {
        public T[] Array { get; set; }
        public StructArray(int size)
        {
            Array = new T[size];
        }
    }

    class RefArray<T> where T : class
    {
        public T[] Array { get; set; }
        public RefArray(int size)
        {
            Array= new T[size];
        }
    }

    class Base { }
    class Derived : Base { }

    class BaseArray<U> where U : Base
    {
        public U[] Array { get; set; }
        public BaseArray(int size)
        {
            Array = new U[size];
        }

        public void CopyArray<T>(T[] Source) where T : U
        {
            Source.CopyTo(Array, 0);
        }
    }

    class MainApp
    {
        public static T CreateInstance<T>() where T : new()
        {
            return new T();
        }

        static void Main(string[] args)
        {
            StructArray<int> a = new StructArray<int>(3);
            a.Array[0] = 0;
            a.Array[1] = 1;
            a.Array[2] = 2;

            RefArray<StructArray<double>> b = new RefArray<StructArray<double>>(3);
            b.Array[0] = new StructArray<double>(5);
            b.Array[1] = new StructArray<double>(10);
            b.Array[2] = new StructArray<double>(1005);
            /*foreach (var x in b.array)
                Console.WriteLine($"{x}");*/
            for (int i = 0; i < b.Array.Length; i++)
                Console.WriteLine($"{b.Array[i]}");


            BaseArray<Base> c = new BaseArray<Base>(3);
            c.Array[0] = new Base();
            c.Array[1] = new Derived();
            c.Array[2] = CreateInstance<Base>();

            BaseArray<Derived> d = new BaseArray<Derived>(3);
            d.Array[0] = new Derived(); //Base 형식은 여기에 할당불가.
            //d.Array[1] = new CreateInstance<Derived>();
            d.Array[1] = CreateInstance<Derived>();

            BaseArray<Derived> e = new BaseArray<Derived>(3);
            e.CopyArray<Derived>(d.Array);


        }
    }
}

//출력문 삽입해서 확인할것
//인터페이스를 구현하는 클래스로 형식 매개변수를 제약하는 일반화코드 만들어보기