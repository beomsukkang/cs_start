using System;
//버블정렬메소드(UsingCallback)에 익명메소드를 추가한 버전
namespace AnonymousMethod
{
    delegate int Compare(int a, int b);

    class MainApp
    {
        static void BubbleSort(int[] DataSet, Compare Comparer)
        {
            int i = 0;
            int j = 0;
            int temp = 0;

            for (i = 0; i < DataSet.Length - 1; i++)
            {
                for (j = 0; j < DataSet.Length - (i + 1); j++)
                {
                    if (Comparer(DataSet[j], DataSet[j + 1]) > 0) // DataSet[j]가 DataSet[j + 1] 보다 크면 1, 같으면 0, 작으면 -1
                    {
                        temp = DataSet[j + 1];
                        DataSet[j + 1] = DataSet[j];
                        DataSet[j] = temp;
                        /*
                         3 2 4 7 10
                                dataset_n 	datasetn+1	 temp
                        i=0	j=0	3		    7		
                             =1	4		    7		    4
                             =2	2		    7		    7
                             =3	7		    10 		
                        i=1	j=0	3		    4		
                             =1	2		    4		    4           같은 방식으로 오름차순정렬
                        */
                    }
                }
            }
        }


        static void Main(string[] args)
        {
            int[] array = { 3, 7, 4, 2, 10 };

            Console.WriteLine("Sorting ascending...");
            BubbleSort(array, delegate (int a, int b) //익명 메소드
            {
                if (a > b)
                    return 1;
                else if (a == b)
                    return 0;
                else
                    return -1;
            });

            for (int i = 0; i < array.Length; i++)
                Console.Write($"{array[i]} ");

            int[] array2 = { 7, 2, 8, 10, 11 };

            Console.WriteLine("\nSorting dscending...");
            BubbleSort(array2, delegate (int a, int b) //익명 메소드
            {
                if (a < b)
                    return 1;
                else if (a == b)
                    return 0;
                else
                    return -1;
            });

            for (int i = 0; i < array2.Length; i++)
                Console.Write($"{array2[i]} ");

            Console.WriteLine();

        }
    }
}

