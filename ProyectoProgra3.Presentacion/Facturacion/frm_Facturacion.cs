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
            gvFactura.Columns["Int_IdFactura"].HeaderText = "ID Factura";
            gvFactura.Columns["Int_IdEmpleado"].HeaderText = "Empleado";
            gvFactura.Columns["Int_IdCliente"].HeaderText = "Cliente";
            gvFactura.Columns["Mny_Total"].HeaderText = "Total";
            gvFactura.Columns["Dtm_Fecha"].HeaderText = "Fecha";
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

                CN.Dato = gvFactura.Rows[ColumnaSeleccionada].Cells[2].FormattedValue.ToString().Trim();
                txtNombreEmpleado.Text = CN.ObtenerNombreEmpleado(CN.Dato);
                CN.Dato=  gvFactura.Rows[ColumnaSeleccionada].Cells[3].FormattedValue.ToString().Trim();
                txtNombreCliente.Text = CN.ObtenerNombreCliente(CN.Dato);
                
                CN.V_id = gvFactura.Rows[ColumnaSeleccionada].Cells[1].FormattedValue.ToString().Trim();
                
                
                gvDetalleFactura.DataSource = CN.FiltrarDetalleFactura(CN.V_id).Tables[0];
                
                gvDetalleFactura.Columns["int_IdDetalleFactura"].HeaderText = "ID";
                gvDetalleFactura.Columns["Int_Linea"].HeaderText = "Linea";
                gvDetalleFactura.Columns["Int_IdArticulo"].HeaderText = "IdArticulo";
                gvDetalleFactura.Columns["Int_IdServicio"].HeaderText = "IdServicio";
                gvDetalleFactura.Columns["Int_Cantidad"].HeaderText = "Cantidad";
                gvDetalleFactura.Columns["mny_monto"].HeaderText = "Precio";
                gvDetalleFactura.Columns["Mny_Impuesto"].HeaderText = "Impuesto";
                gvDetalleFactura.Columns["int_Descuento"].HeaderText = "Descuento";

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
            Facturacion.CN_Facturacion CN = new Facturacion.CN_Facturacion();

            CN.Dato = gvDetalleFactura.Rows[ColumnaSeleccionada].Cells[2].FormattedValue.ToString().Trim();
            txtNombreArticulo .Text = CN.ObtenerNombreArticulo(CN.Dato);
            CN.Dato = gvDetalleFactura.Rows[ColumnaSeleccionada].Cells[3].FormattedValue.ToString().Trim();
            txtNombreServicio.Text = CN.ObtenerNombreServicio(CN.Dato);

        }

        private void txtFiltrar_TextChanged(object sender, EventArgs e)
        {
            if (txtFiltrar.Text.Trim() == "")
            {
                ActualizarFacturacion();
            }
            else 
            {
                Facturacion.CN_Facturacion CN = new Facturacion.CN_Facturacion();

                gvFactura.DataSource = CN.FiltrarFactura(txtFiltrar.Text.Trim(), cBoxFiltrar.SelectedValue.ToString().Trim()).Tables[0];
                gvFactura.Columns["Int_IdFactura"].HeaderText = "ID Factura";
                gvFactura.Columns["Int_IdEmpleado"].HeaderText = "Empleado";
                gvFactura.Columns["Int_IdCliente"].HeaderText = "Cliente";
                gvFactura.Columns["Mny_Total"].HeaderText = "Total";
                gvFactura.Columns["Dtm_Fecha"].HeaderText = "Fecha";
            }
        }

        
    }
}
