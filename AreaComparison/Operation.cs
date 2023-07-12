using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaComparison
{
    public class Operation
    {
        int l, b;
        public Operation(int l, int b) 
        {
            this.l = l;
            this.b = b;
        }
        public void CalculateArea()
        {
            double area = l * b;
            Console.WriteLine("Area of rectangle : " + area);
        }
    }
}
