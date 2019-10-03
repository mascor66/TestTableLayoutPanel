using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestTableLayoutPanel
{
    public partial class FormConsole : Form
    {
        public FormConsole()
        {
            InitializeComponent();
            doChecked();
        }

        private void canSplitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doChecked();
        }

        private void doChecked()
        {
            if (canSplitToolStripMenuItem.Checked)
            {
                canSplitToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            }
            else
            {
                canSplitToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text;
            }
            splitRowsTablePanel1.CanSplitRows = canSplitToolStripMenuItem.Checked;
        }
    }
}
