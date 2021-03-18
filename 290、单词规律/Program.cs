using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _290_单词规律
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public bool WordPattern(string pattern, string s)
        {
            List<string> list = s.Split(' ').ToList();
            if (list.Count != pattern.Length)
                return false;
            Dictionary<char, string> dictionary = new Dictionary<char, string>(list.Count);
            for (int i = 0; i < list.Count; i++)
            {
                if (dictionary.ContainsKey(pattern[i]))
                {
                    if (dictionary[pattern[i]] != list[i])
                        return false;
                }
                else
                {
                    if (dictionary.ContainsValue(list[i]))
                        return false;
                    dictionary.Add(pattern[i], list[i]);
                }
            }
            return true;
        }
    }
}
