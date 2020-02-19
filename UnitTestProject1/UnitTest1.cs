using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestProject1;

namespace UnitTestProject1
{
    [TestClass]
    public class checkedServiceMetods
    {
        [TestMethod]
        public void TDD()
        {
            var d = new Dictionary<string, string>();
        }
         
        [TestMethod]
        public void checkMethod_getArray()
        {
            var service = new Service(3);

            Assert.IsTrue(service.getArray.Count == 3);

            Assert.IsInstanceOfType(service, typeof(Service));
        }

        [TestMethod]
        public void checkMethod_Cities()
        {
            var service = new Service(3);

            var cities = new List<City>
            {
                new City{Id = 1, Name = "Almaty"},
                new City{Id = 2, Name = "Astana"},
                new City{Id = 3, Name = "Atyrau"}
            };
            var cities2 = service.Cities();

            Assert.IsInstanceOfType(service.Cities().First().Name, typeof(string));

            Assert.IsInstanceOfType(service.Cities(), typeof(List<City>));

            Assert.IsNotNull(service.Cities());

        }

        


        //[TestMethod]
        //public void Sum_check_return_value()
        //{
        //    ///Arrange///
        //    TestClass testClass = new TestClass();

        //    ///Act///
        //    int res = testClass.Sum(2,3);

        //    ///assert///
        //    //1 
        //    //Assert.AreEqual(5, res);

        //    //2 
        //    //Assert.AreNotEqual(11, res);

        //    //3
        //    ///Act///
        //    //var class1 = new TestClass();
        //    //var class2 = class1;
        //    ///assert///
        //    //Assert.AreSame(class1, class2);

        //    //4
        //    ///Act///
        //    //string st = null;
        //    ///assert///
        //    //Assert.IsNull(st);

        //    ///assert///
        //    //4 Assert.IsTrue(res == 5);

        //    //5
        //    ///Act///
        //    //var class3 = new TestClass();
        //    ///assert///
        //    //Assert.IsInstanceOfType(class3, typeof(TestClass));

        //    //int i = 0;
        //    //try
        //    //{

        //    //    Assert.Fail();
        //    //}
        //    //catch (Exception)
        //    //{

        //    //    throw;
        //    //}            
        //}

        //[TestMethod]
        //public void TestMethod1()
        //{
        //    //arrange 
        //    int x = 2;
        //    int y = 2;

        //    //act
        //    int z = x + y;

        //    //assert   -expected   -actual

        //    Assert.IsTrue(z==4);            
        //    Assert.AreNotSame(x, y);

        //}

        //[TestMethod]
        //public void TestMethod2()
        //{
        //    //arrange 
        //    int x = 2;
        //    int y = 2;

        //    //act
        //    int z = x + y;

        //    //assert   -expected   -actual


        //    Assert.IsNotNull(z);
        //    Assert.AreNotSame(x, y);

        //}
    }
}
