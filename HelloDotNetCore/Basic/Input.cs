using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloDotNetCore
{
    //ctor then tab to make constructor
    internal class Input
    {
        public Input()
        {
            Console.WriteLine("enter name");

            string username = Console.ReadLine();

            Console.WriteLine("hello" + username);
        }
    }
}
