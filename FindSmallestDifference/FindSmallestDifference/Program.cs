using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindSmallestDifference
{
    class Program
    {

        public static int GetSmallestElement(int[] arrOne, int[] arrTwo)
        {
            //Declare an array of the same length as one of the two arrays
            int[] arr = new int[arrOne.Length];
            int smallest = arr[0];  // declare the small

            // using the the second array elements subtracting from the first array elements
            for (int j = 0; j < arrOne.Length; j++)
            {

                arr[j] = arrOne[j] - arrTwo[j];  // put the difference in the arr array.

            }

           
            for (int k = 0; k < arr.Length; k++)
            {
                if (smallest > arr[k])
                {
                    //Compare if smallest is grater than any element in the array.
                    smallest = arr[k];
                }

            }

            return smallest;
        }
        static void Main(string[] args)
        {
        
         //Declaring all the arrays going to be used in this solution
         
            int [] arr = new int [10]; // all the differences will be stored in this array

            int[] arr1 =  new int[10];  // first array which will be deducted from
            int[] arr2 = new int[10];   // Second array whose elements will be subtracting from the elements
                                        // of the first array elements
            Console.WriteLine("Enter 10 numbers in array:");   // get the first 10 integers using the loop
                                                                   
            for (int i = 0; i < 10; i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Enter 10 numbers in array:");  // Getting the second 10 integers - looping

            for (int i = 0; i < 10; i++)
            {
                arr2[i] = Convert.ToInt32(Console.ReadLine());
            }

       

            // Display the smallest element in the array
            Console.WriteLine("smallest is " + GetSmallestElement(arr1, arr2).ToString());
            Console.ReadLine();
          

        }


    }

 
}
