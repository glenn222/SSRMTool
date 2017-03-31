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
    public partial class QuantifyDeviceWindow : Form
    {

        private static QuantifyDeviceWindow _quantifyDeviceWindow = null;

        private QuantifyDeviceWindow()
        {
            InitializeComponent();
        }

        public static QuantifyDeviceWindow GetQuantifyDeviceInstance()
        {
            if (_quantifyDeviceWindow == null || _quantifyDeviceWindow.IsDisposed)
                _quantifyDeviceWindow = new QuantifyDeviceWindow();
            
            return _quantifyDeviceWindow;
        }
    }
}
