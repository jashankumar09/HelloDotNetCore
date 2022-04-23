using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloDotNetCore.Basic
{
    class Circle
    {
        float pi = 3.14f;
        int _radius;

        public Circle(int radius)
        {
            this._radius = radius;

        }
        public float CalculateArea()
        {
            return this.pi * this._radius * this._radius;
        }

    }
}
