using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _401_二进制手表
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadBinaryWatch(0);
        }
        public static IList<string> ReadBinaryWatch(int num)
        {
            //暴力列举即可
            //这题的意思就是给一个数字，分配给上下
            //注意上面的数字最大只能是3 因为上面是0-11，8421最多只有3位
            //下面是0-59 32 16 8 4 2 1 最后可以5位
            IList<string> res = new List<string>();
            for (int hour = 0; hour <= Math.Min(num, 3); hour++)
            {
                if (num - hour <= 5)
                {
                    string[] hours = GetHoursList(hour);
                    string[] minutes = GetMinutesList(num - hour);
                    foreach (string h in hours)
                    {
                        foreach (string m in minutes)
                        {
                            res.Add(h + ':' + m);
                        }
                    }
                }
            }
            return res;
        }
        public static string[] GetHoursList(int num)
        {
            switch (num)
            {
                case 0:
                    return new string[] { "0" };
                    break;
                case 1:
                    return new string[] { "1", "2", "4", "8" };
                    break;
                case 2:
                    return new string[] { "3", "5", "9", "6", "10" };
                    break;
                default:
                    return new string[] { "7", "11" };
                    break;
            }
        }
        public static string[] GetMinutesList(int num)
        {
            switch (num)
            {
                case 0:
                    return new string[] { "00" };
                    break;
                case 1:
                    return new string[] { "01", "02", "04", "08", "16", "32" };
                    break;
                case 2:
                    return new string[] { "03", "05", "06", "09", "10", "12", "17", "18", "20", "24", "33",
                        "34", "36", "40", "48" };
                    break;
                case 3:
                    return new string[] { "07", "11", "13", "14", "19", "21", "22", "25", "26", "28", "35",
                        "37", "38", "41", "42", "44", "49", "50", "52", "56" };
                    break;
                case 4:
                    return new string[] { "15", "23", "27", "29", "30", "39", "43", "45", "46", "51", "53",
                        "54", "57", "58" };
                    break;
                default:
                    return new string[] { "31", "47", "55", "59" };
                    break;
            }
        }

    }
}
