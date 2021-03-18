using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _455_分发饼干
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public int FindContentChildren(int[] g, int[] s)
        {
            //两个指针
            //g和s分别遍历s的比g的大就两个都++，不大就把s的++，最后返回g的数量
            Array.Sort(g);
            Array.Sort(s);
            int g_point = 0;
            int s_point = 0;
            while (g_point < g.Length && s_point < s.Length) 
            {
                if (g[g_point] <= s[s_point]) 
                {
                    g_point++;
                    s_point++;
                }
                else
                {
                    s_point++;
                }
            }
            return g_point;
        }
    }
}
