using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloDotNetCore.Basic
{
    internal class LearningIf
    {
        public LearningIf()
        {
            Console.WriteLine("please enter a number");

            int usernumber = int.Parse(Console.ReadLine());

            if (usernumber == 1)
            {
                Console.WriteLine("your number is one");
            }
            else if (usernumber == 2)
            {
                Console.WriteLine("your number is two");
            }
            else if (usernumber == 3)
            {
                Console.WriteLine("your number is 3");
            }
            else
            {
                Console.WriteLine("your number is not between 1 and 3");
            }
       
        }


    }
}
