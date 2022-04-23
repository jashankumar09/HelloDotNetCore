using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloDotNetCore.Basic
{
    internal class LearningArray
    {
        public LearningArray()
        {
            int[] Evennumber = new int[3];

            Evennumber[0] = 0;
            Evennumber[1] = 2;
            Evennumber[2] = 3;

            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine(Evennumber[i]);
            }
            

        }
    }
}
