using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _463_岛屿的周长
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public int IslandPerimeter(int[][] grid)
        {
            //遍历所有的数组，遇到1加4 ，有一个相邻的陆地减1
            if (grid == null || grid.Length == 0 || grid[0].Length == 0) return 0;
            int result = 0;
            for (int i = 0; i < grid.Length; i++) 
            {
                for (int j = 0; j < grid[i].Length; j++) 
                {
                    if (grid[i][j] == 1) 
                    {
                        result += 4;
                        if (i > 0 && grid[i - 1][j] == 1)
                        {
                            result -= 2;
                        }
                        if (j > 0 && grid[i][j - 1] == 1)
                        {
                            result -= 2;
                        }
                    }
                }
            }
            return result;
        }
    }
}
