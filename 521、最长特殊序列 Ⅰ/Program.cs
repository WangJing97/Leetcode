using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _521_最长特殊序列_Ⅰ
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public int FindLUSlength(string a, string b)
        {
            //最长的字符串，长的一定是
            if (a.Length > b.Length) return a.Length;
            if (b.Length > a.Length) return b.Length;
            if (a == b) return -1;
            return a.Length;
        }
    }
}
