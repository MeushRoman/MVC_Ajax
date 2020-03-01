using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            QuadraticEquation qe = new QuadraticEquation();

            var res = qe.res(1, 2, 1);
        }

    }

    public class result
    {
        public double d { get; set; }
        public double x1 { get; set; }
        public double x2 { get; set; }
    }

    public class QuadraticEquation
    {
        public result res(double a, double b, double c)
        {
            result r = new result();
            r.d = b * b - 4 * a * c;

            if (r.d > 0)
            {
                double sqrtD = (double)System.Math.Sqrt(r.d);

                r.x1 = (-b + sqrtD) / (2 * a);
                r.x2 = (-b - sqrtD) / (2 * a);
            }
            else if (r.d == 0)
            {
                r.x1 = r.x2 = -(b / 2 * a);
            }

            return r;
        }
    }
}
