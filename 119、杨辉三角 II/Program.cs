using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _119_杨辉三角_II
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowIndex = 3;
            GetRow(rowIndex);
            Console.ReadKey();
        }
        public static IList<int> GetRow(int rowIndex)
        {
            //添加断点，注意观察步骤
            //currentResult使用完成之后会被清空存到prevResult里边去
            //currentResult通过第一位手动+1和最后一位手动+1得到
            List<int> prevResult = new List<int> { 1 };

            if (rowIndex == 0)
            {
                return prevResult;
            }

            for (int i = 1; i <= rowIndex; i++)
            {
                List<int> currentResult = new List<int>();
                currentResult.Add(1);
                for (int j = 0; j < prevResult.Count - 1; j++)
                {
                    currentResult.Add(prevResult[j] + prevResult[j + 1]);
                }
                currentResult.Add(1);
                prevResult = currentResult;
            }
            return prevResult;
        }
    }
}
