using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _387_字符串中的第一个唯一字符
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public int FirstUniqChar(string s)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();
            //统计每个字母的数量
            for (int i = 0; i < s.Length; i++)
            {
                if (dic.ContainsKey(s[i])) 
                {
                    dic[s[i]] += 1;
                }
                else
                {
                    dic.Add(s[i], 1);
                }
            }
            for (int i = 0; i < s.Length; i++)
            {
                if (dic[s[i]] == 1) 
                {
                    return i;
                }
            }
            return -1;
        }
        public int FirstUniqChar1(string s)
        {
            int[] count = new int[26];
            char[] chars = s.ToArray();
            //先统计字符串的次数
            for (int i = 0; i < s.Length; i++)
            {
                count[chars[i] - 'a']++;
            }
            //遍历技术数组
            for (int i = 0; i < s.Length; i++)
            {
                if (count[chars[i] - 'a'] == 1) 
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
