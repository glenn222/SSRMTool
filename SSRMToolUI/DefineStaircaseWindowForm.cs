using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSRMToolUI
{
    public partial class DefineStaircaseWindowForm : Form
    {
        private static DefineStaircaseWindowForm _staircaseInstance = null;

        private DefineStaircaseWindowForm()
        {
            InitializeComponent();
        }

        public static DefineStaircaseWindowForm GetStairCaseInstance()
        {
            if (_staircaseInstance == null)
                _staircaseInstance = new DefineStaircaseWindowForm();

            return _staircaseInstance;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap myBitmap = new Bitmap(@"turtle island.jpg");
            Graphics g = Graphics.FromImage(myBitmap);

            Rectangle rect = new Rectangle();
            PaintEventArgs eventArgs = new PaintEventArgs(g, rect);

            Image newImage = Image.FromFile("turtle island.jpg");
            PointF ulCorner = new PointF(100.0F, 100.0F);

            eventArgs.Graphics.DrawImage(newImage, ulCorner);
        }

        private void btn_OpenStaircases_Click(object sender, EventArgs e)
        {
            OpenStaircaseDataWindow.GetInstance().Show();
        }
    }
}
