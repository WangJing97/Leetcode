using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _389_找不同
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public char FindTheDifference(string s, string t)
        {
            //用一个列表
            //先把两个字符串连接上，有就添加，没有就加上
            List<char> list = new List<char>();
            char[] chars = new char[] { };
            chars = s.Concat(t).ToArray();
            for (int i = 0; i < chars.Length; i++) 
            {
                if (list.Contains(chars[i])) 
                {
                    list.Remove(chars[i]);
                }
                else
                {
                    list.Add(chars[i]);
                }
            }
            return (char)list.ToArray()[0];
        }
        public char FindTheDifference1(string s, string t)
        {
            //a ^ a=0; 任何数字和自己异或都是0
            //a ^ 0 = a; 任何数字和0异或还是他自己
            //a ^ b ^ a = a ^ a ^ b 异或运算具有交换律
            //因为s和t合并之后，偶数个的字符通过异或都会变为0，奇数个的字符异或之后还是他自己，我们只需要把合并的字符全部异或一遍即可
            char[] chars = s.Concat(t).ToArray();
            char res = (char)0;
            foreach (char item in chars)
            {
                res ^= item;
            }
            return res;
        }

    }
}
