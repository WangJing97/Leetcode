using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _520_检测大写字母
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public bool DetectCapitalUse(string word)
        {
            int count = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (char.IsUpper(word[i])) 
                {
                    count++;
                }
            }
            return count == word.Length || count == 0 || count == 1 && char.IsUpper(word[0]);
        }
    }
}
