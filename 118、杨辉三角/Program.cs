using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _118_杨辉三角
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = Generate(3);
            Console.ReadKey();
        }
        public static IList<IList<int>> Generate(int numRows)
        {
            //先做第二个理清过程
            IList<IList<int>> result = new List<IList<int>>();

            if (numRows == 0)
            {
                return result;
            }

            List<int> prevResult = new List<int> { 1 };
            result.Add(prevResult);

            for (int i = 1; i <= numRows; i++)
            {
                List<int> currentResult = new List<int>();
                currentResult.Add(1);
                for (int j = 0; j < prevResult.Count - 1; j++) 
                {
                    currentResult.Add(prevResult[j] + prevResult[j + 1]);
                }
                currentResult.Add(1);
                prevResult = currentResult;
                result.Add(prevResult);
            }
            return result;
        }
    }
}
