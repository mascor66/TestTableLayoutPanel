using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;

namespace TestTableLayoutPanel
{
    public partial class FormImagePanel : Form
    {
        public FormImagePanel()
        {
            InitializeComponent();

            string curBounds = string.Empty;
            curBounds = ConfigurationManager.AppSettings["FormImagePanelBoundRows"];
            fillList(curBounds, splitTableLayoutPanel1.BoundRows);
            curBounds = ConfigurationManager.AppSettings["FormImagePanelBoundCols"];
            fillList(curBounds, splitTableLayoutPanel1.BoundCols);
            doCheckedRows();
            doCheckedCols();
        }

        private void fillList(string strFiller, List<System.Drawing.PointF> boundList)
        {
            if (strFiller is null) return;
            boundList.Clear();
            foreach (string curPointStr in strFiller.Split(';'))
            {
                int curIdx = 0;
                System.Drawing.PointF newPoint = new System.Drawing.PointF();
                foreach (string curPointItem in curPointStr.Split(','))
                {
                    curIdx++;
                    switch (curIdx)
                    {
                        case 1:
                            newPoint.X = Convert.ToInt32(curPointItem);
                            break;
                        case 2:
                            newPoint.Y = Convert.ToInt32(curPointItem);
                            break;
                    }
                }
                boundList.Add(newPoint);
            }
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
