using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _125_验证回文串
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public bool IsPalindrome(string s)
        {
            if (s == null || s.Length == 0)
            {
                return true;
            }
            int i = 0;
            int j = s.Length - 1;

            while (i <= j)
            {

                while (i <= j && !char.IsLetterOrDigit(s[i]))
                {
                    i++;
                }
                while (i <= j && !char.IsLetterOrDigit(s[j]))
                {
                    j--;
                }
                if (i <= j && char.ToLower(s[i]) != char.ToLower(s[j]))
                {
                    return false;
                }
                i++;
                j--;
            }
            return true;
        }
        public bool IsPalindrome1(string s)
        {
            s = s.ToLower();
            string str = "qwertyuiopasdfghjklzxcvbnm0123456789";
            List<char> strc = new List<char>();
            foreach (char item in s)
            {
                if (str.Contains(item))
                {
                    strc.Add(item);
                }
            }
            int i = 0;
            int j = strc.Count - 1;
            while (i < j)
            {
                if (strc[i] != strc[j])
                {
                    return false;
                }
                else
                {
                    i++;
                    j--;
                }
            }
            return true;
        }
    }
}
