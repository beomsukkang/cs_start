using System;

namespace GenericDelegate
{
    delegate int Compare<T>(T a, T b);

    class MainApp
    {
        static int AscendCompare<T>(T a, T b) where T : IComparable<T>
        {
            return a.CompareTo(b); //CompareTo메소드는 매개변수가 자신보다 크면 -1 ,같으면 0, 작으면 1을 반환한다. 오름차순정렬을 얻을 수 있다.
        }
        static int DescendCompare<T>(T a, T b) where T : IComparable<T> //System32.Int32(int), System.Double(double)을 비롯한
            //모든 수치 형식과 System.String(string)은 모두 IComparable을 상속해서 CompareTo() 메소드를 구현하고 있다.
        {
            return a.CompareTo(b) * -1; //-1을 곱하면 자신보다 클경우 1, 같으면 0, 작은 경우 -1을 반환한다
        }

        static void BubbleSort<T>(T[] DataSet, Compare<T> Comparer)
        {
            int i = 0;
            int j = 0;
            T temp;

            for(i = 0; i < DataSet.Length -1; i++)
            {
                for(j=0; j<DataSet.Length-(i+1);j++)
                {
                    if(Comparer(DataSet[j], DataSet[j+1]) > 0 )
                    {
                        temp = DataSet[j+1];
                        DataSet[j+1] = DataSet[j];
                        DataSet[j] = temp;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            int[] array = { 3, 7, 4, 2, 10 };

            Console.WriteLine("Sorting ascending...");
            BubbleSort<int>(array, new Compare<int>(AscendCompare));

            for (int i = 0; i < array.Length; i++)
                Console.Write($"{array[i]} ");

            string[] array2 = { "abc", "def", "ghi", "jkl", "mno" };

            Console.WriteLine("\nSorting descending...");
            BubbleSort<string>(array2, new Compare<string>(DescendCompare));

            for (int i =0; i<array2.Length; i++)
                Console.Write($"{array2[i]} ");

            Console.WriteLine();
        }
    }
}

//출력
/* Sorting ascending...
 * 2 3 4 7 10
 * Sorting descending...
 * mno jkl ghi def abc
 */