using System;
using System.Data;
using System.Windows.Forms;
using ProyectoProgra3.ProyectoCN;


namespace ProyectoProgra3
{
    public partial class frmMenu : Form
    {

        private int Id { get; set; }//esta variable almacena de manera global el id que recibe el Form Pantalla Principal
        private int IdEmpleado { get; set; }//esta variable almacena de manera global el id que recibe el Form Pantalla Principal

        public frmMenu(int idUser, int idEmpleado)
        {
            Id = idUser;
            IdEmpleado = idEmpleado;
            InitializeComponent();
            OcultarBotones();
            CargarMenu(idUser);
        }

        #region MetodoSeguridad

        private void CargarMenu(int id)
        {
            CN_Seguridad Menu = new CN_Seguridad();
            DataTable Seguridad = Menu.SeguridadMenu(id);
            int rol = Convert.ToInt16(Seguridad.Rows[0].ItemArray[0]);            

            if (rol == 1) // Usuario administrador
            {
                btn_RRHH.Visible = true;
                btn_Ventas.Visible = true;
                btn_Inventario.Visible = true;
                btn_Mantenimientos.Visible = true;
            }

            if (rol == 2)// Usuario Cajero 
            {
                btn_Ventas.Visible = true;
            }

            if (rol == 3)// Usuario Bodega
            {
                
                btn_Inventario.Visible = true;
            }

            if (rol == 4) // Usuario Jefatura
            {
                btn_RRHH.Visible = true;
            }
        }

        #endregion

        private void OcultarBotones()
        {
            btn_RRHH.Visible = false;
            btn_Ventas.Visible = false;
            btn_Inventario.Visible = false;
            btn_Mantenimientos.Visible = false;
        
        }//Fin metodo OcultarBotones

        

        private void btn_RRHH_Click(object sender, EventArgs e)
        {

        }

        private void tlsSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tlsLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            frm_Login login = new frm_Login();
            login.Show();

        }

        private void tlsRRHH_Click(object sender, EventArgs e)
        {
            Mantenimineto.frm_Puesto puesto = new Mantenimineto.frm_Puesto();
            puesto.Show();

        }

        private void tlsGestionProd_Click(object sender, EventArgs e)
        {
            Inventario_y_Proveedor.frm_Producto producto = new Inventario_y_Proveedor.frm_Producto();
            producto.Show();
        }

        private void proveedoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            Inventario_y_Proveedor.frm_Proveedor proveedor = new Inventario_y_Proveedor.frm_Proveedor();
            proveedor.Show();

        }

        private void marcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mantenimineto.Inventario_y_Proveedores.frm_Marcas marcas = new Mantenimineto.Inventario_y_Proveedores.frm_Marcas();
            marcas.Show();
        }

        private void venderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ventas.frm_Ventas ventas = new Ventas.frm_Ventas();
            ventas.Show();
        }

        private void cerrarCajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Facturacion.frm_Facturacion facturacion = new Facturacion.frm_Facturacion();
            facturacion.Show();
        }
    }
}
