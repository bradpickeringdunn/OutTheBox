using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OTB.Common.Tests.Extensions
{
    /// <summary>
    /// Summary description for StringExtensionsTestFixture
    /// </summary>
    [TestClass]
    public class StringExtensionsTestFixture
    {
        [TestMethod]
        public void Ensure_IsNullOrEmpty_Returns_False_If_String_Not_Null()
        {
            var result = "blah blah blah";

            Assert.IsFalse(result.IsNullOrEmpty());
        }

        [TestMethod]
        public void Ensure_IsNullOrEmpty_Returns_True_If_String_Is_Null()
        {
            string result = null;

            Assert.IsTrue(result.IsNullOrEmpty());
        }

        [TestMethod]
        public void Ensure_IsNullOrEmpty_Returns_True_If_String_Is_Empty()
        {
            string result = string.Empty;

            Assert.IsTrue(result.IsNullOrEmpty());
        }

        [TestMethod]
        public void Ensure_IsNotNullOrEmpty_Returns_True_If_String_Is_Not_Null()
        {
            string result = "Blah blah blah";

            Assert.IsTrue(result.IsNotNullOrEmpty());
        }

        [TestMethod]
        public void Ensure_IsNotNullOrEmpty_Returns_False_If_String_Is_Null()
        {
            string result = null;

            Assert.IsFalse(result.IsNotNullOrEmpty());
        }

        [TestMethod]
        public void Ensure_IsNotNullOrEmpty_Returns_False_If_String_Is_Empty()
        {
            string result = string.Empty;

            Assert.IsFalse(result.IsNotNullOrEmpty());
        }

    }
}
