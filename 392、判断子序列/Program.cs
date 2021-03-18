using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _392_判断子序列
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public bool IsSubsequence(string s, string t)
        {
            //判断s 是不是t的子列
            //双指针
            //相等s往后移动一格，不相等t往后移动
            //最后判断s的指针是否能到头
            int i = 0, j = 0;
            while (i < s.Length && j < t.Length) 
            {
                if (s[i] == t[j]) 
                {
                    i++;
                }
                j++;
            }
            return i == s.Length;
        }
        public bool IsSubsequence1(string s, string t)
        {
            int index = -1;
            foreach (char c in s.ToArray()) 
            {
                //index表示上次查找的位置
                index = t.IndexOf(c, index + 1);
                if (index == -1) 
                {
                    return false;
                }
            }
            return true;
        }

    }
}
