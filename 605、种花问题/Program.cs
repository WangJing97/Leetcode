using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _605_种花问题
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            int count = 0;
            //本题就是查看【遍历i】的左右两位是不是为0是的话就是正确的
            for (int i = 0; i < flowerbed.Length; i++)
            {
                //查看数组两边的边缘情况，和数组中的情况
                if (flowerbed[i] == 0 && (i == 0 || flowerbed[i - 1] == 0) && (i == flowerbed.Length - 1 || flowerbed[i + 1] == 0)) 
                {
                    flowerbed[i] = 1;
                    count++;
                }
            }
            return count >= n;

        }
    }
}
