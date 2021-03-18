using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _415_字符串相加
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public string AddStrings(string num1, string num2)
        {
            //用阿斯克码
            int i = num1.Length - 1;
            int j = num2.Length - 1;
            int x;
            int y;
            int carry = 0;
            StringBuilder res = new StringBuilder();
            while (i >= 0 || j >= 0 || carry != 0)  
            {
                if (i >= 0) 
                {
                    x = num1[i] - '0';
                }
                else
                {
                    x = 0;
                }
                if (j >= 0) 
                {
                    y = num2[j] - '0';
                }
                else
                {
                    y = 0;
                }
                int sum = x + y + carry;
                res.Append(sum % 10);
                carry = sum / 10;
                i--;
                j--;
            }
            if (carry == 1) 
            {
                res = res.Append(carry);
            }
            char[] chr = res.ToString().ToCharArray();
            Array.Reverse(chr);
            return new string(chr);
        }
    }
}
