using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 测试Dictionary
            //Dictionary<int, int> map = new Dictionary<int, int>();
            //map.Add(1, 11);
            //map.Add(2, 22);
            //map.Add(3, 33);

            //map[2] = 1;
            //int a = map[1];
            //int a1 = map[2];
            //int a2 = map[3];
            //Console.WriteLine(a);
            //Console.WriteLine(a1);
            //Console.WriteLine(a2);
            //Console.ReadKey(); 
            #endregion

            #region string测试
            //string s = "abcdefg";
            //Console.WriteLine(s[s.Length - 1]);
            //Console.ReadKey(); 
            #endregion

            #region string
            //string[] strs = new string[] { "123", "456", "789", "0123" };
            //char c = strs[1][2];
            //Console.WriteLine(c); 
            #endregion
            string[] strs = new string[] { "flower", "flow", "flight" };
            string str1 = "flower";
            string str = "flowe";
            int n = strs[1].IndexOf(str);
            Console.WriteLine(n);
            Console.ReadKey();
        }
    }
}
