using NCalc;
using System.Collections.Generic;
using System.Drawing;

namespace SSRMTool
{
    class Region
    {
        public Expression Function;
        public List<int[]> Polygon;
        public string Material;
        public Region(Expression f, List<int[]> p, string m)
        {
            Function = f;
            Polygon = p;
            Material = m;
        }
    }
}
