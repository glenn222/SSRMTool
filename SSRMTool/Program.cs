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
        public static int Main(string[] args)
        {
            GwyddionLibraryAdapter wrapper = new GwyddionLibraryAdapter();
            double[,] ChannelData = wrapper.GetChannelData("d19_tip11.gwy", 3);
            List<double> indep = new List<double>(new double[] { -2.51, -2.38, -2.02, -1.77, -1.11 });
            List<double> dep = new List<double>(new double[] { 7.79e19, 2.9e19, 2e19, 5e18, 2.7e18 });
            //List<double> dep = new List<double>(new double[] { 0.000537, 0.000997, 0.001191, 0.02554, 0.003709 });
            string function = SSRMTool.Staircase.PiecewiseFit(indep, dep, "[x]");
            DeviceMap A = new DeviceMap(ChannelData, function);
            //double[,] NewChannel = calculate
            bool success = wrapper.WriteNewFile(ChannelData, "d19_tip11_ch3.gwy", "Ohm");
            Console.WriteLine(ChannelData.Length);
            Console.WriteLine(success);
            Console.WriteLine(ChannelData[0, 0]);
            Console.ReadKey();
            return 0;
        }

        public static async Task<double[,]> calculate(DeviceMap A)
        {
            return await A.Calculate();
        }
    }
}
