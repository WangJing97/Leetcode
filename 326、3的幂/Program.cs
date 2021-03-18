using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _326_3的幂
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        //循环
        public bool IsPowerOfThree(int n)
        {
            if (n < 1)
            {
                return false;
            }

            while (n % 3 == 0)
            {
                n /= 3;
            }

            return n == 1;
        }
        //递归
        public bool IsPowerOfThree1(int n)
        {
            if (n == 1)
            {
                return true;
            }
            else if (n == 0) 
            {
                return false;
            }
            return IsPowerOfThree1(n / 3) && n % 3 == 0;
        }
        //偷鸡解法 把int最大的3次方求出来和取余
        public bool IsPowerOfThree2(int n)
        {
            if (n == 1)
            {
                return true;
            }
            if (n <= 0) 
            {
                return false;
            }
            return 1162261467 % n == 0;
        }
        //换底公式
        public bool IsPowerOfThree3(int n)
        {
            if (n == 1)
            {
                return true;
            }
            if (n <= 0)
            {
                return false;
            }
            double a = Math.Log10(n) / Math.Log10(3);
            return a == Math.Floor(a);
        }

    }
}
