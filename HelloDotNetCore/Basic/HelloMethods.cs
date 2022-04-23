using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloDotNetCore.Basic
{
    public class HelloMethods
    {
        public int Add(int FN, int SN)
        {
            return FN + SN; 
        }

        public static void EvenNumbers(int range)
        {
            int start = 0;
            while (start <= range)
            {
                Console.WriteLine(start);
                start=start+2;
            }
        }
    }
}
