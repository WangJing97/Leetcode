using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _482_密钥格式化
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public string LicenseKeyFormatting(string S, int K)
        {
            //变大，把-去掉
            S = S.ToUpperInvariant();
            S = S.Replace("-", "");

            StringBuilder sb = new StringBuilder(S);

            //从前往后插入
            for (int i = S.Length - K; i > 0; i = i - K)
            {
                sb.Insert(i, "-");
            }
            return sb.ToString();
        }
    }
}
