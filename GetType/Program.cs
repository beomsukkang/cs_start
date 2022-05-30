using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

namespace GetType
{
    class MainApp
    {
        static void PrintInterfaces(Type type)
        {
            Console.WriteLine("------- Interfaces -------");

            Type[] interfaces = type.GetInterfaces();  //해당형식이 상속하는 인터페이스 목록을 반환한다.(반환형식 : Type[])
            foreach(Type i in interfaces)
                Console.WriteLine("Name : {0}", i.Name);

            Console.WriteLine();
        }

        static void PrintFields(Type type)
        {
            Console.WriteLine("------- Field -------");

            FieldInfo[] fields = type.GetFields( //해당형식의 필드목록을 반환한다. (반환형식 : FieldInfo[])
                BindingFlags.NonPublic |
                BindingFlags.Public |
                BindingFlags.Static |
                BindingFlags.Instance); 

            foreach(FieldInfo field in fields)
            {
                String accessLevel = "protected";
                if (field.IsPublic) accessLevel = "public";
                else if (field.IsPrivate) accessLevel = "private";

                Console.WriteLine("Access:{0}, Type : {1}, Name : {2}",
                    accessLevel, field.FieldType.Name, field.Name);
            }

            Console.WriteLine() ;
        }

        static void PrintMethods(Type type)
        {
            Console.WriteLine("------- Methods -------");
            MethodInfo[] methods = type.GetMethods(); //해당형식의 메소드 목록을 반환한다. ((반환형식 : MethodInfo[])
            foreach (MethodInfo method in methods)
            {
                Console.Write("Type : {0}, Name : {1}, Parameter : ", method.ReturnType.Name, method.Name);

                ParameterInfo[] args = method.GetParameters();
                for(int i =0; i < args.Length; i++)
                {
                    Console.Write("{0}", args[i].ParameterType.Name);
                    if (i < args.Length - 1)
                        Console.Write(" , ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void PrintProperties(Type type)
        {
            Console.WriteLine("------- Properties -------");

            PropertyInfo[] properties = type.GetProperties(); //해당형식의 프로퍼티 목록을 반환한다. (반환형식 : PropertyInfo[])
            foreach (PropertyInfo property in properties)
                Console.WriteLine("Type : {0}, Name : {1}", property.PropertyType.Name, property.Name);

            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int a = 0;
            Type type = a.GetType();

            PrintInterfaces(type);
            PrintFields(type);
            PrintProperties(type);
            PrintMethods(type);
        }
    }
}
/* 출력
 ------- Interfaces -------
Name : IComparable
Name : IConvertible
Name : ISpanFormattable
Name : IFormattable
Name : IComparable`1
Name : IEquatable`1
Name : IBinaryInteger`1
Name : IBinaryNumber`1
Name : IBitwiseOperators`3
Name : INumber`1
Name : IAdditionOperators`3
Name : IAdditiveIdentity`2
Name : IComparisonOperators`2
Name : IEqualityOperators`2
Name : IDecrementOperators`1
Name : IDivisionOperators`3
Name : IIncrementOperators`1
Name : IModulusOperators`3
Name : IMultiplicativeIdentity`2
Name : IMultiplyOperators`3
Name : ISpanParseable`1
Name : IParseable`1
Name : ISubtractionOperators`3
Name : IUnaryNegationOperators`2
Name : IUnaryPlusOperators`2
Name : IShiftOperators`2
Name : IMinMaxValue`1
Name : ISignedNumber`1

------- Field -------
Access:private, Type : Int32, Name : m_value
Access:public, Type : Int32, Name : MaxValue
Access:public, Type : Int32, Name : MinValue

------- Properties ------- //int 형식에는 프로퍼티가 없다.

------- Methods -------
Type : Int32, Name : CompareTo, Parameter : Object
Type : Int32, Name : CompareTo, Parameter : Int32
Type : Boolean, Name : Equals, Parameter : Object
Type : Boolean, Name : Equals, Parameter : Int32
Type : Int32, Name : GetHashCode, Parameter :
Type : String, Name : ToString, Parameter :
Type : String, Name : ToString, Parameter : String
Type : String, Name : ToString, Parameter : IFormatProvider
Type : String, Name : ToString, Parameter : String , IFormatProvider
Type : Boolean, Name : TryFormat, Parameter : Span`1 , Int32& , ReadOnlySpan`1 , IFormatProvider
Type : Int32, Name : Parse, Parameter : String
Type : Int32, Name : Parse, Parameter : String , NumberStyles
Type : Int32, Name : Parse, Parameter : String , IFormatProvider
Type : Int32, Name : Parse, Parameter : String , NumberStyles , IFormatProvider
Type : Int32, Name : Parse, Parameter : ReadOnlySpan`1 , NumberStyles , IFormatProvider
Type : Boolean, Name : TryParse, Parameter : String , Int32&
Type : Boolean, Name : TryParse, Parameter : ReadOnlySpan`1 , Int32&
Type : Boolean, Name : TryParse, Parameter : String , NumberStyles , IFormatProvider , Int32&
Type : Boolean, Name : TryParse, Parameter : ReadOnlySpan`1 , NumberStyles , IFormatProvider , Int32&
Type : TypeCode, Name : GetTypeCode, Parameter :
Type : Type, Name : GetType, Parameter :


C:\Users\bumsu\Desktop\workspace\GetType\bin\Debug\net6.0\GetType.exe(프로세스 16156개)이(가) 종료되었습니다(코드: 0개).
이 창을 닫으려면 아무 키나 누르세요...
 */