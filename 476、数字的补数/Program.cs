using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _476_数字的补数
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = FindComplement(5);

        }
        public static int FindComplement(int num)
        {

            // 111 ->1000-1=111
            //-101
            // 010 ^方法或者相减    
            //根据题意，只要和1111相减就可以了
            //long temp = 1;
            ////为了得到1000
            //while (temp <= num)
            //{
            //    //0010 - 2
            //    //0100 - 4
            //    temp <<= 1;
            //}
            //return (int)(temp - 1 - num);

            long temp = 1;
            while (temp <= num)
            {
                temp <<= 1;
            }
            return (int)((temp - 1) ^ num);
        }
    }
}
