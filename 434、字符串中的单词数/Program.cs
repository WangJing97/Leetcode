using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _434_字符串中的单词数
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Hello, my name is John";
            int res = CountSegments(s);
        }
        public static int CountSegments(string s)
        {
            //找空格
            int count = 0;
            bool lastIsBlank = true;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                {
                    lastIsBlank = true;
                }
                else
                {
                    if (lastIsBlank)
                    {
                        count++;
                    }
                    lastIsBlank = false;
                }
            }
            return count;
        }
        public static int CountSegments1(string s)
        {
            int count = 0;
            foreach (string item in s.Split(' '))
            {
                if (string.IsNullOrEmpty(item)) 
                {
                    continue;
                }
                count++;
            }
            return count;
        }

    }
}
