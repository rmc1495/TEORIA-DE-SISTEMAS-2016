using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoProgra3
{
    public partial class frm_Productos : Form
    {
        public frm_Productos()
        {
            InitializeComponent();
            RefrescarGridProductos();
        }

        #region validaciones

        private void ValidarComboBox(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show("Ingrese un valor correcto", "Advertencia", MessageBoxButtons.OK,
            MessageBoxIcon.Warning);
            e.Handled = true;
            return;
        }

        private void ValidacionNumerica(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numero",
                                "Advertencia", MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void ValidarCaracteres(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten caractéres", "Advertencia",
                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void ValidacionEspecial(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (!(char.IsLetter(e.KeyChar))))
            {
                MessageBox.Show("No se permiten caracteres especiales", "Advertencia", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }

        #endregion

        # region Utilitario

        private void Limpiar()
        {
            txtIdProducto.Clear();
            txtIdProducto.Enabled = true;
            txtNombre.Clear();
            txtPrecio.Clear();
            txtCantidad.Clear();
            cBoxIdMarca.Text = "";
            cBoxIdCategoria.Text = "";
            cboxIdProveedor.Text = "";
            cBoxIdEstado.Text = "";
            DesabilitarControles();
            ActivarControles();
        }

        private void ActivarControles()
        {
            btnLimpiarProducto.Enabled = true;
            btnRegistrarProducto.Enabled = true;
        }

        private void DesabilitarControles()
        {
            btnModificarProducto.Enabled = false;
            btnEliminarProducto.Enabled = false;
            btnLimpiarProducto.Enabled = false;
            btnRegistrarProducto.Enabled = false;
        }

        #endregion

        private void frm_Productos_Load(object sender, EventArgs e)
        {
            ProyectoCN.CN_ListarComboBox Lista = new ProyectoCN.CN_ListarComboBox();

            cBoxIdEstado.DataSource = Lista.Listar_Estados_EnComboBox();
            cBoxIdEstado.DisplayMember = "Descripcion";
            cBoxIdEstado.ValueMember = "IdEstado";

            cBoxIdCategoria.DataSource = Lista.Listar_Categorias_EnComboBox();
            cBoxIdCategoria.DisplayMember = "Categoria";
            cBoxIdCategoria.ValueMember = "IdCategoria";

            cBoxIdMarca.DataSource = Lista.Listar_Marcas_EnComboBox();
            cBoxIdMarca.DisplayMember = "Marca";
            cBoxIdMarca.ValueMember = "IdMarca";

            cboxIdProveedor.DataSource = Lista.Listar_Proveedores_EnComboBox();
            cboxIdProveedor.DisplayMember = "Nombre";
            cboxIdProveedor.ValueMember = "IdProveedor";
        }

        private void btnRegistrarProducto_Click(object sender, EventArgs e)
        {
            if (txtCantidad.Text == "" || txtIdProducto.Text == "" || cBoxIdMarca.Text == "" || txtNombre.Text == "" ||
            txtPrecio.Text == "" || cBoxIdCategoria.Text == "" || cBoxIdEstado.Text == "" || cboxIdProveedor.Text == "")
            {
                MessageBox.Show("Se requieren todos los espacios completos", "Advertencia", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                return;
            }

            try
            {
                ProyectoCN.CN_Productos capaCN = new ProyectoCN.CN_Productos();
                capaCN.IdProducto = txtIdProducto.Text;
                capaCN.Nombre = txtNombre.Text;
                capaCN.Precio = Convert.ToInt32(txtPrecio.Text);
                capaCN.CantidadMinima = Convert.ToInt32(txtCantidad.Text);
                capaCN.IdCategoria = Convert.ToInt32(cBoxIdCategoria.SelectedValue);
                capaCN.IdMarca = Convert.ToInt32(cBoxIdMarca.SelectedValue);
                capaCN.IdProveedor = Convert.ToString(cboxIdProveedor.SelectedValue);
                capaCN.IdEstado = Convert.ToChar(cBoxIdEstado.SelectedValue);
                capaCN.GuardarProductos(capaCN);
                MessageBox.Show("Datos registrados correctamente", "Exito",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefrescarGridProductos();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAtrasProducto_Click(object sender, EventArgs e)
        {
            if (btnRegistrarProducto.Enabled == false)
            {
                Limpiar();
            }
            else
                this.Close();
        }

        private void btnLimpiarProducto_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void RefrescarGridProductos()
        {
            ProyectoCN.CN_Productos capaProd = new ProyectoCN.CN_Productos();
            dgvProductos.DataSource = capaProd.ListarProductos().Tables[0];
            dgvProductos.Columns["IdProducto"].HeaderText = "ID de Producto";
            dgvProductos.Columns["Nombre"].HeaderText = "Nombre";
            dgvProductos.Columns["Precio"].HeaderText = "Precio";
            dgvProductos.Columns["CantidadMinima"].HeaderText = "Cantidad";
            dgvProductos.Columns["Marca"].HeaderText = "Marca";
            dgvProductos.Columns["Categoria"].HeaderText = "Categoria";
            dgvProductos.Columns["Nombre"].HeaderText = "Proveedor";
            dgvProductos.Columns["Descripcion"].HeaderText = "Estado";
            DesabilitarControles();
            ActivarControles();
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                ProyectoCN.CN_Productos CNprod = new ProyectoCN.CN_Productos();
                CNprod.IdProducto = dgvProductos.CurrentRow.Cells[0].Value.ToString();
                CNprod.EliminarProductos(ref CNprod);
                RefrescarGridProductos();
                Limpiar();
                ActivarControles();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            ProyectoCN.CN_Productos capaCN = new ProyectoCN.CN_Productos();
            capaCN.IdProducto = txtIdProducto.Text;
            capaCN.Nombre = txtNombre.Text;
            capaCN.Precio = Convert.ToInt32(txtPrecio.Text);
            capaCN.CantidadMinima = Convert.ToInt32(txtCantidad.Text);
            capaCN.IdCategoria = Convert.ToInt32(cBoxIdCategoria.SelectedValue);
            capaCN.IdMarca = Convert.ToInt32(cBoxIdMarca.SelectedValue);
            capaCN.IdProveedor = Convert.ToString(cboxIdProveedor.SelectedValue);
            capaCN.IdEstado = Convert.ToChar(cBoxIdEstado.SelectedValue);
            capaCN.ActualizarProducto(capaCN);
            RefrescarGridProductos();
            Limpiar();
            ActivarControles();
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProductos.CurrentRow.Cells[0].Selected == true || dgvProductos.CurrentRow.Cells[1].Selected == true ||
              dgvProductos.CurrentRow.Cells[2].Selected == true || dgvProductos.CurrentRow.Cells[3].Selected == true ||
              dgvProductos.CurrentRow.Cells[4].Selected == true || dgvProductos.CurrentRow.Cells[5].Selected == true ||
              dgvProductos.CurrentRow.Cells[6].Selected == true || dgvProductos.CurrentRow.Cells[7].Selected == true)
            {
                DesabilitarControles();
                btnEliminarProducto.Enabled = true;
                btnModificarProducto.Enabled = true;
            }

            string idProducto = dgvProductos.CurrentRow.Cells[0].Value.ToString();
            ProyectoCN.CN_Productos CNPro = new ProyectoCN.CN_Productos();
            CNPro.IdProducto= idProducto;
            CNPro.BuscarProductos(ref CNPro);

            if (CNPro != null)
            {
                txtIdProducto.Text = dgvProductos.CurrentRow.Cells[0].Value.ToString();
                txtIdProducto.Enabled = false;
                txtNombre.Text = dgvProductos.CurrentRow.Cells[1].Value.ToString();
                txtPrecio.Text = dgvProductos.CurrentRow.Cells[2].Value.ToString();
                txtCantidad.Text = dgvProductos.CurrentRow.Cells[3].Value.ToString();

            }
        }

        private void txtFiltrar_TextChanged(object sender, EventArgs e)
        {
            ProyectoCN.CN_Productos capaCli = new ProyectoCN.CN_Productos();
            string tipo = Convert.ToString(cBoxFiltrar.ComboBox.SelectedItem);
            string param = txtFiltrar.Text;
            dgvProductos.DataSource = capaCli.FiltrarProd(tipo, param).Tables[0];
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            frm_Ventas v = new frm_Ventas();
            v.ShowDialog();
        }







    }
}
