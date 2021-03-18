using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _461_汉明距离
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public int HammingDistance(int x, int y)
        {
            int result = 0;
            while (x != 0 || y != 0) 
            {
                //拿到最后一位
                int bx = x & 1;
                int by = y & 1;
                if (bx != by) 
                {
                    result++;
                }
                x >>= 1;
                y >>= 1;
            }
            return result;
        }
        public int HammingDistance1(int x, int y)
        {
            int result = 0;
            int t = x ^ y;//使用异或把不同的变成1
            while (t > 0) 
            {
                result += t & 1;
                t >>= 1;
            }
            return result;
        }

    }
}
