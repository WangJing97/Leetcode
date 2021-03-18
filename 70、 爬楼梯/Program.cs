using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _70__爬楼梯
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = ClimbStairs(4);
            Console.WriteLine(res);
            Console.ReadKey();
        }
        public static int ClimbStairs(int n)
        {
            /*
            1、可从前面0到第一个楼梯
            0 1 1 1 1 1   
              1           
            
            2、第二个阶梯可从0来也可以从1来
            0 1 1 1 1 1
              1 2

            3、第三个可以从第一个和第二个来
            0 1 1 1 1 1
              1 2 3
            
            4、注意第四个它可以从第二个和第三个来，另外注意想要到达第二和第三个要2步和3步，所以到第四个需要2+3步
            0 1 1 1 1 1
              1 2 3 5

            ....以此类推
            这叫dp算法。
            */
            if (n <= 0)
            {
                return 0;
            }
            if (n == 1)
            {
                return 1;
            }
            if (n == 2)
            {
                return 2;
            }
            int[] dp = new int[n + 1];
            dp[0] = 0;
            dp[1] = 1;
            dp[2] = 2;
            for (int i = 3; i <= n; i++) 
            {
                dp[i] = dp[i - 1] + dp[i - 2];
            }
            return dp[n];
        } 
    }
}
