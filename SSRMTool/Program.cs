using System;
using System.Collections.Generic;
using NCalc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SSRMTool
{
    class Program
    {
        public static void Main(string[] args)
        {
            //GwyddionLibraryAdapter wrapper = new GwyddionLibraryAdapter();
            //var res = wrapper.GetConnectSession(0, "key", '3');
            //var res = wrapper.TestGwyddionSession(0, "key", '3');
            //var res = wrapper.TestGwyddionSession();
            //Console.WriteLine(res);
            //Console.ReadKey();
            List<double> indep = new List<double>(new double[] { 1, 2, 3, 4 });
            List<double> dep = new List<double>(new double[] { 10, 50, 300, 1000 });
            Console.WriteLine("Initiated");
            Expression e = new Expression(Staircase.PiecewiseFit(indep, dep, "[d1]"));//"Exp(1.6094379124341 *[d1] + (0.693147180559946)) * 0.5 * (1 + (2 / 3.14159265359) * Atan(-1e6 * ([d1] - (2)))) + Exp(1.79175946922805 *[d1] + (0.328504066972036)) * 0.5 * (2 / 3.14159265359) * Atan(1e6 * ([d1] - (2))) - (2 / 3.14159265359) * Atan(1e6 * ([d1] - (3)))) + Exp(1.20397280432594 *[d1] + (2.09186406167839)) * 0.5 * (1 + (2 / 3.14159265359) * Atan(1e6 * ([d1] - (3))))"            
            Console.WriteLine(Staircase.PiecewiseFit(indep, dep, "[d1]"));
            for (int i = 0; i < 1000000; i++)
            {
                e.Parameters["d1"] = i;
                double d = (double)e.Evaluate();
                //Console.WriteLine(d);
            }
            Console.WriteLine("Done");
            Console.ReadKey();
        }
    }
}
