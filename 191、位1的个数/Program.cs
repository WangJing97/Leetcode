using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _191_位1的个数
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public static int HammingWeight(uint n)
        {
            int count = 0;
            uint mask = 1;
            for (int i = 0; i < 32; i++)
            {
                if ((n & mask) != 0)
                {
                    count++;                   
                }
                mask <<= 1;
            }
            return count;
        }

        public static int HammingWeight1(uint n)
        {
            int res = 0;
            while (n != 0) 
            {
                //消除末尾1的方法
                n &= (n - 1);
                res++;
            }
            return res;
        }
    }
}
