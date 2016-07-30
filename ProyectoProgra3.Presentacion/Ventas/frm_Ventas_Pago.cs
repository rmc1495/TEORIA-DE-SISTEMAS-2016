using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoProgra3.Ventas
{
    public partial class frm_Ventas_Pago : Form
    {
        Ventas.CN_Ventas CN = new Ventas.CN_Ventas();

        public frm_Ventas_Pago()
        {
            InitializeComponent();
            if (CN.Metodo_de_Pago.Trim() == "Efectivo")
            {
                txtNumeroTarjeta.Enabled = false;
                cmbEmisorTarjeta.Enabled = false;
                txtCodigoTarjeta.Enabled = false;
                txtFechaTarjeta.Enabled = false;
                groupBox2.Enabled = false;
                txtPagaEfectivo.Enabled = true;

            }
            else{}
            if (CN.Metodo_de_Pago.Trim() == "Tarjeta Credito" || CN.Metodo_de_Pago.Trim() == "Tarjeta Debito")
            {
                txtNumeroTarjeta.Enabled = true;
                cmbEmisorTarjeta.Enabled = true;
                txtCodigoTarjeta.Enabled = true;
                txtFechaTarjeta.Enabled = true;
                groupBox2.Enabled = true;
                txtPagaEfectivo.Enabled = false;
            }
            else{}

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Manda al Banco los datos

            

            //Aqui Agregar inseert a la base de datos

            Ventas.CN_Ventas CN = new Ventas.CN_Ventas();
            RRHH.CN_Empleado CNE = new RRHH.CN_Empleado(); //Empleado esperando Capa de Negocios

            CN.Int_IdEmpleado = CNE.IdEmpleado;         
            CN.Mny_Total = CN.Int_IdCliente;
            CN.Dtm_Fecha = DateTime.Now;
            CN.Int_IdFactura = (CN.AgregarFacturayDevolverValor(CN).Tables[0]).ToString().Trim(); // Revisar si me retorna un valor y enviar el insert

            int i = 1;
            while (i < CN.DetalleFactura.Rows.Count) //pasa los datos del datagridview al datatable
            {
                CN.DetalleFactura.Rows[1][i - 1] = CN.Int_IdFactura;

                CN.Int_IdFactura = CN.DetalleFactura.Rows[1][i - 1].ToString().Trim();
                CN.Int_Linea = CN.DetalleFactura.Rows[2][i - 1].ToString().Trim();
                CN.Int_IdArticulo = CN.DetalleFactura.Rows[3][i - 1].ToString().Trim();
                CN.Int_IdServicio = CN.DetalleFactura.Rows[4][i - 1].ToString().Trim();
                CN.Int_Cantidad = CN.DetalleFactura.Rows[5][i - 1].ToString().Trim();
                CN.Mny_Monto = CN.DetalleFactura.Rows[6][i - 1].ToString().Trim();
                CN.Mny_Impuesto = CN.DetalleFactura.Rows[7][i - 1].ToString().Trim();
                CN.Mny_Descuento = CN.DetalleFactura.Rows[8][i - 1].ToString().Trim();

                CN.AgregarDetallesFactura(CN);
            }

                
            frm_Ventas frmPadre = new frm_Ventas();
            frmPadre.limpiartabla();
            CN.Int_IdCliente = 1; //Cliente Default
            
            CN.Int_IdFactura = "";
            CN.Int_Linea = "";
            CN.Int_IdArticulo = "";
            CN.Int_IdServicio = "";
            CN.Int_Cantidad = "";
            CN.Mny_Monto = "";
            CN.Mny_Impuesto = "";
            CN.Mny_Descuento = "";
        }
    }
}
