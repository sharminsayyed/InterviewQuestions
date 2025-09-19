using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverStirng
{
    class Program
    {
        static string ReverStirng(string s)
        {
            char[] arr = s.ToCharArray();
            int left = 0, right = arr.Length - 1;
            while ( left < right){
                char temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;
                left++;
                right--;
                   
            }
            return new string(arr);
        }
        static void Main(string[] args)
        {
            string input = "sharmin";
            Console.WriteLine($"revere string {ReverStirng(input)}");

            Console.ReadLine();
        }
    }
}
