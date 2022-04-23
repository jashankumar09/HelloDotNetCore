using System;
namespace HelloDotNetCore
{
    //ctor then tab to make constructor
    internal class Inputuser
    {
        public Inputuser()
        {
            Console.WriteLine("enter your first name");

            string firstname = Console.ReadLine();

            Console.WriteLine("enter your last name");

            string lastname = Console.ReadLine();

            string fullname = ("Hello" + firstname + " " + lastname);

            Console.WriteLine(fullname);

        }
    }
}

