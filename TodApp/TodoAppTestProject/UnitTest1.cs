using System;
using TodApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TodoAppTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            TodoItem test = new TodoItem();
            int a = 9;
            int b = 5;


            Assert.AreEqual(a + b, 14, "a + b ne 14");
        }
    }
}
