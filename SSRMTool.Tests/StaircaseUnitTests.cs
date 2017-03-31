using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SSRMTool.Tests
{
    /// <summary>
    /// Summary description for FunctionsUnitTest
    /// </summary>
    [TestClass]
    public class StaircaseUnitTests
    {
        public StaircaseUnitTests()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestStringBuilder()
        {
            List<double> indep = new List<double>(new double[] { });
            List<double> dep = new List<double>(new double[] { });
            string output = SSRMTool.Staircase.PiecewiseFit(indep, dep, "[x]", "1e6", "tanh", "exp");
            Console.WriteLine(output);
            bool test0 = (output == "");

            indep = new List<double>(new double[] { 1, 2 });
            dep = new List<double>(new double[] { 1, 10 });
            output = SSRMTool.Staircase.PiecewiseFit(indep, dep, "[x]", "1e6", "tanh", "exp");
            Console.WriteLine(output);
            bool test1 = (output == "exp(2.30258509299405*[x]+(-2.30258509299405))*0.5*(1+tanh(-1e6*([x]-(2))))");

            //out-of-order next;

            Assert.IsTrue(test0 && test1);
        }
    }
}
