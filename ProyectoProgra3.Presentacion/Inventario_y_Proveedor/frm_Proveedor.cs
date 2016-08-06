using System;
using System.Windows.Forms;

namespace ProyectoProgra3.Inventario_y_Proveedor
{
    public partial class frm_Proveedor : Form
    {
        public frm_Proveedor()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            txtNombreProveedor.Clear();
            txtEmailProveedor.Clear();
            txtTelefonoProveedor.Clear();
            txtContactoProveedor.Clear();
        

        }
  
        private void btnRegistrarProveedor_Click_1(object sender, EventArgs e)
        {
            {
                if (txtNombreProveedor.Text == "" || txtEmailProveedor.Text == "" || txtNombreProveedor.Text == "" || txtContactoProveedor.Text == "")
                {
                    MessageBox.Show("Se requieren todos los espacios completos", "Advertencia", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    ProyectoCN.Inventario_y_Proveedores. CN_Proveedores capaCN = new ProyectoCN.Inventario_y_Proveedores. CN_Proveedores();
                    capaCN.Nombre = txtNombreProveedor.Text;
                    capaCN.Email = txtEmailProveedor.Text;
                    capaCN.Telefono = txtTelefonoProveedor.Text;
                    capaCN.Contacto = txtContactoProveedor.Text;
                    capaCN.IdEstado = 1;
                    capaCN.GuardarProveedores(capaCN);
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

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

            //ProyectoCN.Inventario_y_Proveedores.CN_Productos cn_P = new ProyectoCN.Inventario_y_Proveedores.CN_Productos();
            ProyectoCN.Inventario_y_Proveedores.CN_Proveedores cnp = new ProyectoCN.Inventario_y_Proveedores.CN_Proveedores();
            string param = txtBuscarProveedor.Text;
            dgvProveedor.DataSource = cnp.BuscarProveedores(param).Tables[0];

        }

        private void txtNombreProveedor_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
