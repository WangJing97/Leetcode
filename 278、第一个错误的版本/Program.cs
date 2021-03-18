using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _278_第一个错误的版本
{
    class Program
    {
        static void Main(string[] args)
        {
        }

    }
    public class Solution
    {
        bool IsBadVersion(int version);
        public int FirstBadVersion(int n)
        {
            /*
            二分法：
            利用题意排列只有是前面是好的后面的是坏的
            举例：
            情景一：
            1 2 3 4 5 6 7
            G G G G B B B
            |     |     |
            L     M     R
            判断isBadVersion(mid)返回false，这时就是从左到这里全部是正确的，
            所以下一步left=mid+1
            情景二：
            1 2 3 4 5 6 7
            G G G B B B B
            |     |     |
            L     M     R
            判断isBadVersion(mid)返回true，这时mid右侧（不包括自身）的所有版本的不可能是第一个错误的版本。
            所以下一步right=mid
            最后，当左右相等时就可以返回left了
            为了防止溢出通常这么算中间的mid = left + (right - left) / 2;
             */
            int left = 1;
            int right = n;
            while (left < right) 
            {
                int mid = left + (right - left) / 2;
                if (IsBadVersion(mid)) 
                {
                    right = mid;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return left;
        }
    }
}
