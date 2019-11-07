namespace TestTableLayoutPanel
{
    partial class FormImagePanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormImagePanel));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.canSplitRowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.canSplitColsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitTableLayoutPanel1 = new UserControls.SplitTableLayoutPanel();
            this.panel_2_2 = new System.Windows.Forms.Panel();
            this.panel_2_1 = new System.Windows.Forms.Panel();
            this.panel_1_2 = new System.Windows.Forms.Panel();
            this.panel_1_1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.splitTableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.canSplitRowsToolStripMenuItem,
            this.canSplitColsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(600, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // canSplitRowsToolStripMenuItem
            // 
            this.canSplitRowsToolStripMenuItem.CheckOnClick = true;
            this.canSplitRowsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("canSplitRowsToolStripMenuItem.Image")));
            this.canSplitRowsToolStripMenuItem.Name = "canSplitRowsToolStripMenuItem";
            this.canSplitRowsToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.canSplitRowsToolStripMenuItem.Text = "Can split rows";
            this.canSplitRowsToolStripMenuItem.Click += new System.EventHandler(this.canSplitRowsToolStripMenuItem_Click);
            // 
            // canSplitColsToolStripMenuItem
            // 
            this.canSplitColsToolStripMenuItem.CheckOnClick = true;
            this.canSplitColsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("canSplitColsToolStripMenuItem.Image")));
            this.canSplitColsToolStripMenuItem.Name = "canSplitColsToolStripMenuItem";
            this.canSplitColsToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.canSplitColsToolStripMenuItem.Text = "Can split cols";
            this.canSplitColsToolStripMenuItem.Click += new System.EventHandler(this.canSplitColsToolStripMenuItem_Click);
            // 
            // splitTableLayoutPanel1
            // 
            this.splitTableLayoutPanel1.CanSplitCols = false;
            this.splitTableLayoutPanel1.CanSplitRows = false;
            this.splitTableLayoutPanel1.ColumnCount = 2;
            this.splitTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.splitTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.splitTableLayoutPanel1.Controls.Add(this.panel_2_2, 1, 1);
            this.splitTableLayoutPanel1.Controls.Add(this.panel_2_1, 0, 1);
            this.splitTableLayoutPanel1.Controls.Add(this.panel_1_2, 1, 0);
            this.splitTableLayoutPanel1.Controls.Add(this.panel_1_1, 0, 0);
            this.splitTableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitTableLayoutPanel1.Location = new System.Drawing.Point(0, 28);
            this.splitTableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.splitTableLayoutPanel1.Name = "splitTableLayoutPanel1";
            this.splitTableLayoutPanel1.RowCount = 2;
            this.splitTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.splitTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.splitTableLayoutPanel1.Size = new System.Drawing.Size(600, 338);
            this.splitTableLayoutPanel1.SplitterSize = 6;
            this.splitTableLayoutPanel1.TabIndex = 3;
            // 
            // panel_2_2
            // 
            this.panel_2_2.BackColor = System.Drawing.Color.Yellow;
            this.panel_2_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_2_2.Location = new System.Drawing.Point(302, 171);
            this.panel_2_2.Margin = new System.Windows.Forms.Padding(2);
            this.panel_2_2.Name = "panel_2_2";
            this.panel_2_2.Size = new System.Drawing.Size(296, 165);
            this.panel_2_2.TabIndex = 3;
            // 
            // panel_2_1
            // 
            this.panel_2_1.BackColor = System.Drawing.Color.Blue;
            this.panel_2_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_2_1.Location = new System.Drawing.Point(2, 171);
            this.panel_2_1.Margin = new System.Windows.Forms.Padding(2);
            this.panel_2_1.Name = "panel_2_1";
            this.panel_2_1.Size = new System.Drawing.Size(296, 165);
            this.panel_2_1.TabIndex = 2;
            // 
            // panel_1_2
            // 
            this.panel_1_2.BackColor = System.Drawing.Color.Green;
            this.panel_1_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_1_2.Location = new System.Drawing.Point(302, 2);
            this.panel_1_2.Margin = new System.Windows.Forms.Padding(2);
            this.panel_1_2.Name = "panel_1_2";
            this.panel_1_2.Size = new System.Drawing.Size(296, 165);
            this.panel_1_2.TabIndex = 1;
            // 
            // panel_1_1
            // 
            this.panel_1_1.BackColor = System.Drawing.Color.Red;
            this.panel_1_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_1_1.Location = new System.Drawing.Point(2, 2);
            this.panel_1_1.Margin = new System.Windows.Forms.Padding(2);
            this.panel_1_1.Name = "panel_1_1";
            this.panel_1_1.Size = new System.Drawing.Size(296, 165);
            this.panel_1_1.TabIndex = 0;
            // 
            // FormImagePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.splitTableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormImagePanel";
            this.Text = "FormImagePanel";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitTableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem canSplitRowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem canSplitColsToolStripMenuItem;
        private UserControls.SplitTableLayoutPanel splitTableLayoutPanel1;
        private System.Windows.Forms.Panel panel_2_2;
        private System.Windows.Forms.Panel panel_2_1;
        private System.Windows.Forms.Panel panel_1_2;
        private System.Windows.Forms.Panel panel_1_1;
    }
}