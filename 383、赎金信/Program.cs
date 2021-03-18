using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _383_赎金信
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public bool CanConstruct(string ransomNote, string magazine)
        {
            //键为字符，值为字符对应的个数
            //找就行
            if (ransomNote.Length > magazine.Length) 
            {
                return false; 
            }
            Dictionary<char, int> dic = new Dictionary<char, int>();
            foreach (char c in magazine)
            {
                if (!dic.ContainsKey(c))
                {
                    dic[c] = 1;
                }
                else
                {
                    dic[c]++;
                }
            }
            foreach (char c in ransomNote)
            {
                if (!dic.ContainsKey(c))
                {
                    return false;
                }
                else
                {
                    if (dic[c] > 0) 
                    {
                        dic[c]--;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
