using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _371_两整数之和
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public int GetSum(int a, int b)
        {
            /*
            具体操作步骤：
            1、首先不考虑进位把两个数加起来，使用异或操作xor 不同出1，相同出0
            a=2             00000010
            b=3             00000011
            xor=a^b         00000001  . temp
            2、计算进位值并且要把它向左移动一位 使用与and 全1出1 
            carry=a&b       00000010
            carry<<=1       00000100  . b
            3、把进位的值和相加的值加起来
            xor=xor^carry   00000101
            4、检查是否要进位
            carry=xor&carry 00000000
             */
            int xor,carry;
            xor = a ^ b;
            carry = a & b;
            if (carry == 0) 
            {
                return xor;
            }
            else
            {
                return GetSum(xor, carry << 1);
            }
        }
        public int GetSum1(int a, int b)
        {
            //相同思路，写法不一样
            while (b != 0) 
            {
                int temp = a ^ b;
                b = (a & b) << 1;
                a = temp;
            }
            return a;
        }

    }
}
