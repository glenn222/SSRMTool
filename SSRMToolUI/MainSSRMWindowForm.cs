using System;
using System.Windows.Forms;

namespace SSRMToolUI
{
    public partial class MainSSRMWindowForm : Form
    {
        public MainSSRMWindowForm()
        {
            InitializeComponent();
        }

        private void btn_DefineStaircases_Click(object sender, EventArgs e)
        {
            DefineStaircaseWindowForm.GetStairCaseInstance().Show();
        }

        private void btn_QuantifyDevices_Click(object sender, EventArgs e)
        {
            QuantifyDeviceWindow.GetQuantifyDeviceInstance().Show();
        }

        private void btn_QuitProgram_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
