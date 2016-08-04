using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OTB.Common.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            object newObject = null;
            var result = false;

            if (newObject.IsNull())
            {
                result = true;
            }

            Assert.IsTrue(result);
        }
    }
}
