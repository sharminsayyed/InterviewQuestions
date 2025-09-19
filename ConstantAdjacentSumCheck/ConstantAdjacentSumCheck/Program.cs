using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstantAdjacentSumCheck
{
    internal class Program
    {
        static bool HasConstantAdjacentSum(int[] arr)
        {
            if (arr.Length < 2)
                return true;
            int exp = arr[0] + arr[1];
            for(int i =0; i< arr.Length - 1; i++)
            {
                int chk = arr[i] + arr[i + 1];
                if (chk != exp)
                    return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            int[] ints = { 2,2,2,2 };
            Console.WriteLine(HasConstantAdjacentSum(ints));
        }
    }
}
