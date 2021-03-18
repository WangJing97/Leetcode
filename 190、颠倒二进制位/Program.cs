using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _190_颠倒二进制位
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static uint reverseBits(uint n)
        {
            uint res = 0;
            for (int i = 0; i < 32; i++)
            {
                uint temp = (n & 1);
                res = (res << 1) + temp;
                n >>= 1;
            }
            return res;
        }
    }
}
