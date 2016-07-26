using System;
using System.Windows.Forms;

namespace ProyectoProgra3.Inventario_y_Proveedor
{
    public partial class frm_Producto : Form
    {
        public frm_Producto()
        {
            InitializeComponent();
        }

        private void frm_Producto_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_TSistemasDataSet.sp_ConsultarProveedor' table. You can move, or remove it, as needed.
            this.sp_ConsultarProveedorTableAdapter.Fill(this.dB_TSistemasDataSet.sp_ConsultarProveedor);
            // TODO: This line of code loads data into the 'dB_TSistemasDataSet.sp_ConsultarMarca' table. You can move, or remove it, as needed.
            this.sp_ConsultarMarcaTableAdapter.Fill(this.dB_TSistemasDataSet.sp_ConsultarMarca);

        }
        private void Limpiar()
        {
            txtDescripcionProducto.Clear();
            txtPrecioProducto.Clear();
            txtCantidadProducto.Clear();
            cmbMarcaProducto.Text="";
            cmbProveedorProducto.Text="";
            txtPorcentajeProducto.Clear();
            
            
        }
        private void btnRegistrarProducto_Click(object sender, EventArgs e)
        {
            {
                if (txtDescripcionProducto.Text == "" || txtPrecioProducto.Text == "" || txtCantidadProducto.Text == "" || cmbMarcaProducto.Text == "" ||
                cmbProveedorProducto.Text == "" || txtPorcentajeProducto.Text == "" || dtpVencimientoProducto.Text == "")
                {
                    MessageBox.Show("Se requieren todos los espacios completos", "Advertencia", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    ProyectoCN.Inventario_y_Proveedores.CN_Productos capaCN = new ProyectoCN.Inventario_y_Proveedores.CN_Productos();
                    capaCN.Descripcion = txtDescripcionProducto.Text;
                    capaCN.Precio = Convert.ToInt32(txtPrecioProducto.Text);
                    capaCN.Cantidad = Convert.ToInt32(txtCantidadProducto.Text);
                    capaCN.IdProveedor = Convert.ToInt32(cmbMarcaProducto.SelectedValue);
                    capaCN.IdMarca = Convert.ToInt32(cmbProveedorProducto.SelectedValue);
                    capaCN.IdEstado = Convert.ToInt32(1);
                    capaCN.Porcentaje = Convert.ToInt32(txtPorcentajeProducto.Text);
                    capaCN.Ingreso = DateTime.Now;
                    capaCN.Vencimiento = dtpVencimientoProducto.Value;
                    capaCN.GuardarProductos(capaCN);
                    MessageBox.Show("Datos registrados correctamente", "Exito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    Limpiar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
