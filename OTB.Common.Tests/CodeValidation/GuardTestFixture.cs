using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OTB.Common.CodeValidation;

namespace OTB.Common.Tests.CodeValidation
{
    [TestClass]
    public class GuardTestFixture
    {
        [TestMethod]
        public void Ensure_ArgumentNotNull_Throws_Correct_ExceptionType()
        {
            string argument = null;

            try
            {
                Guard.ArgumentNotNull(argument, "argument");
            }
            catch(Exception ex)
            {
                Assert.AreEqual(ex.GetType(), typeof(ArgumentNullException));
            }
        }

        [TestMethod]
        public void Ensure_ArgumentNotNull_Exception_Has_Correct_Exception_Source()
        {
            string argument = null;

            try
            {
                Guard.ArgumentNotNull(argument, "argument");
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.GetType(), typeof(ArgumentNullException));
                Assert.AreEqual(ex.Source, this.GetType().Assembly.FullName);
            }
        }
    }
}
