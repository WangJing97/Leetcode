using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _172_阶乘后的零
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 125;
            int res = TrailingZeroes(i);
            Console.WriteLine(res);
            Console.ReadKey();
        }
        public static int TrailingZeroes(int n)
        {
            //本题思路：理解阶乘的0是从哪里来的？
            //两个数相乘末尾有0，那么其中的因子必定是2和5
            //这里2的个数必定要比5多，所以问题转变成看5有多少，要做到不漏掉5
            //举例125这个数，首先125/5=25这个是计算有多少5的倍数
            //但是这样是不够的像25 50 75这样25的倍数会提供2个因子5，同样的125 250这些125的倍数会提供3个
            int res = 0;
            long divisor = 5;
            while (divisor <= n)
            {
                res += (int)(n / divisor);
                divisor *= 5;
            }
            return res;
        }
    }
}
