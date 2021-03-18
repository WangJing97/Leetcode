using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _121_买卖股票的最佳时机
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] prices = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int res = MaxProfit(prices);
            Console.WriteLine(res);
            Console.ReadKey();
        }
        public static int MaxProfit(int[] prices)
        {
            if (prices == null || prices.Length < 1)
            {
                return 0;
            }
            int lowest = prices[0];
            int sum = 0;
            for (int i = 0; i < prices.Length; i++)
            {
                if (lowest > prices[i])
                {
                    lowest = prices[i];
                }
                sum = Math.Max(sum, prices[i] - lowest);
            }
            return sum;
        }
    }
}
