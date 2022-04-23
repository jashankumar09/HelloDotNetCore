using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloDotNetCore.Basic
{
    class Customer
    {
        string firstname;
        string lastname;

        public Customer()

            : this("no firstname provided", "no lastname provided")
        {

        }
        public Customer(string firstname, string lastname)
        {
            this.firstname = firstname;
            this.lastname = lastname;
        }

        public void printfullname()
        {
            Console.WriteLine("fullname={0}", this.firstname + " " + this.lastname);
        }
        ~Customer()
        {
            //cleanup code
        }
    }


}
