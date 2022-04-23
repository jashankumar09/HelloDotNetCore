using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloDotNetCore.Basic
{
    internal class LearningSwitchCase
    {
        public LearningSwitchCase()
        {
            Console.WriteLine("enter a number");
            int username = int.Parse(Console.ReadLine());

            switch (username)
            {
                case 1:
                    {
                        Console.WriteLine("your number is 1");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("your number is 2");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("your number is 3");
                            break;
                    }
                default:
                    {
                        Console.WriteLine("your number is not 10,20,30");
                        break;
                    }
            }
        }
    }
}
