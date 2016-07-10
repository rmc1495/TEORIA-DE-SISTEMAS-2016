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
    public partial class frm_Usuarios : Form
    {
        public frm_Usuarios()
        {
            InitializeComponent();
            RefrescarGridUsuarios();
        }

        #region Validaciones

        private void ValidarUsuario(object sender, KeyPressEventArgs e)
        {
            {
                MessageBox.Show("No se permiten caracteres especiales", "Advertencia", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
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
            txtUsername.Clear();
            txtUsername.Enabled = false;
            txtPass.Clear();
            cboxEstado.Text = "";
            cBoxRol.Text = "";
            cBoxIdEmpleado.Text = "";
            DesabilitarControles();
            ActivarControles();

        }

        private void ActivarControles()
        {
            btnLimpiarUsuario.Enabled = true;
        }

        private void DesabilitarControles()
        {
            btnModificarUsuario.Enabled = false;
            btnEliminarUsuario.Enabled = false;
            btnLimpiarUsuario.Enabled = false;
        }

        #endregion

        private void frm_Usuarios_Load(object sender, EventArgs e)
        {
            ProyectoCN.CN_ListarComboBox Lista = new ProyectoCN.CN_ListarComboBox();

            cboxEstado.DataSource = Lista.Listar_Estados_EnComboBox();
            cboxEstado.DisplayMember = "Descripcion";
            cboxEstado.ValueMember = "IdEstado";

            cBoxRol.DataSource = Lista.Listar_Roles_EnComboBox();
            cBoxRol.DisplayMember = "Nombre";
            cBoxRol.ValueMember = "IdRol";

            cBoxIdEmpleado.DataSource = Lista.Listar_IDEmpleados_EnComboBox();
            cBoxIdEmpleado.DisplayMember = "IdEmpleado";
            cBoxIdEmpleado.ValueMember = "IdEmpleado";

            Limpiar();

        }

        private void btnAtrasUsuario_Click(object sender, EventArgs e)
        {
            if (btnLimpiarUsuario.Enabled == false)
            {
                Limpiar();
            }
            else
                this.Close();
        }

        private void btnLimpiarUsuario_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void RefrescarGridUsuarios()
        {
            ProyectoCN.CN_Usuarios capaCli = new ProyectoCN.CN_Usuarios();
            dgvUsuarios.DataSource = capaCli.ListarUsuarios().Tables[0];
            dgvUsuarios.Columns["Username"].HeaderText = "Usuario";
            dgvUsuarios.Columns["IdEmpleado"].HeaderText = "ID de Empleado";
            dgvUsuarios.Columns["Id_Rol"].HeaderText = "ID de Rol";
            dgvUsuarios.Columns["IdEstado"].HeaderText = "ID de Estado";
            DesabilitarControles();
            ActivarControles();
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                ProyectoCN.CN_Usuarios CNcli = new ProyectoCN.CN_Usuarios();
                CNcli.Username = dgvUsuarios.CurrentRow.Cells[0].Value.ToString();
                CNcli.EliminarUsuarios(ref CNcli);
                RefrescarGridUsuarios();
                Limpiar();
                ActivarControles();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            ProyectoCN.CN_Usuarios capaCN = new ProyectoCN.CN_Usuarios();
            capaCN.Username = txtUsername.Text;
            capaCN.Password = txtPass.Text;
            capaCN.Id_Rol = Convert.ToInt32(cBoxRol.SelectedValue);
            capaCN.IdEmpleado = Convert.ToString(cBoxIdEmpleado.SelectedValue);
            capaCN.IDEstado = Convert.ToChar(cboxEstado.SelectedValue);
            capaCN.ActualizarUsuarios(capaCN);
            RefrescarGridUsuarios();
            Limpiar();
            ActivarControles();
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUsuarios.CurrentRow.Cells[0].Selected == true || dgvUsuarios.CurrentRow.Cells[1].Selected == true ||
               dgvUsuarios.CurrentRow.Cells[2].Selected == true || dgvUsuarios.CurrentRow.Cells[3].Selected == true ||
               dgvUsuarios.CurrentRow.Cells[4].Selected == true)
            {
                DesabilitarControles();
                btnEliminarUsuario.Enabled = true;
                btnModificarUsuario.Enabled = true;
            }

            string usuario = dgvUsuarios.CurrentRow.Cells[0].Value.ToString();
            ProyectoCN.CN_Usuarios CNCli = new ProyectoCN.CN_Usuarios();
            CNCli.Username = usuario;
            CNCli.BuscarUsuarios(ref CNCli);

            if (CNCli != null)
            {
                txtUsername.Text = dgvUsuarios.CurrentRow.Cells[0].Value.ToString();
                txtUsername.Enabled = false;
                txtPass.Text = dgvUsuarios.CurrentRow.Cells[1].Value.ToString();
            }
        }

        private void txtFiltrar_TextChanged(object sender, EventArgs e)
        {
            ProyectoCN.CN_Usuarios capaCli = new ProyectoCN.CN_Usuarios();
            string tipo = Convert.ToString(cBoxFiltrar.ComboBox.SelectedItem);
            string param = txtFiltrar.Text;
            dgvUsuarios.DataSource = capaCli.FiltrarUsu(tipo, param).Tables[0];
        }






    }
}
