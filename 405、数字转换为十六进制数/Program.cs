using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _405_数字转换为十六进制数
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public string ToHex(int num)
        {
            //4位4位的获取二进制的值然后转成16进制
            string hex = "0123456789abcdef";
            if (num == 0) return "0";
            string res = "";
            int count = 0;
            while (count < 8 && num != 0)
            {
                //0xf
                res = hex[num & 15] + res;
                num >>= 4;
                count++;
            }
            return res;
        }
    }
}
