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
            gvFactura.DataSource = CN.ListarFactura().Tables[0];
            gvFactura.Columns["int_IdFactura"].HeaderText = "ID Factura";
            gvFactura.Columns["int_IdEmpleado"].HeaderText = "Empleado";
            gvFactura.Columns["int_IdCliente"].HeaderText = "Cliente";
            gvFactura.Columns["mny_Total"].HeaderText = "Total";
            gvFactura.Columns["dtm_Fecha"].HeaderText = "Fecha";
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ActualizarFacturacion();
        }
    }
}
