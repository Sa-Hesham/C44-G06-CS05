using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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


            #region Q4

            //4 - Write a program in C# Sharp to find maximum and minimum element in an
            //    array = { 2, 4, 2, 6, 6, 8, 9, 10, 30, 59, 58 };


            //first way

            //int[] arr=  new int [] { 2, 4, 2, 6, 6, 8, 9, 10, 30, 59, 58 };

            //int max =arr.Max();
            //int min=arr.Min();
            // Console.WriteLine($"the max Value is  \" {max} \" ");
            // Console.WriteLine($"the min Value is  \" {min} \" ");

            // second way 
            //Array.Sort(arr);
            //Console.WriteLine($"the max Value is  \" {arr[(arr.Length-1)]}\" ");
            //Console.WriteLine($"the min Value is  \" {arr[0]} \" ");

            //third way 

            //int Max01= arr[0];
            //int Min01= arr[0];

            //for (int i = 1; i < arr.Length; i++)
            //{

            //    if (arr[i] > Max01)
            //    {

            //        Max01 = arr[i];

            //    }
            //    else if (arr[i]<Min01)
            //    {
            //        Min01 = arr[i];
            //    }
            //}

            //Console.WriteLine($"the max Value is  \" {Max01} \" ");
            //Console.WriteLine($"the min Value is  \" {Min01} \" ");



            #endregion

            #region Q5
            //5 - Write a program in C# Sharp to find the second largest element in an  array.
            //int[] arr = new int[] { 2, 4, 2, 6, 6, 8, 9, 10, 30, 59, 58 };

            //first way  

            //Array.Sort(arr);
            //Console.WriteLine($"the second largest element is {arr[arr.Length-2]}");


            //second way 

            //int Max=arr[0];
            //int Min=arr[0];
            //int secondMax = 0;


            //for (int i = 1; i < arr.Length; i++)
            //{


            //    if (arr[i] > Max)
            //    {

            //        Min = Max;
            //        Max= arr[i];


            //    }
            //    else if (arr[i] < Max && arr[i]>Min)
            //    {
            //        secondMax = arr[i];
            //    }


            //}

            //Console.WriteLine($"second largest element = {secondMax} ");

            #endregion


            #region Q6



            //6 -.Consider an Array of Integer values with size N, having values as in this Example

            //Console.WriteLine("enter the array Size ");
            //int.TryParse(Console.ReadLine(), out int size);

            //int[] arr=new int[size];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine($"enter element {i+1}");
            //    int.TryParse(Console.ReadLine(), out arr[i]);
            //}

            //// check on the longest distance between  the same value 
            //int longdistance = 0;
            //int fIndex = -1;
            //int lIndex = -1;
            //int repetednumber=0 ;

            //for (int i = 0; i < arr.Length; i++)    // actual numbers 
            
            //{

            //    for (int j = i+1; j < arr.Length; j++) {    // to compare with next value 
                
            //     if (arr[i] == arr[j])
            //        {

            //            int dis = j - i - 1;
            //            if (dis > longdistance)
            //            {
            //                longdistance = dis;
            //                fIndex= i;  
            //                lIndex = j; 
            //                repetednumber = arr[i];
            //            }


            //        }
                
                
                
                
            //    }
            
            
            //}


            //if (longdistance > 0)
            //{
            //    Console.WriteLine($"The longest distance is: {longdistance}");
            //    Console.WriteLine($"Between number {repetednumber} at index {fIndex+1} and index {lIndex+1}");
            //}
            //else
            //{
            //    Console.WriteLine("No repeated numbers found.");
            //}

            #endregion





        }
    }
}
