using System;
using System.Drawing;
using System.Windows.Forms;

namespace TP_2___FInal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ingresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSistema sistema = new frmSistema();
            this.Size = new Size(sistema.Width + 20, sistema.Height + 45);
            sistema.MdiParent = this;
            sistema.Show();
        }

        private void informesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Informes informes = new Informes();
            informes.MdiParent = this;
            informes.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
