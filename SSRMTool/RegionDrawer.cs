using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSRMTool
{
    class RegionDrawer
    {
        public void DrawPolygon()
        {
            Bitmap myBitmap = new Bitmap(@"turtle island.jpg");
            Graphics g = Graphics.FromImage(myBitmap);

            Rectangle rect = new Rectangle();
            //PaintEventArgs eventArgs = new PaintEventArgs(g, rect);

            Image newImage = Image.FromFile("turtle island.jpg");
            PointF ulCorner = new PointF(100.0F, 100.0F);

            //eventArgs.Graphics.DrawImage(newImage, ulCorner);
        }
    }
}
