using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _459_重复的子字符串
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public bool RepeatedSubstringPattern(string s)
        {
            //把一个两个一直到一半的字符重复，在比较原来的字符
            int len = s.Length;
            for (int i = len / 2; i >= 1; i--) 
            {
                //要能整除再能继续
                if (len % i == 0) 
                {
                    int repeat = len / i;
                    string substring = s.Substring(0, i);
                    StringBuilder sb = new StringBuilder();
                    for (int j = 0; j < repeat; j++)
                    {
                        sb.Append(substring);
                    }
                    if (sb.ToString().Equals(s)) 
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
