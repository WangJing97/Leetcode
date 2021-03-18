using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _441_排列硬币
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public int ArrangeCoins(int n)
        {
            int level = 0;
            while (n >= 0) 
            {
                level++;
                n = n - level;
            }
            return level - 1;
        }
    }
}
