using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _345_反转字符串中的元音字母
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public string ReverseVowels(string s)
        {
            if (s == null || s.Length < 2) 
            {
                return s;
            }
            char[] chars = s.ToCharArray();
            int left = 0;
            int right = s.Length - 1;
            while (left < right) 
            {
                while (left < s.Length && !isVowel(chars[left])) 
                {
                    left++;
                }
                while (right >= 0 && !isVowel(chars[right])) 
                {
                    right--;
                }
                if (left < right) 
                {
                    char temp = chars[left];
                    chars[left] = chars[right];
                    chars[right] = temp;
                    left++;
                    right--;
                }
            }
            return new string(chars);
        }
        //判断字符是否为元音字母
        public bool isVowel(char c)
        {
            return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u'
                || c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U';
        }
    }
}
