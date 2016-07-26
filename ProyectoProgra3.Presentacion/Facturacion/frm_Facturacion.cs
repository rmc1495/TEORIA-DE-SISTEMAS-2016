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
            GvFactura.DataSource = CN.ListarFactura().Tables[0];
            GvFactura.Columns["int_IdFactura"].HeaderText = "ID Factura";
            GvFactura.Columns["int_IdEmpleado"].HeaderText = "Empleado";
            GvFactura.Columns["int_IdCliente"].HeaderText = "Cliente";
            GvFactura.Columns["mny_Total"].HeaderText = "Total";
            GvFactura.Columns["dtm_Fecha"].HeaderText = "Fecha";
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ActualizarFacturacion();
        }
    }
}
