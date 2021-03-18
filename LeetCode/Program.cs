using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07Reverse_Integer
{
    class Program
    {
        #region 题目
        //给出一个 32 位的有符号整数，你需要将这个整数中每位上的数字进行反转。

        //示例 1:

        //输入: 123
        //输出: 321
        //示例 2:

        //输入: -123
        //输出: -321
        //示例 3:

        //输入: 120
        //输出: 21
        //注意:

        //假设我们的环境只能存储得下 32 位的有符号整数，则其数值范围为 
        //[−2^31,  2^31 − 1]。请根据这个假设，如果反转后整数溢出那么就返回 0。 
        #endregion
        static void Main(string[] args)
        {
            int result = doReverse(1266);
            Console.WriteLine(result);
            Console.ReadKey();
        }
        public static int doReverse(int x)
        {   
            long sum = 0;
            while (x != 0)
            {
                sum = sum * 10 + x % 10;
                x /= 10;
                //添加判断
                if (sum > int.MaxValue || sum < int.MinValue)
                {
                    return 0;
                }
            }
            return (int)sum;
        }

    }
}
