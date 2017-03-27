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
            double[,] NewImage = new double[10, 10];
            //for each point determine region and do following:
            Regions[0].Function.Parameters["x"] = Image[0,0];
            NewImage[0,0] = (double)Regions[0].Function.Evaluate();
            return NewImage;
        }

    }
}
