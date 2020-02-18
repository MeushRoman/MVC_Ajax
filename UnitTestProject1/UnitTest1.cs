using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestProject1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arrange 
            int x = 2;
            int y = 2;

            //act
            int z = x + y;

            //assert   -expected   -actual

            Assert.IsTrue(z==4);
            Assert.IsNotNull(z);
            Assert.AreNotSame(x, y);
            
        }
    }
}
