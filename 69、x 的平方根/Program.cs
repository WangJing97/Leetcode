using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _69_x_的平方根
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 8;
            int res = MySqrt(x);
            Console.WriteLine(res);
            Console.ReadKey();
        }
        public static int MySqrt(int x)
        {
            if (x == 1)
            {
                return 1;
            }
            long left = 0;
            //平方可以在一半开始找
            long right = x / 2;
            long mid;
            while (left <= right) 
            {
                mid = (left + right) / 2;
                //防止溢出
                if (mid * mid > int.MaxValue)
                {
                    right = mid - 1;
                }
                if (mid * mid == x)
                {
                    return (int)mid;
                }
                else if (mid * mid > x)
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }

            }
            return (int)right;
        }
        
    }
}
