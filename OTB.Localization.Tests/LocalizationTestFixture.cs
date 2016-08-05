using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Threading;
using System.Globalization;

namespace OTB.Localization.Tests
{
    [TestClass]
    public class LocalizationTestFixture
    {
        [TestMethod]
        public void Ensure_Resource_Returns_String()
        {
            var result = Test.Initialize.GetLabel("TestResource", "Testing");

            Assert.AreEqual(result, "Testing testing 123");
        }

        [TestMethod]
        public void Ensure_Resource_Returns_String_Based_On_Thread_Culture()
        {
            var result = Test.Initialize.GetLabel("TestResource", "Testing");

            Assert.AreEqual(result, "Testing testing 123");

            Thread.CurrentThread.CurrentCulture = new CultureInfo("af-ZA");

            result = Test.Initialize.GetLabel("TestResource", "Testing");

            Assert.AreEqual(result, "Testing Testing een, twe, drie!");
        }
    }

    internal class Test : BaseLocalization<Test>
    {
        public override IDictionary<string, string> Resources()
        {
            var resourceNamespaces = new Dictionary<string, string>();

            resourceNamespaces.Add("TestResource", "OTB.Localization.Tests");
           
            return resourceNamespaces;
        }
    }
}
