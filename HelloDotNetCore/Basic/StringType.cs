using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloDotNetCore.Basic
{
    internal class StringType 
    {
        public StringType()
        {
            // Displaying double quotes in c#
            string Name = "\"Pragim\"";
            Console.WriteLine(Name);

            // Displaying new line character in c#
            Name = "One\nTwo\nThree";
            Console.WriteLine(Name);

            // Displaying new line character in c#
            Name = "c:\\Pragim\\DotNet\\Training\\Csharp";
            Console.WriteLine(Name);

            // C# verbatim literal
            Name = @"c:\Pragim\DotNet\Training\Csharp";
            Console.WriteLine(Name);
        }

      
    }
}
