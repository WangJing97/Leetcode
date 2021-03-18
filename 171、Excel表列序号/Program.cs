using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _171_Excel表列序号
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "CB";
            int res = TitleToNumber(s);
            Console.WriteLine(res);
            Console.ReadKey();
        }
        public static int TitleToNumber(string s)
        {
            //如何找到一个字母表的字母的数字：
            //'A'=65
            //将这个字母和'A'做减法再加一，H = 72
            //72-65+1=8。-->num = 字母 - 'A' + 1
            //循环找数的时候26个其实到的是Z，要想找到没到Z的字母数就要加上上面算的值
            //遍历次数设res，初始值0
            //res = res * 26 + num
            int res = 0;
            int num = 0;
            for (int i = 0; i < s.Length; i++)
            {
                num = s[i] - 'A' + 1;
                res = res * 26 + num;
            }
            return res;
        }
    }
}
