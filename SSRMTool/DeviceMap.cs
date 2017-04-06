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
                            int[] point = new int[] { x, y };
                            if (InPolygon(point, Regions[i].Polygon))
                            {
                                function = Regions[i].Function;
                                break;
                            }
                        }
                        NewImage[x, y] = Math.Log10(DeviceMap.CalculatePixel(function, Image[x, y], "x"));
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
        public static bool InPolygon(int[] point,List<int[]> Polygon)
        {
            //Algorithm inspired by: http://www.geeksforgeeks.org/how-to-check-if-a-given-point-lies-inside-a-polygon/
            if (Polygon.Count<3) return false;
            int[] extreme = new int[] { 10000, point[1] };
            int count = 0, i = 0;
            do
            {
                int next = (i + 1) % (Polygon.Count);
                if (doIntersect(new List<int[]>{Polygon[i], Polygon[next]}, new List<int[]> { point, extreme }))
                {
                    if (orientation(Polygon[i], point, Polygon[next]) == 0)
                        return onSegment(Polygon[i], point, Polygon[next]);
                    count++;
                }
                i = next;
            } while (i != 0);
            return (count%2 == 1);
        }
        public static bool onSegment(int[] p, int[] q, int[] r)
        {
            //segment is [x,y],[x,y] for the two points defining the line segment
            //point is the [x,y] of the point being evaluated
            return (q[0] <= Math.Max(p[0], r[0]) 
                && q[0] >= Math.Min(p[0], r[0]) 
                && q[1] <= Math.Max(p[1], r[1]) 
                && q[1] >= Math.Min(p[1], r[1]));
        }
        public static int orientation(int[] p, int[] q, int[] r)
        {
            int val = (q[1] - p[1]) * (r[0] - q[0]) - (q[0] - p[0]) * (r[1] - q[1]);
            if (val == 0) return 0;
            return (val > 0) ? 1 : 2;
        }
        public static bool doIntersect(List<int[]> polysegment, List<int[]> pointsegment)
        {
            int o1 = orientation(polysegment[0], polysegment[1], pointsegment[0]);
            int o2 = orientation(polysegment[0], polysegment[1], pointsegment[1]);
            int o3 = orientation(pointsegment[0], pointsegment[1], polysegment[0]);
            int o4 = orientation(pointsegment[0], pointsegment[1], polysegment[1]);
            if (o1 != o2 && o3 != o4) return true;
            if (o1 == 0 && onSegment(polysegment[0], pointsegment[0], polysegment[1])) return true;
            if (o2 == 0 && onSegment(polysegment[0], pointsegment[1], polysegment[1])) return true;
            if (o3 == 0 && onSegment(pointsegment[0], polysegment[1], pointsegment[1])) return true;
            if (o4 == 0 && onSegment(pointsegment[0], polysegment[1], pointsegment[1])) return true;
            return false;
        }
    }
}
