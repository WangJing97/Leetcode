using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _66_加一
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] digits = new int[] { 9, 9, 9 };
            int[] res = PlusOne(digits);
            foreach (int item in res)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
        public static int[] PlusOne(int[] digits)
        {
            int i = digits.Length - 1;
            while (i >= 0)
            {
                if (digits[i] < 9)
                {
                    digits[i] += 1;
                    return digits;
                }
                digits[i] = 0;
                i--;
            }
            int[] res = new int[digits.Length + 1];
            res[0] = 1;
            return res;
        }
        public static int[] PlusOne1(int[] digits)
        {
            int flag = 1;
            for (int i = digits.Length - 1; i >= 0; i--) 
            {
                int temp = digits[i] + flag;
                if (temp >= 10)
                {
                    flag = 1;
                    digits[i] = temp - 10;
                }
                else
                {
                    digits[i] = temp;
                    flag = 0;
                    break;
                }
            }
            if (flag == 0) 
            {
                return digits;
            }
            int[] res = new int[digits.Length + 1];
            res[0] = 1;
            for (int i = 0; i < digits.Length; i++)
            {
                res[i + 1] = digits[i];
            }
            return res;
        }
    }
}
