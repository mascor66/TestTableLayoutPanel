using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserControls;

namespace TestTableLayoutPanel
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            doCheckedSplitPanel1toolStripMenuItem(); //check for tableLayoutPanel1 enable split
            doCheckedSplitPanel3toolStripMenuItem(); //check for tableLayoutPanel3 enable split
            doCheckedSplitPanel4toolStripMenuItem(); //check for tableLayoutPanel4 enable split
        }

        #region Splitting enable methods
        private void doCheckedSplitPanel1toolStripMenuItem()
        {
            if (StripPanel1ToolStripMenuItem.Checked)
            {
                StripPanel1ToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            }
            else
            {
                StripPanel1ToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text;
            }
            tableLayoutPanel1.CanSplitCols = StripPanel1ToolStripMenuItem.Checked;
        }

        private void doCheckedSplitPanel3toolStripMenuItem()
        {
            if (StripPanel3ToolStripMenuItem.Checked)
            {
                StripPanel3ToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            }
            else
            {
                StripPanel3ToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text;
            }
            tableLayoutPanel3.CanSplitRows = StripPanel3ToolStripMenuItem.Checked;
        }

        private void doCheckedSplitPanel4toolStripMenuItem()
        {
            if (StripPanel4ToolStripMenuItem.Checked)
            {
                StripPanel4ToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            }
            else
            {
                StripPanel4ToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text;
            }
            tableLayoutPanel4.CanSplitCols = StripPanel4ToolStripMenuItem.Checked;
        }

        #endregion

        private void helpToolStripButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Help", Application.ProductName);
        }

        private void uscitaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_ip_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Image panel", Application.ProductName);
            FormImagePanel aFormImagePanel = new FormImagePanel();
            try
            {
                aFormImagePanel.ShowDialog();
            }
            finally
            {
                aFormImagePanel.Dispose();
            }
        }

        private void button_o_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Outputs setup", Application.ProductName);
        }

        private void button_s_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Statistics", Application.ProductName);
        }

        private void button_c_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Console", Application.ProductName);
            FormConsole aFormConsole = new FormConsole();
            try
            {
                aFormConsole.ShowDialog();
            }
            finally
            {
                aFormConsole.Dispose();
            }
        }

        private void StripPanel1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doCheckedSplitPanel1toolStripMenuItem();
        }

        private void StripPanel3toolStripMenuItem_Click(object sender, EventArgs e)
        {
            doCheckedSplitPanel3toolStripMenuItem();
        }

        private void stripPanel4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doCheckedSplitPanel4toolStripMenuItem();
        }
    }
}
