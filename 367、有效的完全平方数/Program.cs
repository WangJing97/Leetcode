using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _367_有效的完全平方数
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 25 * 25;
            bool b = IsPerfectSquare(num);
            Console.WriteLine(b);
            Console.WriteLine("成功");
            Console.ReadKey();
        }
        //超时间
        public static bool IsPerfectSquare(int num)
        {
            //最暴力的方法一个一个试
            int i = 1;
            while (i * i < num)
            {
                i += 1;
            }
            return i * i == num;
        }
        public bool IsPerfectSquare1(int num)
        {
            //利用二分法找，再加上完全平方数的性质：它的个位数都是0，1，4，5，6，9
            //先利用完全平方性质
            int a = num % 10;
            if (a != 0 && a != 1 && a != 4 && a != 5 && a != 6 && a != 9) 
            {
                return false;
            }
            int left = 0;
            int right = num;
            while (left <= right) 
            {
                int mid = left + (right - left) / 2;
                if ((long)mid * mid == num)
                {
                    return true;
                }
                else if (num > (long)mid * mid) 
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return false;
        }
        public bool IsPerfectSquare2(int num)
        {
            //利用公式
            //1+3+5+7+...+(2n-1)=n^2
            int i = 1;
            while (num > 0) 
            {
                num -= i;
                i += 2;
            }
            return num == 0;
        }
        public bool IsPerfectSquare3(int num)
        {
            //?牛顿迭代法
            if (num < 2)
            {
                return true;
            }
            long x = num / 2;
            while (x * x > num)
            {
                x = (x + num / x) / 2;
            }
            return (x * x == num);
        }

    }

}
