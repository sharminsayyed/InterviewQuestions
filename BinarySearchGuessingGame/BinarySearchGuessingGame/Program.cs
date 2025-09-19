using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchGuessingGame
{
    internal class Program
    {
        static int guessgame(int target)
        {
            int low = 1, high = 1023, attempt = 0;
            while(low < high)
            {
                attempt++;
                if(attempt > 10)
                    return -1;
                int mid = low + (high - low) / 2;
                if (mid == target)
                    return attempt;
                else if (mid < target)
                    low = mid + 1;
                else if (mid > target)
                    high = mid - 1;

            }
            return -1;
        }
        static void Main(string[] args)
        {
            int target = 700;
            int res = guessgame(target);
            if(res == -1)
                Console.WriteLine("not found in 10 attempst also");
            else
                Console.WriteLine("found in " + res + " attempts");
        }
    }
}
