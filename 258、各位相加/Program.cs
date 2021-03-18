using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _258_各位相加
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 38;
            int res = addDigits1(num);
            Console.WriteLine(res);
        }
        public static int addDigits(int num)
        {
            //达到条件退出
            if (num < 10) 
            {
                return num;
            }
            int next = 0;
            //38举例
            while (num != 0) 
            {
                next = next + num % 10;//38%10=8 取余next=8+0=8
                num /= 10;//把num变成第二位3
                //不等于0循环
                //3%10=3 next=3+8=11 num=3
                //num=3/10=0
                //退出循环进入递归 next作为下次递归带入
                //num=11 next=0
                //next=0+11%10=1
                //num=11/10=1
                //循环
                //next=1+1%10=1+1=2
                //num=1/10=0
                //下次递归
                //num=2 next=0
            }
            return addDigits(next);
        }
        public static int addDigits1(int num)
        {
            //递归比较好理解
            while (num >= 10) 
            {
                int next = 0;
                while (num != 0) 
                {
                    next = next + num % 10;
                    num /= 10;
                }
                num = next;
            }
            return num;
        }
        public static int addDigits2(int num)
        {
            /*
            数根
            数根是将一正整数的各个位数相加（即横向相加），
            若加完后的值大于10的话，则继续将各位数进行横向相加直到其值小于十为止[1]，
            或是，将一数字重复做数字和，直到其值小于十为止，则所得的值为该数的数根
            例如：2568->2+5+6+8=21->2+1=3，则3是它的数根
            总结：
            n 是 0 ，数根就是 0。
            n 不是 9 的倍数，数根就是 n 对 9 取余，即 n mod 9。
            n 9 的倍数，数根就是 9。
            这题可以：
            可以把两种情况统一起来，我们将给定的数字减 1，相当于原数整体向左偏移了 1，
            然后再将得到的数字对 9 取余，最后将得到的结果加 1 即可。
            原数是 n，树根就可以表示成 (n-1) mod 9 + 1

            原数：1 2 3 4 5 6 7 8 9 10 11 12 13
            偏移：0 1 2 3 4 5 6 7 8  9 10 11 12
            取余：0 1 2 3 4 5 6 7 8  0  1  2  3
            数根：1 2 3 4 5 6 7 8 9  1  2  3  4
            */
            return (num - 1) % 9 + 1;
        }

    }
}
