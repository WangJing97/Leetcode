using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28_1KMP
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = "132";
            string Text = "12122";
            KMP(Text, pattern);
            Console.ReadKey();
        }
        public static void prefix_table(string pattern, int[] prefix, int n)
        {
            #region MyRegion
            //prefix[0] = 0;
            //int len = 0;
            ////i从开始，前缀表的第一位默认是1
            //int i = 1;
            ////根据笔记仔细理解，这里求得的是前缀表，这里的len就是j也是前缀的长度
            //while (i < n)
            //{
            //    //如果找的两个值是相等的
            //    //len值加1给prefix[i]，并且i加1
            //    if (pattern[i] == pattern[len]) 
            //    {
            //        len++;
            //        prefix[i] = len;
            //        i++;
            //    }
            //    else
            //    {
            //        //如果不相等找len前一个prefix中的值给len并且继续开始找
            //        if (len > 0) 
            //        {
            //            len = prefix[len - 1];
            //        }
            //        //在减到0的时候直接prefix[i]，i加一继续找
            //        else
            //        {
            //            prefix[i] = len;
            //            i++;
            //        }
            //    }
            //}
            //for (int j = pattern.Length-1; j > 0; j--)
            //{
            //    prefix[j] = prefix[j - 1];
            //}
            //prefix[0] = -1; 
            #endregion
            int j = 0, i = 1;//两个指针

            prefix[0] = 0;//初始化
            while (i < n)
            {
                //m是字符串长度
                if (pattern[i] == pattern[j])
                {
                    //如果前后相同，j对应的nxt数组的值是i坐标+1
                    //i++先给i再加一，++i先加一在给值
                    prefix[i++] = ++j;
                }
                else if (j == 0)
                {
                    //如果i在起始点，并且前后不相同，j对应的nxt数组的值为0
                    prefix[i++] = 0;
                }
                else
                {
                    //如果前两者都不是，i就等于i-1对应的nxt数组的值
                    j = prefix[j - 1];
                }
            }
            ////next
            //for (int k = n - 1; k > 0; k--) 
            //{
            //    prefix[k] = prefix[k - 1];
            //}
            //prefix[0] = -1;
        }

        public static void KMP(string Text, string pattern)
        {
            #region MyRegion

            int m = pattern.Length;
            int n = Text.Length;
            int[] prefix = new int[n];
            prefix_table(pattern, prefix, m);

            int i = 0, j = 0;//初始化
            while (i < n && j < m)
            {
                //n是母串长度i，m是子串长度j
                if (Text[i] == pattern[j])
                {
                    //如果匹配，i、j同时往后走一位
                    i++; j++;
                }
                else if (j == 0)
                {
                    //如果不匹配且j在起始位置，i往后走一位
                    i++;
                }
                else
                {
                    //如果都不是，j就回到j-1对应的nxt数组的值
                    j = prefix[j - 1];
                }
            }
            //循环结束条件要么i走到头，母串访问完；要么j走到头，子串访问完，说明子串在母串的位置被找到
            if (j == m)
            {
                Console.WriteLine("Found pattern at {0}", i - j);//返回子串在母串的首位置
                j = prefix[j];
            }
            else
            {
                //找不到返回-1
                Console.WriteLine("-1");
            }
            #endregion
            #region MyRegion
            //int n = pattern.Length;
            //int m = Text.Length;
            //int[] prefix = new int[n];
            //prefix_table(pattern, prefix, n);

            ////text[i]   len(text)=m
            ////pattern[j] len(pattern)=n
            //int i = 0;
            //int j = 0;
            //while (i < m) 
            //{
            //    if (j == n - 1 && Text[i] == pattern[j])
            //    {
            //        Console.WriteLine("在第{0}位", i - j);
            //        j = prefix[j];
            //    }


            //    if (Text[i] == pattern[j]) 
            //    {
            //        i++;
            //        j++;
            //    }
            //    else
            //    {
            //        j = prefix[j];
            //        if (j == -1) 
            //        {
            //            i++;
            //            j++;
            //        }
            //    }
            //} 
            #endregion

        }
    }
}
