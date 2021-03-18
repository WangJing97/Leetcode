using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _122_买卖股票的最佳时机_II
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] prices = new int[] { 1, 7, 2, 3, 6, 7, 6, 7 };
            int res = MaxProfit(prices);
            Console.WriteLine(res);
            Console.ReadKey();
        }
        public static int MaxProfit(int[] prices)
        {
            //连续买卖 盈利就继续
            if (prices == null || prices.Length < 2) 
            {
                return 0;
            }
            int sum = 0;
            int difference = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                difference = prices[i] - prices[i - 1];
                if (difference > 0)  
                {
                    sum += difference;
                }
            }
            return sum;
        }
    }
}
