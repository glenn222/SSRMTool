using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class TestStaircase
    {
        public static bool TestStringBuilder()
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

            return test0&&test1;
        }
    }
}
