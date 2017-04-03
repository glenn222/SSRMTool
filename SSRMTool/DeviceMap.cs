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
        public DeviceMap(double[,] ImageData,string Function)
        {
            Regions = new List<Region>();
            Background = new Expression(Function);
            Source = new DeviceImage();
            Image = ImageData;
        }
        public DeviceMap(double[,] ImageData,Expression bground)
        {
            Regions = new List<Region>();
            Background = bground;
            Source = new DeviceImage();
            Image = ImageData;
        }
        public void AddRegion(Expression f, List<int[]> p, string m)
        {
            Regions.Add(new Region(f, p, m));
        }
        public async Task<double[,]> Calculate()
        {
            int xres = Image.GetLength(0);
            int yres = Image.GetLength(1);
            double[,] NewImage = new double[xres, yres];

            await Task.Run(() =>
            {
                for (int x = 0; x < xres; x++)
                {
                    for (int y = 0; y < yres; y++)
                    {
                        Expression function = Background;
                        for (int i = 0; i < Regions.Count; i++)
                        {
                            if (InPolygon(x, y, Regions[i].Polygon))
                            {
                                function = Regions[i].Function;
                                break;
                            }
                        }
                        NewImage[x, y] = DeviceMap.CalculatePixel(function, Image[x, y], "x");
                    }
                }
            });

            return NewImage;
        }
        public static double CalculatePixel(Expression f, double Measured, string var="x")
        {
            f.Parameters[var] = Measured;
            return (double)f.Evaluate();
        }
        public static bool InPolygon(int x,int y,List<int[]> Polygon)
        {
            return false;
        }
    }
}
