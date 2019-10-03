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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
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
    }
}
