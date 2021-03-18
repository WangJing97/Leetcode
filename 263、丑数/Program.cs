using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _263_丑数
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public static bool IsUgly(int num)
        {
            if (num <= 0) 
            {
                return false;
            }
            int[] factors = new int[] { 2, 3, 5 };
            foreach (int item in factors) 
            {
                //分别用丑数的因子去除
                while (num % item == 0)
                {
                    $
                    num /= item;
                }
            }
            return num == 1;
        }
        public static bool IsUgly1(int num)
        {
            //利用递归往下找
            if (num == 0) return false;
            if (num == 1) return true;
            if (num % 2 == 0) return IsUgly1(num / 2);
            if (num % 3 == 0) return IsUgly1(num / 3);
            if (num % 5 == 0) return IsUgly1(num / 5);
            return false;
        }
    }
}
