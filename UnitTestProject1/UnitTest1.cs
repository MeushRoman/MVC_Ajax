using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestProject1;

namespace UnitTestProject1
{
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
                double sqrtD = (float)System.Math.Sqrt(r.d);

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

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            QuadraticEquation qe = new QuadraticEquation();

            double a = 2, b= -11, c = 5;


            var r = qe.res(a, b, c);

            Assert.IsTrue(r.d > 0);

            Assert.IsTrue((a * Math.Pow(r.x1, 2) + b *r.x1 + c) == 0);

            Assert.IsTrue((a * Math.Pow(r.x2, 2) + b *r.x2 + c) == 0);
        }

        [TestMethod]
        public void TestMethod2()
        {
            QuadraticEquation qe = new QuadraticEquation();

            double a = 1, b = 2, c = 1;


            var r = qe.res(a, b, c);

            Assert.IsTrue(r.d == 0);

            Assert.IsTrue((a * Math.Pow(r.x1, 2) + b * r.x1 + c) == 0);

            Assert.IsTrue((a * Math.Pow(r.x2, 2) + b * r.x2 + c) == 0);
        }

        [TestMethod]
        public void TestMethod3()
        {
            QuadraticEquation qe = new QuadraticEquation();

            double a = 1, b = 1, c = 1;


            var r = qe.res(a, b, c);

            Assert.IsTrue(r.d < 0);

        }
    }
}
