using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _541_反转字符串_II
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public string ReverseStr(string s, int k)
        {
            /*
            理解题目意思
            s = "abcdefg", k = 2

            每隔4个，前两个2个反转
            bacdefg

            efg不足4个但是大于2个，反转前2个
            bacdfeg

            可以进行每2k循环 并且判断剩余的字符的多少来进行相应的操作
            */
            char[] c = s.ToCharArray();
            for (int i = 0; i < s.Length; i += 2 * k) 
            {
                int start = i;
                int end = Math.Min(i + k - 1, c.Length - 1);
                while (start < end) 
                {
                    char temp = c[start];
                    c[start++] = c[end];
                    c[end--] = temp;
                }
            }
            return new string(c);
        }
    }
}
