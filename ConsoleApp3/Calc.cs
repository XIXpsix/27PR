using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Calc
    {        
            private double x;
            private double y;
            public double X
            {
                get { return x; }
                set { x = value; }
            }

            public double Y
            {
                get { return y; }
                set { y = value; }
            }
            public Calc()
            {
                x = 0;
                y = 0;
            }
            public Calc(double x, double y)
            {
                this.x = x;
                this.y = y;
            }
            public void PrintCoordinates()
            {
                Console.WriteLine($"Точка: ({x}, {y})");
            }
    }
}
