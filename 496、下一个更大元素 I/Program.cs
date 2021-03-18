using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _496_下一个更大元素_I
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = new int[] { 4, 1, 2 };
            int[] nums2 = new int[] { 1, 3, 4, 2 };

            int[] result = new int[nums1.Length];
            result = NextGreaterElement(nums1, nums2);

        }
        public static int[] NextGreaterElement(int[] nums1, int[] nums2)
        {
            /*
            使用一个栈和一个字典
            方法就是 先忽略第一个数组
            把第二个数组的第一个数nums2[1]加入栈，然后对第二个数nums2[2]
            1.如果nums2[2] > nums2[1] 说明找到了nums2[1]下一个最大的元素nums2[2]，把nums2[1]出栈，并且把nums2[2]入栈。并且map[nums2[1],nums2[2]]。
            2.如果nums2[2] <= nums2[1] 把nums2[2]入栈。
            3.对于下一个元素设为nums2[3]，而此时栈中还有几个元素，这样，就找到了这些元素的最大元素nums2[3]，这样就把栈中的元素出栈，并且map[nums2[1],nums2[3]]，map[nums2[2],nums2[3]]，并且把nums2[3]入栈。
            4.到了数组的最后向map添加map[nums2[i],-1]

            举例：
            nums1 = [4,1,2], nums2 = [1,3,4,2]

            stack=[1] 1<3           map=[1,3]
            map=[1,3]                   [3,4]
                                        [2,-1]
            stack=[3] 3<4               [4,-1]
            map=[3,4] 

            stack=[4] 4<2 ×

            stack=[4,2]

            map=[2,-1]
            map=[4,-1] 
            最后返回的就是map对应的value值
            所以res=[-1,3,-1]
            */
            Stack<int> stack = new Stack<int>();
            Dictionary<int, int> map = new Dictionary<int, int>();
            int[] result = new int[nums1.Length];

            for (int i = 0; i < nums2.Length; i++)
            {
                while (stack.Count != 0 && nums2[i] > stack.Peek())
                {
                    map.Add(stack.Pop(), nums2[i]);         
                }
                stack.Push(nums2[i]);
            }
            while (stack.Count != 0)
            {
                map.Add(stack.Pop(), -1);
            }
            for (int i = 0; i < nums1.Length; i++)
            {
                result[i] = map[nums1[i]];
            }
            return result;
        }
    }
}
