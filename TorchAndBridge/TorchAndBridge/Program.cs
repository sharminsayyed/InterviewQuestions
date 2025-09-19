using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorchAndBridge
{
    internal class Program
    {
        static int torchBrigde(int[] arr)
        {
            // 2 people one say and one come back with the torch
            //[1,2,5,10]
            Array.Sort(arr);
            if(arr.Length < 2)
            {
                return arr[0];
            }
            if(arr.Length == 2)
            {
                return arr[0];
            }

            int time = 0;
            time += arr[1];// (1,2) cross
            time += arr[0];// (1) back
            time += arr[3];// (5,10) cross
            time += arr[1];// (2) back
            time += arr[1];// (1,2) cross again


            return time;
        }
        static void Main(string[] args)
        {
            int[] arr = {2,1,3,5};
            int res = torchBrigde(arr);
            Console.WriteLine(res);
        }
    }
}
