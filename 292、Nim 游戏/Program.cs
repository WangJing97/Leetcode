using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _292_Nim_游戏
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        //会超时
        public bool CanWinNim(int n)
        {
            //递归
            //先写出赢了的情况
            if (n == 0) 
            {
                return false;
            }
            if (n <= 3) 
            {
                return true;
            }
            //考虑可能的几种情况
            //自己拿走1 2 3个之后在判断无论对方拿走几个，剩下的你是不是稳赢
            for (int i = 0; i <= 3; i++)
            {
                //不管对手怎么拿，你都稳赢
                if (CanWinNim(n - i - 1) && CanWinNim(n - i - 2) && CanWinNim(n - i - 3)) 
                {
                    return true;
                }
            }
            //否则就是你输了
            return false;
        }
        //学一下动态规划
        public bool CanWinNim1(int n)
        {
            //列一个表
            //1 2 3 4 5 6 7 8
            //T T T F T T T F
            //表的意思就是当前还剩的数目，你会不会赢，之前有关系
            //往前看三个，其中只要有一个是F的，这个位置上的数就是T
            if (n < 4) 
            {
                return true;
            }
            bool[] b = new bool[n + 1];
            Boolean
            //b[0] = false;
            b[1] = true;
            b[2] = true;
            b[3] = true;
            for (int i = 4; i <= n; i++)
            {
                b[i] = !b[i - 1] || !b[i - 2] || !b[i - 3];
            }
            return b[n];
        }
        public bool CanWinNim2(int n)
        {
            //注意观察以上的数组其实最多用了4个，可以简化
            if (n < 4)
            {
                return true;
            }
            bool[] b = new bool[4];
            b[0] = false;
            b[1] = true;
            b[2] = true;
            b[3] = true;
            for (int i = 4; i <= n; i++)
            {
                b[i % 4] = !b[(i - 1) % 4] || !b[(i - 2) % 4] || !b[(i - 3) % 4];
            }
            return b[n % 4];
        }
        //观察数组就行，有规律
        public bool CanWinNim3(int n)
        {
            //3 个 true ，1 个 false ，由此往复。
            return n % 4 != 0;
        }

    }
}
