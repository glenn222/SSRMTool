using System;
using NCalc;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSRMTool
{
    class DeviceMap
    {
        List<Region> Regions;
        DeviceImage Source;
        double[,] Image;
        Expression Background;
        public DeviceMap(DeviceImage s, Expression b)
        {
            Regions = new List<Region>();
            Background = b;
            Source = s;
            Image = Source.PullChannel();
        }
        public void AddRegion(Expression f, List<int[]> p, string m)
        {
            Regions.Add(new Region(f, p, m));
        }
        public double[,] Calculate()
        {
            double[,] NewImage = new double[Image.Length, Image.Length];
            //for each point determine region and do following:
            NewImage[0,0] = DeviceMap.CalculatePixel(Background,Image[0,0],"x");
            return NewImage;
        }
        public static double CalculatePixel(Expression f, double Measured, string var="x")
        {
            f.Parameters[var] = Measured;
            return (double)f.Evaluate();
        }
    }
}
