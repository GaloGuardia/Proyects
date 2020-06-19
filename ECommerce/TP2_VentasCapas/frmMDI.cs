using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TP2_VentasCapas
{
    public partial class frmMDI : Form
    {
        public frmMDI()
        {
            InitializeComponent();
        }

        private void btArticulos_Click(object sender, EventArgs e)
        {
            frmArticulos f = new frmArticulos();
            f.MdiParent = this;
            f.Show();
        }

        private void frmMDI_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de que desea cerrar el sistema?",
                "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}
