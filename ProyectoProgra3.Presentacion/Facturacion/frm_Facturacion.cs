using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoProgra3.Facturacion
{
    public partial class frm_Facturacion : Form
    {

        public frm_Facturacion()
        {
            InitializeComponent();
            ActualizarFacturacion();
        }

       
        void ActualizarFacturacion()
        {
            Facturacion.CN_Facturacion CN = new Facturacion.CN_Facturacion();


            string tabla = "tbl_Factura";
            cBoxFiltrar.DataSource = CN.ComboBoxNombreColumna(tabla).Tables[0];
            cBoxFiltrar.DisplayMember = "name";
            cBoxFiltrar.ValueMember = "name";

            gvFactura.DataSource = CN.ListarFactura().Tables[0];

            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ActualizarFacturacion();
        }

        private void gvFactura_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                try 
	            {
                int ColumnaSeleccionada  = gvFactura.CurrentCell.RowIndex;

                Facturacion.CN_Facturacion CN = new Facturacion.CN_Facturacion();
                DataTable ConsultaNombre = CN.ObtenerNombreEmpleado(gvFactura.Rows[ColumnaSeleccionada].Cells[1].FormattedValue.ToString().Trim()).Tables[0];
                txtNombreEmpleado.Text = ConsultaNombre.Rows[0][0].ToString().Trim();
                DataTable ConsultaNombreCliente = CN.ObtenerNombreCliente(gvFactura.Rows[ColumnaSeleccionada].Cells[2].FormattedValue.ToString().Trim()).Tables[0];
                txtNombreCliente.Text = ConsultaNombreCliente.Rows[0][0].ToString().Trim();
                
                CN.V_id = gvFactura.Rows[ColumnaSeleccionada].Cells[0].FormattedValue.ToString().Trim();
                
                
                gvDetalleFactura.DataSource = CN.FiltrarDetalleFactura(CN.V_id).Tables[0];
                

	            }
	            catch (Exception)
	            {
                   // ColumnaSeleccionada = 0;
		        //throw;
	            }
            
                }

        private void gvDetalleFactura_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int ColumnaSeleccionada = gvFactura.CurrentCell.RowIndex;
            try
            {
                Facturacion.CN_Facturacion CN = new Facturacion.CN_Facturacion();
                if (gvDetalleFactura.Rows[ColumnaSeleccionada].Cells[2].Value.ToString().Trim() != "")
                {
                    DataTable ConsultaNombreArticulo = CN.ObtenerNombreArticulo(gvDetalleFactura.Rows[ColumnaSeleccionada].Cells[2].Value.ToString().Trim()).Tables[0];
                    txtNombreArticulo.Text = ConsultaNombreArticulo.Rows[0][0].ToString().Trim();
                }
                else
                { }
                if (gvDetalleFactura.Rows[ColumnaSeleccionada].Cells[3].Value.ToString().Trim() != "")
                {
                    DataTable ConsultaNombreServicio = CN.ObtenerNombreServicio(gvDetalleFactura.Rows[ColumnaSeleccionada].Cells[3].Value.ToString().Trim()).Tables[0];
                    txtNombreServicio.Text = ConsultaNombreServicio.Rows[0][0].ToString().Trim();
                }
                else { }
            }
                        
            catch (Exception)
            {
                ColumnaSeleccionada = 0;
                //throw;
            }


        }

        private void txtFiltrar_TextChanged(object sender, EventArgs e)
        {
            try{
            Facturacion.CN_Facturacion CN = new Facturacion.CN_Facturacion();
            gvFactura.DataSource = CN.FiltrarFactura(cBoxFiltrar.SelectedValue.ToString(),txtFiltrar.Text).Tables[0];
            }
            catch (Exception)
            {
                //throw;
            }

        }

        private void cBoxFiltrar_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cBoxFiltrar.SelectedValue.ToString().Trim() == "" || txtFiltrar.Text.Trim()=="")
            {}
            else{
            txtFiltrar_TextChanged(sender, e);
            }
        }

        private void tlsBtnRegis_Limpiar_Click(object sender, EventArgs e)
        {
            txtFiltrar.Text = "";
            txtNombreEmpleado.Text = "";
            txtNombreCliente.Text = "";
            txtNombreArticulo.Text = "";
            txtNombreServicio.Text = "";

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        
    }
}
