using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _509_斐波那契数
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = Fib1(3);

        }

        public static int Fib(int n)
        {
            //递归
            //根据公式F(n) = F(n - 1) + F(n - 2)
            if (n < 2) 
            {
                return n;
            }
            return Fib(n - 1) + Fib(n - 2);
        }
        public static int Fib1(int n)
        {
            //迭代
            //从最底层到结果
            if (n < 2)
            {
                return n;
            }
            int firstNum = 0;
            int secondNum = 1;
            int curRes = 0;
            for (int i = 0; i < n - 1; i++) 
            {
                curRes = firstNum + secondNum;
                firstNum = secondNum;
                secondNum = curRes;
            }
            return curRes;
        }
        public static int Fib2(int n)
        {
            double f1 = (1 + Math.Sqrt(5)) / 2;
            double f2 = (1 - Math.Sqrt(5)) / 2;
            //Round取整
            return (int)Math.Round((Math.Pow(f1, n) - Math.Pow(f2, n)) / Math.Sqrt(5));
        }


    }
}
