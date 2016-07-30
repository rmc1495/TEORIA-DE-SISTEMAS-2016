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
    public partial class frm_Ventas : Form
    {
       // DataTable Facturacion = new System.Data.DataTable();  //Crear en un boton para añadir datos a la Factura
        Ventas.CN_Ventas CN = new Ventas.CN_Ventas();
        int Linea=0;
        //DataTable DetalleFactura = new System.Data.DataTable();
        //int IdDetalleFactura = 0
        public frm_Ventas()
        {
            InitializeComponent();
            timer1.Start();

            limpiartabla();
       
        }
        public void limpiartabla ()
        {
            CN.DetalleFactura.Clear();
            CN.DetalleFactura.Columns.Add("int_IdDetalleFactura", typeof(int));
            CN.DetalleFactura.Columns.Add("Int_IdFactura", typeof(int));
            CN.DetalleFactura.Columns.Add("Int_Linea", typeof(int));
            CN.DetalleFactura.Columns.Add("Int_IdArticulo", typeof(int));
            CN.DetalleFactura.Columns.Add("Int_IdServicio", typeof(int));
            CN.DetalleFactura.Columns.Add("Int_Cantidad", typeof(int));
            CN.DetalleFactura.Columns.Add("Mny_Monto", typeof(double));
            CN.DetalleFactura.Columns.Add("Mny_Impuesto", typeof(double));
            CN.DetalleFactura.Columns.Add("Mny_Descuento", typeof(double));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString();
        }

        string AgregarCelda(string Dato)
        {



            return Dato;
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                bool BuscarServicio = false;
                DataTable FilaDatos = CN.BuscarArticulo(txtCodigo.Text.Trim()).Tables[0];
                if (FilaDatos.Rows.Count <= 0)
                {
                    FilaDatos.Clear();
                    FilaDatos = CN.BuscarServicio(txtCodigo.Text.Trim()).Tables[0];
                    BuscarServicio = true;

                }
                else { }

                if (FilaDatos.Rows.Count <= 0)
                {
                    FilaDatos.Clear();
                    MessageBox.Show("No hay Coincidencias", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    Linea = Linea + 1;

                    gvVentas.Rows.Insert(gvVentas.Rows.Count, 1);
                    if (BuscarServicio == true)
                    {
                        //FilaDetalleFactura[4] = "".Trim();
                        gvVentas.Rows[gvVentas.Rows.Count - 1].Cells[3].Value = txtCodigo.Text.Trim();
                        gvVentas.Rows[gvVentas.Rows.Count - 1].Cells[4].Value = FilaDatos.Rows[0][0];
                    }
                    else
                    {
                        gvVentas.Rows[gvVentas.Rows.Count - 1].Cells[1].Value = txtCodigo.Text.Trim();
                        gvVentas.Rows[gvVentas.Rows.Count - 1].Cells[2].Value = FilaDatos.Rows[0][0];
                        //FilaDetalleFactura[5] = "".Trim(); 
                    }
                    gvVentas.Rows[gvVentas.Rows.Count - 1].Cells[5].Value = 1;
                    gvVentas.Rows[gvVentas.Rows.Count - 1].Cells[6].Value = FilaDatos.Rows[0][1];
                    gvVentas.Rows[gvVentas.Rows.Count - 1].Cells[7].Value = 13;
                    gvVentas.Rows[gvVentas.Rows.Count - 1].Cells[8].Value = 0;

                    ActualizarDatos();
                }
            }             
        }
        private void ActualizarDatos()//Aqui va lo que se tiene que repetir ordenadamente y los totales para su conteo matematico
        {
            int i = 1;
            double subtotal = 0;
            double total = 0;
            while (i < gvVentas.Rows.Count)
            {
                gvVentas.Rows[i - 1].Cells[2].Value = i;
                
                if(Convert.ToDouble(gvVentas.Rows[gvVentas.Rows.Count - 1].Cells[8]) <= 0 ) //hay un problema si en la formula el descuento es de 0% se traga toda la formula y resultado seria 0 (Tomar en cuenta)
                {
                    subtotal = subtotal + (Convert.ToDouble(gvVentas.Rows[gvVentas.Rows.Count - 1].Cells[6])*Convert.ToInt32(gvVentas.Rows[gvVentas.Rows.Count - 1].Cells[5]));
                    total = total + ((Convert.ToDouble(gvVentas.Rows[gvVentas.Rows.Count - 1].Cells[6])*(Convert.ToDouble(gvVentas.Rows[gvVentas.Rows.Count - 1].Cells[7])/100)) * Convert.ToInt32(gvVentas.Rows[gvVentas.Rows.Count - 1].Cells[5]));//total = con impuesto
                }
                else
                {
                    subtotal = subtotal + ((Convert.ToDouble(gvVentas.Rows[gvVentas.Rows.Count - 1].Cells[6]) * (Convert.ToDouble(gvVentas.Rows[gvVentas.Rows.Count - 1].Cells[8])/100)) * Convert.ToInt32(gvVentas.Rows[gvVentas.Rows.Count - 1].Cells[5]));
                    total = total + ((((Convert.ToDouble(gvVentas.Rows[gvVentas.Rows.Count - 1].Cells[6]) * (Convert.ToDouble(gvVentas.Rows[gvVentas.Rows.Count - 1].Cells[8]) / 100)) * (Convert.ToDouble(gvVentas.Rows[gvVentas.Rows.Count - 1].Cells[7]) / 100)) + Convert.ToDouble(gvVentas.Rows[gvVentas.Rows.Count - 1].Cells[6])) * Convert.ToInt32(gvVentas.Rows[gvVentas.Rows.Count - 1].Cells[5])); //((precio+Descuento+impuesto)*cantidad)
                }
                i++;
            }
            txtSubTotal.Text = Convert.ToString(subtotal).Trim();
            txtTotal.Text = Convert.ToString(total).Trim();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int i = 1;
            while (i < gvVentas.Rows.Count) //pasa los datos del datagridview al datatable
            {
            DataRow dr = CN.DetalleFactura.NewRow();
            dr[2] = gvVentas.Rows[0].Cells[i-1].FormattedValue.ToString().Trim();
            dr[3] = gvVentas.Rows[1].Cells[i - 1].FormattedValue.ToString().Trim();
            dr[4] = gvVentas.Rows[3].Cells[i - 1].FormattedValue.ToString().Trim();
            dr[5] = gvVentas.Rows[5].Cells[i - 1].FormattedValue.ToString().Trim();
            dr[6] = gvVentas.Rows[6].Cells[i - 1].FormattedValue.ToString().Trim();
            dr[7] = gvVentas.Rows[7].Cells[i - 1].FormattedValue.ToString().Trim();
            dr[8] = gvVentas.Rows[8].Cells[i - 1].FormattedValue.ToString().Trim();

            CN.DetalleFactura.Rows.Add(dr);
            }
            

            CN.Metodo_de_Pago = cbMetodoPago.SelectedItem.ToString().Trim();

            frm_Ventas_Pago frmHijo = new frm_Ventas_Pago();
            frmHijo.Owner = this;
            
            frmHijo.WindowState = FormWindowState.Normal;
            frmHijo.Show();
        }

        private void textBox1_KeyUp_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataTable Consulta = CN.ConsultarCliente(txtIDUsuario.Text.Trim()).Tables[0];

                if (Consulta.Rows.Count <= 0)
                {
                    CN.Int_IdCliente = 1;  // cliente default
                }
                else
                {
                    CN.Int_IdCliente = Convert.ToInt32(Consulta.Rows[0][0].ToString().Trim());
                    txtUsuario.Text = Consulta.Rows[0][1].ToString().Trim();
                }
            }
        }
    }
}
