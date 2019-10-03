namespace TestTableLayoutPanel
{
    partial class FormConsole
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsole));
            this.splitRowsTablePanel1 = new UserControls.SplitRowsTablePanel();
            this.panel_blue = new System.Windows.Forms.Panel();
            this.panel_green = new System.Windows.Forms.Panel();
            this.panel_red = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.canSplitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitRowsTablePanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitRowsTablePanel1
            // 
            this.splitRowsTablePanel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitRowsTablePanel1.CanSplitRows = false;
            this.splitRowsTablePanel1.ColumnCount = 1;
            this.splitRowsTablePanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.splitRowsTablePanel1.Controls.Add(this.panel_blue, 0, 2);
            this.splitRowsTablePanel1.Controls.Add(this.panel_green, 0, 1);
            this.splitRowsTablePanel1.Controls.Add(this.panel_red, 0, 0);
            this.splitRowsTablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitRowsTablePanel1.Location = new System.Drawing.Point(0, 28);
            this.splitRowsTablePanel1.Name = "splitRowsTablePanel1";
            this.splitRowsTablePanel1.RowCount = 3;
            this.splitRowsTablePanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.3F));
            this.splitRowsTablePanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.3F));
            this.splitRowsTablePanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.4F));
            this.splitRowsTablePanel1.Size = new System.Drawing.Size(582, 325);
            this.splitRowsTablePanel1.SplitterSize = 3;
            this.splitRowsTablePanel1.TabIndex = 0;
            // 
            // panel_blue
            // 
            this.panel_blue.BackColor = System.Drawing.Color.Blue;
            this.panel_blue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_blue.Location = new System.Drawing.Point(3, 219);
            this.panel_blue.Name = "panel_blue";
            this.panel_blue.Size = new System.Drawing.Size(576, 103);
            this.panel_blue.TabIndex = 3;
            // 
            // panel_green
            // 
            this.panel_green.BackColor = System.Drawing.Color.Green;
            this.panel_green.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_green.Location = new System.Drawing.Point(3, 111);
            this.panel_green.Name = "panel_green";
            this.panel_green.Size = new System.Drawing.Size(576, 102);
            this.panel_green.TabIndex = 2;
            // 
            // panel_red
            // 
            this.panel_red.BackColor = System.Drawing.Color.Red;
            this.panel_red.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_red.Location = new System.Drawing.Point(3, 3);
            this.panel_red.Name = "panel_red";
            this.panel_red.Size = new System.Drawing.Size(576, 102);
            this.panel_red.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.canSplitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(582, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // canSplitToolStripMenuItem
            // 
            this.canSplitToolStripMenuItem.CheckOnClick = true;
            this.canSplitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("canSplitToolStripMenuItem.Image")));
            this.canSplitToolStripMenuItem.Name = "canSplitToolStripMenuItem";
            this.canSplitToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.canSplitToolStripMenuItem.Text = "Can split";
            this.canSplitToolStripMenuItem.Click += new System.EventHandler(this.canSplitToolStripMenuItem_Click);
            // 
            // FormConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 353);
            this.Controls.Add(this.splitRowsTablePanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormConsole";
            this.Text = "FormConsole";
            this.splitRowsTablePanel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.SplitRowsTablePanel splitRowsTablePanel1;
        private System.Windows.Forms.Panel panel_red;
        private System.Windows.Forms.Panel panel_blue;
        private System.Windows.Forms.Panel panel_green;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem canSplitToolStripMenuItem;
    }
}