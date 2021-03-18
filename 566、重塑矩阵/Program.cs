using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _566_重塑矩阵
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public int[][] MatrixReshape(int[][] nums, int r, int c)
        {
            //根据题目意思开始循环复制
            int rows = nums.Length;
            int columns = nums[0].Length;

            if ((rows * columns) != (r * c)) return nums;

            int[][] result_arr = new int[r][];

            int row_arr = 0;
            int columns_arr = 0;

            for (int i = 0; i < r; i++)
            {
                result_arr[i] = new int[c];
                for (int j = 0; j < c; j++)
                {
                    result_arr[i][j] = nums[row_arr][columns_arr];
                    columns_arr++;
                    if (columns_arr == columns) 
                    {
                        columns_arr = 0;
                        row_arr++;
                    }
                }
            }
            return result_arr;
        }
    }
}
