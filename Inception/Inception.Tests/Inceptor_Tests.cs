using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Inception.Tests
{
    [TestClass]
    public class Inceptor_Tests
    {
        [TestMethod]
        public void Inceptor_TestMethod()
        {
            var inceptor = new Inceptor();
            Assert.AreEqual<int>(6, inceptor.TestMethod());
        }
    }
}
