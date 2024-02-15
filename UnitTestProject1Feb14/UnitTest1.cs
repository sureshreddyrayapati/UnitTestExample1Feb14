using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Calculater;
namespace UnitTestProject1Feb14
{
    [TestClass]
    public class UnitTest1
    {
        Calculater1 calc;
        public UnitTest1()
        {
            calc = new Calculater1();
        }

        [TestMethod]
        public void TestMethod1()
        {
            int n1 = 45;
            int n2 = 45;
            Assert.AreEqual(n1, n2);
        }
        [TestMethod]
        public void AddTest() {
            double n1 = 5;
            double n2 = 10;
            double res = 15;
            Assert.AreEqual(res,calc.Add(n1,n2));
        }
        [TestMethod]
        public void subTest()
        {
            double n1 = 10;
            double n2 = 5;
            double res = 5;
            Assert.AreEqual(res, calc.Sub(n1, n2));
        }
        [TestMethod]
        public void mulTest()
        {
            double n1 = 5;
            double n2 = 10;
            double res = 50;
            Assert.AreEqual(res,calc.Multi(n1,n2));
        }
        [TestMethod]
        public void divTest()
        {
            double n1 = 10;
            double n2 = 5;
            double res = 2;
            Assert.AreEqual(res, calc.Div(n1, n2));
        }
    }
}
