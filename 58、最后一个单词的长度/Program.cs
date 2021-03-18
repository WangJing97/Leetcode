using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _58_最后一个单词的长度
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Hello World";
            int res = LengthOfLastWord(s);
            Console.WriteLine(res);
            Console.ReadKey();
        }
        public static int LengthOfLastWord(string s)
        {
            if (s == null || s.Length == 0)
            {
                return 0;
            }
            //如果末尾是' '就继续往后找
            int i = s.Length - 1;
            while (i >= 0 && s[i] == ' ') 
            {
                i--;
            }
            //如果末尾不是' '就开始计数
            int count = 0;
            while (i >= 0 && s[i] != ' ') 
            {
                i--;
                count++;
            }
            return count;
        }
    }
}
