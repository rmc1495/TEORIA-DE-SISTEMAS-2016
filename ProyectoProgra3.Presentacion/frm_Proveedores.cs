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
    public partial class frm_Proveedores : Form
    {
        public frm_Proveedores()
        {
            InitializeComponent();
            RefrescarGridProveedores();
        }

        #region Validaciones

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

        private void ValidarComboBox(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show("Ingrese un valor correcto", "Advertencia", MessageBoxButtons.OK,
            MessageBoxIcon.Warning);
            e.Handled = true;
            return;
        }

        #endregion

        # region Utilitario

        private void Limpiar()
        {
            txtIDProveedor.Clear();
            txtIDProveedor.Enabled = true;
            txtNombre.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
            cBoxEstado.Text = "";
            DesabilitarControles();
            ActivarControles();
        }

        private void ActivarControles()
        {
            btnLimpiarProveedor.Enabled = true;
            btnRegistrarProveedor.Enabled = true;
        }

        private void DesabilitarControles()
        {
            btnModificarProveedor.Enabled = false;
            btnEliminarProveedor.Enabled = false;
            btnLimpiarProveedor.Enabled = false;
            btnRegistrarProveedor.Enabled = false;
        }

        #endregion

        private void frm_Proveedores_Load(object sender, EventArgs e)
        {
            ProyectoCN.CN_ListarComboBox Lista = new ProyectoCN.CN_ListarComboBox();

            cBoxEstado.DataSource = Lista.Listar_Estados_EnComboBox();
            cBoxEstado.DisplayMember = "Descripcion";
            cBoxEstado.ValueMember = "IdEstado";
        }

        private void btnRegistrarProveedor_Click(object sender, EventArgs e)
        {
            #region Validar

            if (txtDireccion.Text == "" || txtIDProveedor.Text == "" || txtNombre.Text == "" ||
                txtTelefono.Text == "" || cBoxEstado.Text == "")
            {
                MessageBox.Show("Se requieren todos los espacios completos", "Advertencia",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (txtTelefono.TextLength < 8)
            {
                MessageBox.Show("Formato de teléfono incorrecto", "Advertencia",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            #endregion

            try
            {
                ProyectoCN.CN_Proveedores capaCN = new ProyectoCN.CN_Proveedores();
                capaCN.IdProveedor = txtIDProveedor.Text;
                capaCN.Nombre = txtNombre.Text;
                capaCN.Telefono = txtTelefono.Text;
                capaCN.Direccion = txtDireccion.Text;
                capaCN.IdEstado = Convert.ToChar(cBoxEstado.SelectedValue);
                capaCN.GuardarProveedores(capaCN);
                MessageBox.Show("Datos registrados correctamente", "Exito",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefrescarGridProveedores();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDireccion.Clear();
            txtIDProveedor.Clear();
            txtNombre.Clear();
            txtTelefono.Clear();
            cBoxEstado.Items.Clear();
            cBoxEstado.Text = "";
        }

        private void btnAtrasProveedor_Click(object sender, EventArgs e)
        {
            if (btnRegistrarProveedor.Enabled == false)
            {
                Limpiar();
            }
            else
                this.Close();
        }

        private void btnLimpiarProveedor_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void RefrescarGridProveedores()
        {
            ProyectoCN.CN_Proveedores capaProv = new ProyectoCN.CN_Proveedores();
            dgvProveedor.DataSource = capaProv.ListarProveedores().Tables[0];
            dgvProveedor.Columns["IdProveedor"].HeaderText = "ID de Proveedor";
            dgvProveedor.Columns["Nombre"].HeaderText = "Nombre";
            dgvProveedor.Columns["Direccion"].HeaderText = "Direccion";
            dgvProveedor.Columns["Telefono"].HeaderText = "Telefono";
            dgvProveedor.Columns["Descripcion"].HeaderText = "Estado";
            DesabilitarControles();
            ActivarControles();
        }

        private void btnEliminarProveedor_Click(object sender, EventArgs e)
        {
            try
            {
                ProyectoCN.CN_Proveedores CNcli = new ProyectoCN.CN_Proveedores();
                CNcli.IdProveedor = dgvProveedor.CurrentRow.Cells[0].Value.ToString();
                CNcli.EliminarProveedores(ref CNcli);
                RefrescarGridProveedores();
                Limpiar();
                ActivarControles();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificarProveedor_Click(object sender, EventArgs e)
        {
            ProyectoCN.CN_Proveedores capaCN = new ProyectoCN.CN_Proveedores();
            capaCN.IdProveedor = txtIDProveedor.Text;
            capaCN.Nombre = txtNombre.Text;
            capaCN.Telefono = txtTelefono.Text;
            capaCN.Direccion = txtDireccion.Text;
            capaCN.IdEstado = Convert.ToChar(cBoxEstado.SelectedValue);
            capaCN.ActualizarProveedores(capaCN);
            RefrescarGridProveedores();
            Limpiar();
            ActivarControles();
        }

        private void dgvProveedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProveedor.CurrentRow.Cells[0].Selected == true || dgvProveedor.CurrentRow.Cells[1].Selected == true ||
               dgvProveedor.CurrentRow.Cells[2].Selected == true || dgvProveedor.CurrentRow.Cells[3].Selected == true ||
               dgvProveedor.CurrentRow.Cells[4].Selected)
            {
                DesabilitarControles();
                btnEliminarProveedor.Enabled = true;
                btnModificarProveedor.Enabled = true;
            }

            string idprov = dgvProveedor.CurrentRow.Cells[0].Value.ToString();
            ProyectoCN.CN_Proveedores CNprov= new ProyectoCN.CN_Proveedores();
            CNprov.IdProveedor = idprov;
            CNprov.BuscarProveedores(ref CNprov);

            if (CNprov != null)
            {
                txtIDProveedor.Text = dgvProveedor.CurrentRow.Cells[0].Value.ToString();
                txtIDProveedor.Enabled = false;
                txtNombre.Text = dgvProveedor.CurrentRow.Cells[1].Value.ToString();
                txtDireccion.Text = dgvProveedor.CurrentRow.Cells[2].Value.ToString();
                txtTelefono.Text = dgvProveedor.CurrentRow.Cells[3].Value.ToString();

            }
        }

        private void txtFiltrar_TextChanged(object sender, EventArgs e)
        {
            ProyectoCN.CN_Proveedores capaCli = new ProyectoCN.CN_Proveedores();
            string tipo = Convert.ToString(cBoxFiltrar.ComboBox.SelectedItem);
            string param = txtFiltrar.Text;
            dgvProveedor.DataSource = capaCli.FiltrarProv(tipo, param).Tables[0];
        }

        




    }
}
