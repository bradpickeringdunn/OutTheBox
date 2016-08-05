using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OTB.Common.Tests
{
    [TestClass]
    public class ObjectExtensionsTestFixture
    {
        [TestMethod]
        public void Ensure_IsNull_Returns_true_If_Object_Null()
        {
            object newObject = null;
            var result = false;

            if (newObject.IsNull())
            {
                result = true;
            }

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Ensure_IsNull_Returns_False_If_Object_NotNull()
        {
            object newObject = new object();
            var result = false;

            if (newObject.IsNull())
            {
                result = true;
            }

            Assert.IsFalse(result);
        }
    }
}
