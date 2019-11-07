using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using UserControls;

namespace TestTableLayoutPanel
{
    public partial class FormMain : Form
    {
        private int DELTA_WIDTH = 100;
        private System.Drawing.Size PanelFilm_IniSize;
        private System.Drawing.Size FormMain_IniSize;
        private System.Drawing.Size FormMain_ActualSize;

        public FormMain()
        {
            InitializeComponent();

            if (0 != ConfigurationManager.AppSettings["DELTA_WIDTH"].CompareTo(string.Empty))
            {
                DELTA_WIDTH = Convert.ToInt32(ConfigurationManager.AppSettings["DELTA_WIDTH"]);
            }
            StripPanel4ToolStripMenuItem.Checked = true;
            doCheckedSplitPanel1toolStripMenuItem(); //check for tableLayoutPanel1 enable split
            doCheckedSplitPanel3toolStripMenuItem(); //check for tableLayoutPanel3 enable split
            doCheckedSplitPanel4toolStripMenuItem(); //check for tableLayoutPanel4 enable split

            this.Resize += new System.EventHandler(this.FormMain_Resize);
            this.panelFilm.Resize += new System.EventHandler(this.panelFilm_Resize);
            this.MaximizeBox = false;
            this.MinimumSize = new Size(this.Size.Width, this.Size.Height); 
            this.MaximumSize = new Size(this.Size.Width + DELTA_WIDTH, this.Size.Height);
            panelToolContainer.MinimumSize = new Size(panelToolContainer.Size.Width, panelToolContainer.Size.Height);
            panelToolContainer.MaximumSize = new Size(panelToolContainer.Size.Width, panelToolContainer.Size.Height);
            panelFilm.MinimumSize = new Size(panelFilm.Width, panelFilm.Height);
            panelFilm.MaximumSize = new Size(panelFilm.Width + DELTA_WIDTH, panelFilm.Height);
            panelCustomSteps.Dock = DockStyle.Left;
            PanelFilm_IniSize = new System.Drawing.Size(panelFilm.Width, panelFilm.Height);
            FormMain_IniSize = new System.Drawing.Size(this.Width, this.Height);
            FormMain_ActualSize = new System.Drawing.Size(FormMain_IniSize.Width, FormMain_IniSize.Height);
            printPanelFilmSize();
        }

        private void printPanelFilmSize()
        {
            toolStripStatusLabel1.Text = string.Format(" Main form({0},{1}) - Film({2},{3}) - ToolContainer({4},{5})", 
                this.Width, this.Height, panelFilm.Width, panelFilm.Height, panelToolContainer.Width, panelToolContainer.Height);
        }

        private void doRefresh_FormMain_ActualSize()
        {
            int deltaWidth = panelFilm.Width - PanelFilm_IniSize.Width;
            FormMain_ActualSize.Width = FormMain_IniSize.Width + deltaWidth;
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

        private void FormMain_Load(object sender, EventArgs e)
        {
            int[] colsWidth = tableLayoutPanel4.GetColumnWidths();
            tableLayoutPanel4.BoundCols.Add(new System.Drawing.PointF(colsWidth[0], colsWidth[0] + DELTA_WIDTH));
        }

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

        private void FormMain_Resize(object sender, EventArgs e)
        {
            printPanelFilmSize();
        }

        private void panelFilm_Resize(object sender, EventArgs e)
        {
            doRefresh_FormMain_ActualSize();
            this.Size = new Size(FormMain_ActualSize.Width, FormMain_ActualSize.Height);
        }

    }
}
