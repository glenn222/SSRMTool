using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using NCalc;
using System.Diagnostics;

namespace SSRMTool.Tests
{
    [TestClass]
    public class CalculationBlackbox
    {
        [TestMethod]
        public void BuildFunctionEmpty()
        {
            List<double> indep = new List<double>(new double[] { });
            List<double> dep = new List<double>(new double[] { });
            string output = SSRMTool.Staircase.PiecewiseFit(indep, dep, "[x]", "1e12", "tanh", "exp");
            Console.WriteLine(output);
            bool isempty = (output == "1+0*[x]");
            Assert.IsTrue(isempty);
        }
        [TestMethod]
        public void BuildFunction2Elements()
        {
            List<double> indep = new List<double>(new double[] { 1, 2 });
            List <double> dep = new List<double>(new double[] { 1, 10 });
            string output = SSRMTool.Staircase.PiecewiseFit(indep, dep, "[x]", "1e12", "(2/3.14159265359)*Atan", "Exp");
            Expression function = new Expression(output);
            Console.WriteLine(output);
            bool vals_match = true;
            double val;
            for (int i = 0; i < indep.Count; i++)
            {
                function.Parameters["x"] = indep[i];
                val = (double)function.Evaluate();
                Console.WriteLine(val);
                vals_match = vals_match && (val - dep[i] < 0.001);
            }
            Assert.IsTrue(vals_match);
        }
        [TestMethod]
        public void ExpressionOutputMatching()
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
            
            Assert.IsTrue(vals_match);
        }
        [TestMethod]
        public void ExpressionOutputMatchingUnsorted()
        {
            List<double> indep = new List<double>(new double[] { 1, 2, 5, 4, 3 });
            List<double> dep = new List<double>(new double[] { 1, 10, 10000, 1000, 100 });
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
            Assert.IsTrue(vals_match);
        }
        [TestMethod]
        public void IllegalExpressionInputs()
        {
            List<double> indep = new List<double>(new double[] { 1, 1, 2 });
            List<double> dep = new List<double>(new double[] { -20, 2, 0 });
            string output = SSRMTool.Staircase.PiecewiseFit(indep, dep, "[x]");
            Expression function = new Expression(output);
            function.Parameters["x"] = 0.0;
            double val = (double)function.Evaluate();
            bool valmatch = val == 20;
            Assert.IsTrue(valmatch);
        }
        [TestMethod]
        public void ExpressionOutputMatchingNonmonotonic()
        {
            List<double> indep = new List<double>(new double[] { 1, 2, 3, 4, 5 });
            List<double> dep = new List<double>(new double[] { 1, 10, 10000, 1000, 100 });
            string output = SSRMTool.Staircase.PiecewiseFit(indep, dep, "[x]");
            Expression function = new Expression(output);
            bool vals_match = true;
            double val;
            for (int i = 0; i < indep.Count; i++)
            {
                function.Parameters["x"] = indep[i];
                val = (double)function.Evaluate();
                //Console.WriteLine(val);
                vals_match = vals_match && (val - dep[i] < 0.001);
            }
            Assert.IsTrue(vals_match);
        }
        [TestMethod]
        public void RuntimeAcceptance()
        {
            List<double> indep = new List<double>(new double[] { 1, 2, 3, 4, 5 });
            List<double> dep = new List<double>(new double[] { 1, 10, 100, 1000, 10000 });
            string output = SSRMTool.Staircase.PiecewiseFit(indep, dep, "[x]");
            Expression function = new Expression(output);
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
            Assert.IsTrue(test_time);
        }
    }
}
