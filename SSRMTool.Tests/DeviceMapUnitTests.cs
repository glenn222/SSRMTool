using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using NCalc;
using System.Diagnostics;

namespace SSRMTool.Tests
{
    [TestClass]
    public class DeviceMapUnitTests
    {
        [TestMethod]
        public void TestExpressionOutput()
        {
            List<double> indep = new List<double>(new double[] { 1, 2, 3, 4, 5 });
            List<double> dep = new List<double>(new double[] { 1, 10, 100, 1000, 10000 });
            string output = SSRMTool.Staircase.PiecewiseFit(indep, dep, "[x]");
            Expression function = new Expression(output);
            bool vals_match = true;
            double val;
            for (int i = 0; i < indep.Count; i++)
            {
                function.Parameters["x"] = indep[i];
                val = (double)function.Evaluate();
                Console.WriteLine(val);
                vals_match = vals_match && (val - dep[i] < 0.001);
            }
            Stopwatch timer = new Stopwatch();
            int operations = 262144;
            timer.Start();
            for (int i = 0; i < operations; i++)
            {
                function.Parameters["x"] = 1;
                function.Evaluate();
            }
            timer.Stop();
            Console.WriteLine("Time for 1 million calculations (1000x1000 image): " + timer.ElapsedMilliseconds + "ms");
            bool test_time = timer.ElapsedMilliseconds < 30000;
            Assert.IsTrue(vals_match && test_time);
        }
    }
}
