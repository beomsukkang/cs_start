using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Scripting;
using Microsoft.Scripting.Hosting;
using IronPython.Hosting;

namespace WithPython
{
    class MainApp
    {
        static void Main(string[] args)
        {
            ScriptEngine engine = Python.CreateEngine();
            ScriptScope scope = engine.CreateScope();
            scope.SetVariable("n", "박상현");
            scope.SetVariable("p", "010-123-4566");

            ScriptSource source = engine.CreateScriptSourceFromString(
                @"
class NameCard :
    name = ''
    phone = ''

    def __init__(self, name, phone) :
        self.name = name
        self.phone = phone

    def printNameCard(self) :
        print self.name + ', ' + self.phone

NameCard(n,p)
");
            //파이썬코드에서 클래스 선언
            //NameCard() 생성자 호출
            dynamic result = source.Execute(scope); //22~34행의 파이선 코드를 실행해 그 결과를 반환. NameCard 객체가 생성되어 반환됨.
            result.printNameCard(); //이 객체의 메소드 호출 가능

            Console.WriteLine("{0}, {1}", result.name, result.phone); //필드 접근 가능
        }
    }
}