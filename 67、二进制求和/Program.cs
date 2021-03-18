using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _67_二进制求和
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "11";
            string b = "1";
            string res = AddBinary1(a, b);
            Console.WriteLine(res);
            Console.ReadKey();
        }
        public static string AddBinary(string a, string b)
        {
            int i = a.Length - 1;
            int j = b.Length - 1;
            //进位
            int carry = 0;
            StringBuilder sb = new StringBuilder();
            while (i >= 0 || j >= 0)
            {
                int sum = carry;
                if (i >= 0) 
                {
                    sum += a[i] - '0';
                }
                if (j >= 0)
                {
                    sum += b[j] - '0';
                }
                //学习StringBuilder的Insert，在最前面插入
                sb.Insert(0, sum % 2);
                carry = sum / 2;
                i--;
                j--;
            }
            if (carry != 0) 
            {
                sb.Insert(0,carry);
            }
            return sb.ToString();
        }
        //暴力列出所有的情况
        public static string AddBinary1(string a, string b)
        {
            if (a.Length < b.Length)
            {
                string temp = a;
                a = b;
                b = temp;
            }
            char flag = '0';
            string sum = "";
            int alen = a.Length - 1;
            //短的先找
            for (int i = b.Length - 1; i >= 0; i--) 
            {
                //flag == '0'
                if (a[alen] == '0' && b[i] == '0' && flag == '0') 
                {
                    sum = '0' + sum;
                }
                else if (a[alen] == '0' && b[i] == '1' && flag == '0')
                {
                    sum = '1' + sum;
                }
                else if (a[alen] == '1' && b[i] == '0' && flag == '0')
                {
                    sum = '1' + sum;
                }
                else if (a[alen] == '1' && b[i] == '1' && flag == '0')
                {
                    sum = '0' + sum;
                    flag = '1';
                }
                //flag == '1'
                else if (a[alen] == '0' && b[i] == '0' && flag == '1')
                {
                    sum = '1' + sum;
                    flag = '0';
                }
                else if (a[alen] == '0' && b[i] == '1' && flag == '1')
                {
                    sum = '0' + sum;
                }
                else if (a[alen] == '1' && b[i] == '0' && flag == '1')
                {
                    sum = '0' + sum;
                }
                else if (a[alen] == '1' && b[i] == '1' && flag == '1')
                {
                    sum = '1' + sum;
                    flag = '1';
                }
                alen--;
            }
            //短的找完找长的剩下的
            for (int i = alen; i >= 0; i--)
            {
                if (a[i] == '0' && flag == '0') 
                {
                    sum = '0' + sum;
                }
                else if (a[i] == '0' && flag == '1')
                {
                    sum = '1' + sum;
                    flag = '0';
                }
                else if (a[i] == '1' && flag == '0')
                {
                    sum = '1' + sum;
                }
                else if (a[i] == '1' && flag == '1')
                {
                    sum = '0' + sum;
                }
            }
            if (flag == '1')
            {
                sum = '1' + sum;
            }
            return sum;
        }
    }
}
