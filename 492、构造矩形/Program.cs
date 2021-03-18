using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _492_构造矩形
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public int[] ConstructRectangle(int area)
        {
            //把一个边固定，另一个边不断的变动 
            int L = area;
            int W = 1;
            for (int i = 1; i <= area / i; i++) 
            {
                //首先要整除
                //还要长度 L 和宽度 W 之间的差距应当尽可能小
                //如果差值要比L - W小的话 更新赋值
                if (area % i == 0 && (area / i - i) < (L - W)) 
                {
                    L = area / i;
                    W = i;
                }
            }
            return new int[] { L, W };
        }
    }
}
