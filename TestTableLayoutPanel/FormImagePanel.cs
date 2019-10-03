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
    public partial class FormImagePanel : Form
    {
        public FormImagePanel()
        {
            InitializeComponent();
            doCheckedRows();
            doCheckedCols();
        }

        private void doCheckedRows()
        {
            if (canSplitRowsToolStripMenuItem.Checked)
            {
                canSplitRowsToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            }
            else
            {
                canSplitRowsToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text;
            }
            splitTableLayoutPanel1.CanSplitRows = canSplitRowsToolStripMenuItem.Checked;
        }

        private void doCheckedCols()
        {
            if (canSplitColsToolStripMenuItem.Checked)
            {
                canSplitColsToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            }
            else
            {
                canSplitColsToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text;
            }
            splitTableLayoutPanel1.CanSplitCols = canSplitColsToolStripMenuItem.Checked;
        }

        private void canSplitRowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doCheckedRows();
        }

        private void canSplitColsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doCheckedCols();
        }
    }
}
