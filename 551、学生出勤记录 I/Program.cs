using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _551_学生出勤记录_I
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public bool CheckRecord(string s)
        {
            if (s.IndexOf("LLL") != -1) 
            {
                return false;
            }

            int countA = 0;
            foreach (char c in s.ToArray())
            {
                if (c == 'A') 
                {
                    countA++;
                }
                if (countA > 1) 
                {
                    return false;
                }
            }
            return true;
        }
    }
}
