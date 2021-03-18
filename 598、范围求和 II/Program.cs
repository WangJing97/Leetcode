using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _598_范围求和_II
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        public int MaxCount(int m, int n, int[][] ops)
        {
            //找重叠的
            foreach (int[] item in ops)
            {
                m = Math.Min(m, item[0]);
                n = Math.Min(n, item[1]);
            }
            return m * n;
        }
    }
}
