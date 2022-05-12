using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Guider
{
    public partial class GuiderForm : Form
    {
        public GuiderForm()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int nextIdx = tabControl.SelectedIndex + 1;
            if (nextIdx > tabControl.TabCount - 1)
                Close();
            else
            {
                tabControl.SelectTab(nextIdx);
                if (nextIdx == tabControl.TabCount - 1)
                    btnNext.Text = "完成";
            }
        }
    }
}
