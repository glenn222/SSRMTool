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

        private void btn_QuitProgram_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
