using System;
namespace Reverse
{
    class Display
    {
        static void Main(string[] args){
            Console.WriteLine("How many elements do you want to store in the array?");
            int arraySize = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[arraySize];

            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Enter element "+(i+1)+":");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            int[] b = new int[a.Length];
            int j = a.Length; 
            for (int i = 0; i < a.Length; i++) { 
            b[j - 1] = a[i]; 
            j = j - 1; 
             } 
  
            // printing the reversed array 
            Console.WriteLine("Reversed array is: \n"); 
            for (int k = 0; k < a.Length; k++) { 
                Console.Write(b[k]+" "); 
            } 

        }
    }
}