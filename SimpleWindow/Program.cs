using System;


/* SimpleWindow.csproj에서
 <Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net6.0-Windows</TargetFramework>
	<UseWindowsForms>true</UseWindowsForms>
    <DisableWinExeOutputInference>true</DisableWinExeOutputInference>
  </PropertyGroup>

</Project>

 */
namespace SimpleWindow
{
    class MainApp : System.Windows.Forms.Form
    {
        static void Main(string[] args)
        {
            System.Windows.Forms.Application.Run(new MainApp()); //Application.Run() 메소드에 MainApp의 인스턴스를 인수로 넘겨 호출한다.
        }
    }
}