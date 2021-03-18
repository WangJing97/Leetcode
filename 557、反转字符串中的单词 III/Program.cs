using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _557_反转字符串中的单词_III
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public string ReverseWords(string s)
        {
            if (s == null || s.Length == 0) return s;

            StringBuilder result = new StringBuilder();

            foreach (string SplitWord in s.Split())
            {
                for (int i = SplitWord.Length - 1; i >= 0; i--)  
                {
                    result.Append(SplitWord[i]);        
                }
                result.Append(' ');
            }
            result.Length = result.Length - 1;
            return result.ToString();
        }
    }
}
