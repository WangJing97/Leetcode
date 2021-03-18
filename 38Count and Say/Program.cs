using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38Count_and_Say
{
    class Program
    {
        static void Main(string[] args)
        {
            string res = CountAndSay(4);
            Console.WriteLine(res);
            Console.ReadKey();
        }
        public static string CountAndSay(int n)
        {
            if (n == 1)
            {
                return "1";
            }
            string rep = "1";
            for (int i = 2; i < n + 1; i++)
            {
                //每次迭代
                rep = GetNextCountAndSay(rep);
            }
            return rep;
        }
        public static string GetNextCountAndSay(string str)
        {
            string rep = "";
            char target = str[0];
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == target)
                {
                    count++;
                }
                else
                {
                    rep = rep + count.ToString() + target;
                    target = str[i];
                    count = 1;
                }               
            }
            rep = rep + count.ToString() + target;
            return rep;

        }
    }
}
