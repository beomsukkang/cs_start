﻿using System;
using System.Reflection;
using System.Reflection.Emit;

namespace EmitTest
{
    public class MainApp
    {
        public static void Main()
        {
            AssemblyBuilder newAssembly =
                AssemblyBuilder.DefineDynamicAssembly(
                    new AssemblyName("CalculatorAssembly"),
                    AssemblyBuilderAccess.Run);

            ModuleBuilder newModule = newAssembly.DefineDynamicModule(
                "Calculator");
            TypeBuilder newType = newModule.DefineType("Sum1To100");

            MethodBuilder newMethod = newType.DefineMethod(
                "Calculate",
                MethodAttributes.Public,
                typeof(int), //반환 형식
                new Type[0]); //매개변수

            ILGenerator generator = newMethod.GetILGenerator();

            generator.Emit(OpCodes.Ldc_I4, 1); //32비트 정수(1)을 계산스택에 넣는다.

            for (int i =2; i <= 100; i++)
            {
                generator.Emit(OpCodes.Ldc_I4, i); //32비트 정수(i)를 계산스택에 넣는다.
                generator.Emit(OpCodes.Add); //계산 후 계산스택에 담겨있는 두개의 값을 꺼내서 더한 후, 그 결과를 다시 계산스택에 넣는다.
            }

            generator.Emit(OpCodes.Ret);
            newType.CreateType();

            object sum1To100 = Activator.CreateInstance(newType);

            MethodInfo Calculate = sum1To100.GetType().
                GetMethod("Calculate");
            
            Console.WriteLine(Calculate.Invoke(sum1To100, null));
        }
    }
}