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
    public partial class frmArticulos : Form
    {
        public frmArticulos()
        {
            InitializeComponent();
        }

        private void frmArticulos_Load(object sender, EventArgs e)
        {

        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }

        private void btAlta_Click(object sender, EventArgs e)
        {
            frmArticulosABM f = new frmArticulosABM();
            f.articulo = null; //Create.
            f.ShowDialog();
            ActualizarGrilla();
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            if (gv.SelectedRows.Count == 1)
            {
                int id = (int)gv.SelectedRows[0].Cells["Id"].Value;

                frmArticulosABM f = new frmArticulosABM();
                f.articulo = VentasCapas.Business.Articulos.ConsultarPorId(id); //Update.
                f.ShowDialog();
                ActualizarGrilla();
            }
        }

        private void btBaja_Click(object sender, EventArgs e)
        {
            if (gv.SelectedRows.Count == 1)
            {
                int id = (int)gv.SelectedRows[0].Cells["Id"].Value;

                if (MessageBox.Show("¿Esta completamente seguro de que desea eliminar este registro?",
                    "Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    VentasCapas.Business.Articulos.Eliminar(id);
                    ActualizarGrilla();
                }
            }
        }

        private void ActualizarGrilla()
        {
            var articulos = VentasCapas.Business.Articulos.ConsultarPorNombre(txFiltro.Text.Trim());
            gv.DataSource = articulos;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
