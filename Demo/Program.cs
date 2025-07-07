using System.Globalization;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region 1D-Array

            //array is adata structure 
            // array is a single varible allow  to store multiuble data  that have the same type 
            // array [class referance type ]
            // 1- fixed size 
            //2- zero based indexing 
            //3- same data type 

            // 1 dimantioal decleration 

            //int[] arr = new int[10];   
            //ClR create refernace in stack [4-8 byte ]
            // that referance to adress  in anoter object in heap 
            // CLR create object at heap contguesly has same data type with 40 byte 
            // feferane data type has adress of index zero


            //int[]arr02=new int[5] {1,2,3,4,5};

            //int[] arr03=new int[] {1,2,3,4,5};

            //int[] arr04 = { 1, 2, 3, 4, 5 };

            //int[] arr05 = [1,2,3,4,5];


            // advanges of array : 
            // access time => can arrive to any element by one step  [byte * index + adress ]  (o(1));

            //disadvages ==> fixed Size


            // retreving data 

            //for (int i = 0; i < arr04.Length; i++) {

            //    Console.WriteLine(arr04[i]);


            //}


            #endregion



            #region multi Dimentional 


            #region 2D array - rectanglur

            //consiting of row and cloumns 
            // numbers of cloumns = numbers of cloumns in another (subarray)  [all rows have the same numbers of columns ]
            // called SQL [tables ]
            // the defaule vlaue of array of data type is [zero] for int 

            //int[,] number = new int[2, 5];
            //int[,] numbers = new int[2, 5]  ==> size 40 byte
            //{
            //    {1,2,3,4,5 },


            //    {6,7,8,9,10 }
            //};


            //Console.WriteLine(numbers[0,4]);
            //Console.WriteLine(numbers[1,2]);

            //foreach(int x in numbers)
            //{
            //    Console.WriteLine(x); 
            //}


            //for(int i = 0; i < 2; i++)
            //{

            //    for (int j = 0; j < 5; j++)
            //    {
            //        Console.WriteLine(numbers[i,j]);
            //    }
            //}





            uint[,] dgrees = new uint[2,5];

            //Console.WriteLine( dgrees.Length + " " + dgrees.Rank );
            //bool isparsed;


            //for (int i = 0; i < dgrees.GetLength(0); i++) {

            //    Console.WriteLine($" plese enter student  number {i+1}");

            //     for (int j =0;j < dgrees.GetLength(1); )
            //    {
            //        Console.WriteLine($"enter the subject number :: {j+1}");

            //      isparsed= uint.TryParse(Console.ReadLine(),out dgrees[i,j]);   


            //        if (isparsed && dgrees [i,j]<= 100)
            //        {
            //            j++;
            //        }




            //    }



            //}



            // retrive array with one loop 

            // 0 ,1,2,3,4,5,6,7,8,9[10 elements]  
            // rows / cloumns[5]  
            // 0 0 0 0 0  1, 1,1,1,


            //for (int i = 0; i < dgrees.Length; i++)

            //{

            //    Console.WriteLine(dgrees[i/dgrees.GetLength(1),i%dgrees.GetLength(1)]);
            //}




            #endregion



            #region jagged array 
            // it is 1D array  (array of arrays )
            //each element refence to obj of array in heap 
            // numbers of cloumns in each row  not !=


            //int[][] marks = new int[2][];

            //marks[0] = new int[]{ 9, 8, 3 };
            //marks[1] = new int[] { 7, 2,11 };



            //for (int i = 0; i < marks.Length; i++)
            //{
            //    for (int j = 0; j < marks[i].Length; j++)
            //    {
            //        Console.WriteLine(marks[i][j]);

            //    }


            //}




            #endregion


            #endregion




            #region array_methods

            /// class member methods [static methods ]
            /// Array.Sort();  // order by acsending
            /// Array.Copy();   // copy the source array in , destination array , length => number of element  satrt from first element to spacefic length 
            ///   Array.Clear(); /// delete all value in arry  to default vlaue [0] 
            /// Array.ConstrainedCopy();   // take source array  , start index of source , destinaion aray , destinaion index (start place) , length (number of elemnt))
            /// Array.IndexOf();  //return the endex of value 

            // class obj methods

            //int[] arr05 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            //int[] arr06 = new int[10];
            //arr05.CopyTo(arr06 ,0);


            //foreach (int i in arr05) {

            //    Console.WriteLine(i);
            
            //}


            



            #endregion





        }
    }
}
