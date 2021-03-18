using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _599_两个列表的最小索引总和
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public string[] FindRestaurant(string[] list1, string[] list2)
        {
            //使用一个字典和一个列表，遍历list1把他的名字和下标放进去字典(list[i],i)
            //遍历lsit2时候查询字典键值，存在即找到的两个list都有，求一个value和list2的下标的和，如果后面有比这个小的，更新
            Dictionary<string, int> dic = new Dictionary<string, int>();
            List<string> result = new List<string>();

            for (int i = 0; i < list1.Length; i++)
            {
                dic.Add(list1[i], i);
            }
            int sum = int.MaxValue;
            for (int j = 0; j < list2.Length; j++)
            { 
                if (dic.ContainsKey(list2[j])) 
                {

                    //如果比之前少的更新
                    if (j + dic[list2[j]] < sum)
                    {
                        sum = j + dic[list2[j]];
                        result.Clear();
                        result.Add(list2[j]);
                    }
                    else if (j + dic[list2[j]] == sum) 
                    {
                        result.Add(list2[j]);
                    }
                }
            }
            return result.ToArray();
        }
    }
}
