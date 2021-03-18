using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _242_有效的字母异位词
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length) 
            {
                return false;
            }
            //利用字典 key存字符串 value存出现的次数
            Dictionary<char, int> dic = new Dictionary<char, int>();
            //把s字符串放进字典
            for (int i = 0; i < s.Length; i++)
            {
                //已经有了 就+1
                if (dic.ContainsKey(s[i])) 
                {
                    dic[s[i]]++;
                }
                //没有就添加一个
                else
                {
                    dic.Add(s[i], 1);
                }
            }
            //t字符串和字典中的s做对比
            for (int i = 0; i < t.Length; i++)
            {
                //如果s t有重复
                if (dic.ContainsKey(t[i])) 
                {
                    //如果value不为1 减一
                    if (dic[t[i]] != 1) 
                    {
                        dic[t[i]]--;
                    }
                    //减完了就移除
                    else
                    {
                        dic.Remove(t[i]);
                    }
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
        public bool IsAnagram1(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }

            char[] str1 = s.ToCharArray();
            char[] str2 = t.ToCharArray();
            Array.Sort(str1);
            Array.Sort(str2);

            //Enumerable.SequenceEqual
            //通过使用相应类型的默认相等比较器对序列的元素进行比较，以确定两个序列是否相等
            return Enumerable.SequenceEqual(str1, str2);

        }
        public bool IsAnagram2(string s, string t)
        {
            //本题都是小写 
            //利用ASCII码
            //每个字母一个坑
            if (s.Length != t.Length) 
            {
                return false;
            }
            int[] ss = new int[26];
            foreach (char schar in s)
            {
                ss[schar - 'a']++;
            }
            foreach (char tchar in t)
            {
                ss[tchar - 'a']--;
                if (ss[tchar - 'a'] < 0) 
                {
                    return false;
                }
            }
            return true;
        }
    }
}
