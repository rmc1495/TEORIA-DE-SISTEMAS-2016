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
        Devolucion.CN_Devolucion CND = new Devolucion.CN_Devolucion();
        //DataTable DetalleFactura = new System.Data.DataTable();
        //int IdDetalleFactura = 0
        public frm_Ventas()
        {
            InitializeComponent();
            timer1.Start();
            txtEmpleado.Text = CN.EmpleadoNombre;
            limpiartabla();
       
        }
        private void LimpiarDevolucion()
        {
            txtDevolucionCodigoFactura.Text = "";
            txtDevolucionNombreUsuario.Text = "";
            txtDevolucionMotivo.Text = "";
        }
        public void limpiartabla ()
        {
            CN.DetalleFactura.Clear();
            CN.DetalleFactura.Columns.Clear();
            CN.DetalleFactura.Columns.Add("Int_IdDetalleFactura", typeof(int));
            CN.DetalleFactura.Columns.Add("Int_IdFactura", typeof(int));
            CN.DetalleFactura.Columns.Add("Int_Linea", typeof(int));
            CN.DetalleFactura.Columns.Add("Int_IdArticulo", typeof(int));
            CN.DetalleFactura.Columns.Add("Int_IdServicio", typeof(int));
            CN.DetalleFactura.Columns.Add("Int_Cantidad", typeof(int));
            CN.DetalleFactura.Columns.Add("Mny_Monto", typeof(double));
            CN.DetalleFactura.Columns.Add("Mny_Impuesto", typeof(double));
            CN.DetalleFactura.Columns.Add("Mny_Descuento", typeof(double));
            cbMetodoPago.Text = "Efectivo";
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

            if (e.KeyCode == Keys.Enter && txtCodigo.Text.Trim() != "")
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
                    txtCodigo.Text = "";
                }
            }
            else { }            
        }
        private void ActualizarDatos()//Aqui va lo que se tiene que repetir ordenadamente y los totales para su conteo matematico
        {
            int i = 1;
            double subtotal = 0;
            double total = 0;
            while (i < gvVentas.Rows.Count+1)
            {
                gvVentas.Rows[i-1].Cells[0].Value = i;

                if (Convert.ToDouble(gvVentas.Rows[i - 1].Cells[8].Value.ToString()) <= 0) //hay un problema si en la formula el descuento es de 0% se traga toda la formula y resultado seria 0 (Tomar en cuenta)
                {
                    subtotal = subtotal + (Convert.ToDouble(gvVentas.Rows[i - 1].Cells[6].Value.ToString()) * Convert.ToInt32(gvVentas.Rows[i - 1].Cells[5].Value.ToString()));
                    total = total + ((Convert.ToDouble(gvVentas.Rows[i - 1].Cells[6].Value.ToString()) * (Convert.ToDouble(gvVentas.Rows[i - 1].Cells[7].Value.ToString()) / 100) + Convert.ToDouble(gvVentas.Rows[i - 1].Cells[6].Value.ToString())) * Convert.ToInt32(gvVentas.Rows[i - 1].Cells[5].Value.ToString()));//total = con impuesto
                }
                else
                {
                    subtotal = subtotal + ((Convert.ToDouble(gvVentas.Rows[i - 1].Cells[6].Value.ToString()) * (Convert.ToDouble(gvVentas.Rows[i - 1].Cells[8].Value.ToString()) / 100) + Convert.ToDouble(gvVentas.Rows[i - 1].Cells[6].Value.ToString())) * Convert.ToInt32(gvVentas.Rows[i - 1].Cells[5].Value.ToString()));
                    total = total + ((((Convert.ToDouble(gvVentas.Rows[i - 1].Cells[6].Value.ToString()) * (Convert.ToDouble(gvVentas.Rows[i - 1].Cells[8].Value.ToString()) / 100)) * (Convert.ToDouble(gvVentas.Rows[i - 1].Cells[7].Value.ToString()) / 100)) + Convert.ToDouble(gvVentas.Rows[i - 1].Cells[6].Value.ToString())) * Convert.ToInt32(gvVentas.Rows[i - 1].Cells[5].Value.ToString())); //((precio+Descuento+impuesto)*cantidad)
                }
                i++;
            }
            txtSubTotal.Text = Convert.ToString(subtotal).Trim();
            txtTotal.Text = Convert.ToString(total).Trim();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtIDUsuario.Text.Trim() != "")
            {
                CN.DetalleFactura.Clear();

                int i = 1;
                while (i <= gvVentas.Rows.Count) //pasa los datos del datagridview al datatable
                {
                    DataRow dr = CN.DetalleFactura.NewRow();
                    dr[2] = Convert.ToInt32(gvVentas.Rows[i - 1].Cells[0].Value.ToString().Trim());
                    if (String.IsNullOrEmpty(gvVentas.Rows[i - 1].Cells[1].Value as String))
                    { }
                    else { dr[3] = Convert.ToInt32(gvVentas.Rows[i - 1].Cells[1].Value.ToString().Trim()); }
                    if (String.IsNullOrEmpty(gvVentas.Rows[i - 1].Cells[3].Value as String))
                    { }
                    else { dr[4] = Convert.ToInt32(gvVentas.Rows[i - 1].Cells[3].Value.ToString().Trim()); }
                    dr[5] = Convert.ToInt32(gvVentas.Rows[i - 1].Cells[5].Value.ToString().Trim());
                    dr[6] = Convert.ToDouble(gvVentas.Rows[i - 1].Cells[6].Value.ToString().Trim());
                    dr[7] = Convert.ToDouble(gvVentas.Rows[i - 1].Cells[7].Value.ToString().Trim());
                    dr[8] = Convert.ToDouble(gvVentas.Rows[i - 1].Cells[8].Value.ToString().Trim());

                    CN.DetalleFactura.Rows.Add(dr);
                    i = i + 1;
                }


                CN.Metodo_de_Pago = cbMetodoPago.SelectedItem.ToString().Trim();
                CN.EmpleadoNombre = txtUsuario.Text;
                CN.Mny_Total = Convert.ToDouble(txtTotal.Text);

                frm_Ventas_Pago frmHijo = new frm_Ventas_Pago();
                frmHijo.Owner = this;

                frmHijo.WindowState = FormWindowState.Normal;
                frmHijo.Show();
            }
            else
            {
                MessageBox.Show("Falta llenar el codigo del cliente. Presione ''Enter'' para validar el nombre del cliente en el cuadro de texto", "Hay Espacios Vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabControl1.TabPages[1])
            {

                frm_Sublogin frmHijo = new frm_Sublogin();
                frmHijo.Owner = this;
                frmHijo.StartPosition = FormStartPosition.CenterScreen;
                frmHijo.WindowState = FormWindowState.Normal;
                frmHijo.ShowDialog();
                txtDevolucionNombreUsuario.Text = CN.DevolucionempleadoNombre;
                cmbDevolucionCantidad.Text = "1";
            }
            else 
            {}
        }

        private void frm_Ventas_Activated(object sender, EventArgs e)
        {
            if (CN.LoginC == true)
            {
                CN.LoginC = false;
                tabControl1.SelectedIndex = 0;
            }
            else { }

            if (CN.Limpiar == true)
            {
                this.gvVentas.DataSource = null;
                this.gvVentas.Rows.Clear();
                txtIDUsuario.Text ="";
                txtUsuario.Text = "";
                txtSubTotal.Text ="0";
                txtTotal.Text = "0";
                CN.Limpiar = false;
            }
            else { }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ( txtDevolucionCodigoFactura.Text==""|| cmbDevolucionCantidad.Text==""  )
            {
                MessageBox.Show("Favor rellenar datos", "Hay Espacios Vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataTable ConsultaNombreDetalleFactura = CND.VerificarDetalleFactura(txtDevolucionCodigoFactura.Text.Trim()).Tables[0];
                if (ConsultaNombreDetalleFactura.Rows.Count <= 0)
                {
                 MessageBox.Show("No se han encontrado datos referentes al codigo insertado", "Dato no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else{
                CND.Int_IdDetalleFactura = Convert.ToInt32(txtDevolucionCodigoFactura.Text.Trim());
                CND.Int_IdEmpleado = CN.DevolucionempleadoID;
                CND.Int_Cantidad = Convert.ToInt32(cmbDevolucionCantidad.Text.Trim());
                CND.Mny_Total = Convert.ToDouble(txtDevolucionMonto.Text.Trim());
                CND.Vrch_Detalle = txtDevolucionMotivo.Text.Trim();
                CND.AgregarDevolucion(CND);

                CND.Int_IdDetalleFactura = 0;
                CND.Int_IdEmpleado = 0;
                CND.Int_Cantidad = 0;
                CND.Mny_Total = 0;
                CND.Vrch_Detalle = "";

                LimpiarDevolucion();
                MessageBox.Show("Datos Agregados Correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                tabControl1.SelectedIndex = 0;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
         LimpiarDevolucion();
         tabControl1.SelectedIndex = 0; 
        }

        private void txtDevolucionCodigoFactura_KeyUp(object sender, KeyEventArgs e)
        {
            //if(txtDevolucionCodigoFactura.Text.Trim() == "" )
            //{}
            //else
            //{

            //}
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        
        }

        private void txtDevolucionCodigoFactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        
        }

        private void cmbDevolucionCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {


            if (e.KeyChar >= '0' && e.KeyChar <= '9' || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        
        }

        private void txtDevolucionMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            if (Char.IsControl(e.KeyChar)) return;
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.Contains('.') == false)) return;
            if ((e.KeyChar == '.') && ((sender as TextBox).SelectionLength == (sender as TextBox).TextLength)) return;
            e.Handled = true;
        
        }

        private void txtIDUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void gvVentas_KeyPress(object sender, KeyPressEventArgs e)
        {
            int ColumnaSeleccionada = gvVentas.CurrentCell.ColumnIndex;
            try
            {
                if (ColumnaSeleccionada == 5 || ColumnaSeleccionada == 8)
                {
                    if (e.KeyChar >= '0' && e.KeyChar <= '9' || Char.IsControl(e.KeyChar))
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
                else { }
                if (ColumnaSeleccionada == 7)
                {
                    if (Char.IsDigit(e.KeyChar)) return;
                    if (Char.IsControl(e.KeyChar)) return;
                    if ((e.KeyChar == '.') && ((sender as TextBox).Text.Contains('.') == false)) return;
                    if ((e.KeyChar == '.') && ((sender as TextBox).SelectionLength == (sender as TextBox).TextLength)) return;
                    e.Handled = true;
                }
                else { }
            }            
            catch (Exception)
            {
                ColumnaSeleccionada = 0;
                //throw;
            }

        }

        private void gvVentas_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            // aqui necesito traer la tecla para manejar su validación
            DataGridViewTextBoxEditingControl tb = (DataGridViewTextBoxEditingControl)e.Control;
            tb.KeyPress += new KeyPressEventHandler(gvVentas_KeyPress);

            e.Control.KeyPress += new KeyPressEventHandler(gvVentas_KeyPress);
        }

        private void gvVentas_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (gvVentas.Rows.Count > 0)
            {
                int ColumnaSeleccionada = gvVentas.CurrentCell.ColumnIndex;
                int CeldaSeleccionada = gvVentas.CurrentCell.RowIndex;

                try{

                if (ColumnaSeleccionada == 5 || ColumnaSeleccionada == 7 || ColumnaSeleccionada == 8)
                {
                    
                        ActualizarDatos();
                }
                else { }
                            }
            catch (Exception)
            {
                ColumnaSeleccionada = 0;
                //throw;
            }

            }
            else { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
