using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _500_键盘行
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public string[] FindWords(string[] words)
        {
            List<string> result = new List<string>();
            foreach (string word in words)
            {
                if (Method(word))
                {
                    result.Add(word);
                }
            }
            return result.ToArray();
        }
        //判断word在那一行
        public bool Method(string word)
        {
            string str1 = "qwertyuiop";
            string str2 = "asdfghjkl";
            string str3 = "zxcvbnm";
            word = word.ToLower();
            string flag = "";
            if (word.Length <= 1) 
            {
                return true;
            }
            //先把word的第一个数字在那行作为一个标志
            if (str1.Contains(word[0])) 
            {
                flag = str1;
            }
            else if (str2.Contains(word[0]))
            {
                flag = str2;
            }
            else if (str3.Contains(word[0]))
            {
                flag = str3;
            }
            //用第一个标志来查看word的其他的字母
            for (int i = 0; i < word.Length; i++)
            {
                if (!flag.Contains(word[i])) 
                {
                    return false;
                }
            }
            return true;
        }
    }
}
