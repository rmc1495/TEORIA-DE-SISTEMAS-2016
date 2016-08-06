using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace ProyectoProgra3.Devolucion
{
    public partial class frm_Devolucion : Form
    {
        Devolucion.CN_Devolucion CN = new Devolucion.CN_Devolucion();

        public frm_Devolucion()
        {
            InitializeComponent();
            cBoxFiltrar.DataSource = CN.ComboBoxNombreColumna().Tables[0];
            cBoxFiltrar.DisplayMember = "name";
            cBoxFiltrar.ValueMember = "name";
            ListarDevolucion();

        }
        void ListarDevolucion()
        {
            gvDevolucion.DataSource = CN.ListarDevolucion().Tables[0];
        }

        private void txtFiltrar_TextChanged(object sender, EventArgs e)
        {
            if(txtFiltrar.Text.Trim() == "")
            { ListarDevolucion(); }
            else{
            gvDevolucion.DataSource = CN.FiltrarDevolucion(cBoxFiltrar.SelectedValue.ToString(), txtFiltrar.Text).Tables[0];
            }
        }

        private void cBoxFiltrar_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cBoxFiltrar.SelectedValue.ToString().Trim() == "" || txtFiltrar.Text.Trim() == "")
            { }
            else
            {
                txtFiltrar_TextChanged(sender, e);
            }
        }

        private void gvDevolucion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int ColumnaSeleccionada = gvDevolucion.CurrentCell.RowIndex;

                Facturacion.CN_Facturacion CN = new Facturacion.CN_Facturacion();
                DataTable ConsultaNombre = CN.ObtenerNombreEmpleado(gvDevolucion.Rows[ColumnaSeleccionada].Cells[2].FormattedValue.ToString().Trim()).Tables[0];
                txtNombreEmpleado.Text = ConsultaNombre.Rows[0][0].ToString().Trim() + " " + ConsultaNombre.Rows[0][1].ToString().Trim() + " " + ConsultaNombre.Rows[0][2].ToString().Trim();


            }
            catch (Exception)
            {
            }
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            txtFiltrar.Text = "";
            ListarDevolucion();
        }

        private void tlsBtnRegis_Limpiar_Click(object sender, EventArgs e)
        {
            txtFiltrar.Text = "";
            txtNombreEmpleado.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int ColumnaSeleccionada = gvDevolucion.CurrentCell.RowIndex;
            if (ColumnaSeleccionada >= 0)
            {
                CN.EliminarDevolucion(gvDevolucion.Rows[ColumnaSeleccionada].Cells[0].FormattedValue.ToString().Trim());
                MessageBox.Show("Dato eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                tlsBtnRegis_Limpiar_Click(sender,e);
            }
            else
            {
            }

        }


    }
}
