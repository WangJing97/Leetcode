using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _507_完美数
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public bool CheckPerfectNumber(int num)
        {
            /*
            28 i <= Math.Sqrt(num)=5

            i = 2 : 2+28/2=16
            i = 4 : 4+28/4=11
            结束了
             */
            if (num == 1) return false;

            int sum = 0;
            //不能超过Math.Sqrt(num)
            for (int i = 2; i <= Math.Sqrt(num); i++) 
            {
                if (num % i == 0)  
                {
                    sum += i + num / i;
                }
            }
            sum++;

            return sum == num;
        }
    }
}
