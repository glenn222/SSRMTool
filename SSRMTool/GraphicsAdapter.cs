using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SSRMTool
{
    public static class GraphicsAdapter
    {
        public static Pen Pen
        {
            get
            {
                return _pen;
            }
            set
            {
                _pen = value;
            }
        }

        public static Brush Brush
        {
            get
            {
                return _brush;
            }
            set
            {
                _brush = value;
            }
        }

        // Defaults
        private const int PEN_WIDTH = 3;
        private const int OFFSET_X = 5;
        private const int OFFSET_Y = 5;

        private static Pen _pen = new Pen(Color.LightGoldenrodYellow, PEN_WIDTH);
        private static Brush _brush = new SolidBrush(Color.Snow);
        
        public static void DrawPolygon(Graphics g, List<int[]> points)
        {
            var polygonPoints = new List<Point>(points.Count);
            foreach (var point in points)
                polygonPoints.Add(new Point(point[0], point[1]));
            
            using (g)
            {
                g.DrawPolygon(_pen, polygonPoints.ToArray());
            }
        }

        public static void DrawPoint(Graphics g, int x, int y)
        {
            using (g)
            {
                var point = new Point(x, y);
                point.X = point.X - OFFSET_X;
                point.Y = point.Y - OFFSET_Y;
                var rect = new Rectangle(point, new Size(OFFSET_X * 2, OFFSET_Y * 2));

                g.FillEllipse(_brush, rect);
            }
        }
    }
}
