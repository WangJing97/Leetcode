using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _202_快乐数
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public bool IsHappy(int n)
        {
            HashSet<int> dic = new HashSet<int>();
            while (n != 1) 
            {
                int cur = n;
                int sum = 0;
                //每个数的平方相加
                while (cur != 0) 
                {
                    sum += (cur % 10) * (cur % 10);
                    cur /= 10;
                }
                if (dic.Contains(sum)) 
                {
                    return false;
                }
                dic.Add(sum);
                n = sum;
            }
            return true;
        }
    }
}
