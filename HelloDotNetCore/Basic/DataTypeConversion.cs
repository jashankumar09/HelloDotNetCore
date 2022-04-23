using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloDotNetCore.Basic
{
    internal class DataTypeConversion
    {
        public DataTypeConversion()
        {
            //implicit conversion

            int i = 100;

            // float is bigger datatype than int. So, no loss of
            // data and exceptions. Hence implicit conversion
            float f = i;

            Console.WriteLine(f);

            //explicit conversion
            float f1 = 100.25F;

            // Cannot implicitly convert float to int.
            // Fractional part will be lost. Float is a
            // bigger datatype than int, so there is
            // also a possiblity of overflow exception
            // int j = f1;

            // Use explicit conversion using cast () operator
            int j = (int)f;

            // OR use Convert class
            // int i = Convert.ToInt32(f);

            Console.WriteLine(j);

        }
    }
}