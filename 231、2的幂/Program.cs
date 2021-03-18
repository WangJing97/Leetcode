using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _231_2的幂
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public static bool IsPowerOfTwo(int n)
        {
            if (n <= 0) 
            {
                return false;
            }
            int count = 0;
            for (int i = 0; i < 32; i++)
            {
                if ((n & 1) == 1) 
                {
                    count++;
                }
                n >>= 1;
            }
            return count == 1;
        }
        public static bool IsPowerOfTwo1(int n)
        {
            return n > 0 && ((n & (n - 1)) == 0);
        }

    }
}
