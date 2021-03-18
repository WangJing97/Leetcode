using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _412_Fizz_Buzz
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public IList<string> FizzBuzz(int n)
        {
            List<string> list = new List<string>();
            for (int i = 1; i <= n; i++)
            {
                if (i % 5 == 0 && i % 3 == 0) list.Add("FizzBuzz");
                else if (i % 5 == 0) list.Add("Buzz");
                else if (i % 3 == 0) list.Add("Fizz");
                else list.Add(i.ToString());
            }
            return list;
        }
    }
}
