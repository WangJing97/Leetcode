using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _168_Excel表列名称
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 29;
            string res = ConvertToTitle(n);
            Console.WriteLine(res);
            Console.ReadKey();
        }
        public static string ConvertToTitle(int n)
        {
            //StringBuilder sb = new StringBuilder();
            string str = string.Empty;
            while (n > 0)
            {
                //使用StringBuilder最后需要把字符串进行反转
                //注意这里的n-- 要注意往后加不包括自己
                n--;
                //sb.Append((char)('A' + n % 26));
                //ASCII码的65就是A
                str = (char)(65 + n % 26) + str;
                n = n / 26;
            }
            return str;
        }
    }
}
