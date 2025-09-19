using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlternatePainDifferenceProblem
{
    internal class Program
    {
        static int[] AlternatePainDifferenceProblem(int[] arr)
        {
            // Implement the logic for the Alternate Pain Difference Problem here.
            // This is a placeholder for the actual implementation.
            int[] a = new int[arr.Length/2];
            for(int i = 0; i < arr.Length-1; i+=2)
            {
                a[i/2] = arr[i] - arr[i + 1];
            }   
            return a;
        }
        static void Main(string[] args)
        {
            int[] arr = { 5, 2, 9, 4, 7, 3 };
            int[] output = AlternatePainDifferenceProblem(arr);
            foreach(var item in output)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
