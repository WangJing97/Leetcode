using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _344_反转字符串
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public void ReverseString(char[] s)
        {
            //C#?
            for (int left = 0, right = s.Length - 1; left < right; left++, right--) 
            {
                (s[left], s[right]) = (s[right], s[left]);
            }

        }
        public void ReverseString1(char[] s)
        {
            Array.Reverse(s);
        }
        public void ReverseString2(char[] s)
        {
            if (s == null || s.Length <= 0) 
            {
                return;
            }
            char temp = s[0];
            for (int i = 0; i < s.Length / 2; i++) 
            {
                temp = s[i];
                s[i] = s[s.Length - 1 - i];
                s[s.Length - 1 - i] = temp;
            }
        }
        public void ReverseString3(char[] s)
        {
            //利用位运算，异或
            //异或满足交换律和结合律
            //x ^ x == 0
            //x ^ 0 == x
            //相同为0，和零异或还是本身
            //            a           b
            //初始值       a           b
            //a=a^b      a^b          b
            //b=a^b      a^b        a^b^b=a
            //a=a^b     a^b^a=b       a
            //结果         b           a
            for (int i = 0; i < s.Length / 2; i++)
            {
                s[i] ^= s[s.Length - 1 - i];
                s[s.Length - 1 - i] ^= s[i];
                s[i] ^= s[s.Length - 1 - i];
            }
        }

    }
}
