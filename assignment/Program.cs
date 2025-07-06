using System.ComponentModel;
using System.Drawing;

namespace assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region Q1


            //1 - .Write a program that prints an identity matrix using for loop, in other
            //words takes a value n from the user and shows the identity table of size n * n.
            //1 0 0
            //0 1 0
            // 0 0 1       main diagonal have the same values 



            //Console.WriteLine($"please enter the matrix size ::");
            //int.TryParse(Console.ReadLine(), out int N);


            //Console.Clear();

            //for (int i = 0; i < N; i++)
            //{

            //    for (int j = 0; j < N; j++)
            //    {

            //        if (i == j)
            //        {
            //            Console.Write("1 \t");
            //        }
            //        else
            //        {
            //            Console.Write("0 \t");
            //        }



            //    }
            //    Console.WriteLine();
            //}

            #endregion


            #region Q2
            // 2 - Write a program in C# Sharp to find the sum of all elements of the array.

            //Console.WriteLine($"enter the the array size");
            //int.TryParse(Console.ReadLine(), out int Size);

            //int[] array = new int[Size];

            //int sum = 0;

            //for (int i = 0; i < Size; i++)
            //{
            //    Console.WriteLine($"enter element {i+1}");
            //    int.TryParse(Console.ReadLine(), out  array[i]);


            //    sum += array[i];


            //}


            //Console.WriteLine($"sum of elements = {sum}");







            #endregion


            #region Q3

            //3 - Write a program in C# Sharp to merge two arrays of the same size sorted in
            //ascending order.

            //int[] arr01 = new int[5] { 5, 4, 3, 2, 1 };
            //int[] arr02 = new int[5] { 6, 9, 10, 7, 8};
            //int[] arr03 ;
            //int size = 0; 

            //if(arr01.Length == arr02.Length)
            //{   
            //    // merge to size in new array (expand )
            //    int Capcity=arr01.Length+arr02.Length;
            //    arr03 = new int[Capcity];
            //    // merge array 01 to a new array
            //    for(int i=0; i<arr01.Length; i++)
            //    {
            //        arr03[size++] = arr01[i];

            //    }
            //     //merge array 02;

            //    for (int j = 0; j < arr02.Length; j++)
            //    {
            //        arr03[size++] = arr02[j];
            //    }

            //    Array.Sort(arr03);
            //    Console.WriteLine("The new array after merging and sorting:");
            //    foreach (int x in arr03)
            //    {
            //        Console.Write(x + " ");
            //    }




            //}
            //else
            //{
            //    Console.WriteLine("can not merge cause they are not the same Size");

            //}

       




            #endregion


        }
    }
}
