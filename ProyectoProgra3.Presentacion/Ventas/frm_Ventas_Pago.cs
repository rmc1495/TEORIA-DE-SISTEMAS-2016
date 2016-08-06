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
            
            txtNombreCliente.Text = CN.EmpleadoNombre;
            txtTotalEfectivo.Text = Convert.ToString(CN.Mny_Total);

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

            

            Ventas.CN_Ventas CN = new Ventas.CN_Ventas();
         
            //CN.Mny_Total = CN.Int_IdCliente;
            CN.Dtm_Fecha = DateTime.Now;
            DataTable FacturaID = CN.AgregarFacturayDevolverValor(CN).Tables[0];
            CN.Int_IdFactura = FacturaID.Rows[0][0].ToString().Trim();
            int i = 1;
            while (i <= CN.DetalleFactura.Rows.Count) //pasa los datos del datagridview al datatable
            {
                CN.DetalleFactura.Rows[i - 1][1] = CN.Int_IdFactura;

                CN.Int_IdFactura = CN.DetalleFactura.Rows[i - 1][1].ToString().Trim();
                CN.Int_Linea = CN.DetalleFactura.Rows[i - 1][2].ToString().Trim();
                if (CN.DetalleFactura.Rows[i - 1][3].ToString().Trim() == "")
                {
                CN.Int_IdArticulo = "NULL";
                }else
                {
                CN.Int_IdArticulo = CN.DetalleFactura.Rows[i - 1][3].ToString().Trim();
                }
                if (CN.DetalleFactura.Rows[i - 1][4].ToString().Trim() == "")
                {
                CN.Int_IdServicio = "NULL";
                }
                else
                {
                CN.Int_IdServicio = CN.DetalleFactura.Rows[i - 1][4].ToString().Trim();
                }
                CN.Int_Cantidad = CN.DetalleFactura.Rows[i - 1][5].ToString().Trim();
                CN.Mny_Monto = CN.DetalleFactura.Rows[i - 1][6].ToString().Trim();
                CN.Mny_Impuesto = CN.DetalleFactura.Rows[i - 1][7].ToString().Trim();
                CN.Mny_Descuento = CN.DetalleFactura.Rows[i - 1][8].ToString().Trim();

                CN.AgregarDetallesFactura(CN);
                i = i+1;
            }
            this.Close();    
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
            CN.EmpleadoNombre = "";
            CN.Total = 0;
            CN.Limpiar = true;
            MessageBox.Show("Datos Actualizados", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
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
            CN.EmpleadoNombre = "";
            CN.Total = 0;
        }

        private void txtPagaEfectivo_KeyUp(object sender, KeyEventArgs e)
        {

            txtVueltoEfectivo.Text = Convert.ToString(Convert.ToDouble(txtPagaEfectivo.Text) - Convert.ToDouble(txtTotalEfectivo.Text));
        }

        private void txtPagaEfectivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            if (Char.IsControl(e.KeyChar)) return;
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.Contains('.') == false)) return;
            if ((e.KeyChar == '.') && ((sender as TextBox).SelectionLength == (sender as TextBox).TextLength)) return;
            e.Handled = true;
        }
    }
}
