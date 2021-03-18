using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _374_猜数字大小
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    /** 
 * Forward declaration of guess API.
 * @param  num   your guess
 * @return 	     -1 if num is lower than the guess number
 *			      1 if num is higher than the guess number
 *               otherwise return 0
 * int guess(int num);
 */

    public class Solution : GuessGame
    {
        public int GuessNumber(int n)
        {
            //直接一个一个试
            //太慢了
            for (int i = 1; i < n; i++)
            {
                if (guess(i) == 0)
                {
                    return i;
                }
            }
            return n;
        }
        public int GuessNumber1(int n)
        {
            //本质还是在找一个一个数字，二分法
            int low = 1;
            int high = n;
            while (low <= high) 
            {
                int mid = low + (high - low) / 2;
                int res = guess(mid);
                if (res == 0)
                {
                    return mid;
                }
                else if (res < 0) 
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
            return -1;
        }

    }
}
