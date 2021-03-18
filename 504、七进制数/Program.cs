using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _504_七进制数
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public string ConvertToBase7(int num)
        {
            if (num == 0) return "0";
            bool isnegative = num < 0;
            num = Math.Abs(num);
            string result = "";
            while (num > 0) 
            {
                result = (num % 7).ToString() + result;
                num /= 7;
            }
            if (isnegative)
            {
                result = "-" + result;
            }
            return result;
        }
    }
}
