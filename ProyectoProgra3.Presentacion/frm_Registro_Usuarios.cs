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
    public partial class frm_Registro_Usuarios : Form
    {
        public frm_Registro_Usuarios()
        {
            InitializeComponent();
        }

        private void frm_Registro_Usuarios_Load(object sender, EventArgs e)
        {
            /*ProyectoCN.CN_ListarComboBox Lista = new ProyectoCN.CN_ListarComboBox();

            cBoxIdEstado.DataSource = Lista.Listar_Estados_EnComboBox();
            cBoxIdEstado.DisplayMember = "Descripcion";
            cBoxIdEstado.ValueMember = "IdEstado";

            cBoxRoles.DataSource = Lista.Listar_Roles_EnComboBox();
            cBoxRoles.DisplayMember = "Nombre";
            cBoxRoles.ValueMember = "IdRol";

             cBoxIdEmpleado.DataSource = Lista.Listar_IDEmpleados_EnComboBox();
             cBoxIdEmpleado.DisplayMember = "IdEmpleado";
             cBoxIdEmpleado.ValueMember = "IdEmpleado";
            */
             Limpiar();



        }

        #region Validar

        private void txtNomUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (!(char.IsLetter(e.KeyChar))))
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

        #endregion

        private void btnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            if (txtNomUsuario.Text == "" || txtPass.Text == "" || txtRepPass.Text == "")
            {
                MessageBox.Show("Se debe de completar todos los espacios", "Adventencia",MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            else if (txtPass.Text != txtRepPass.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden", "Adventencia", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }

            try
            {
                ProyectoCN.CN_Usuarios capaCN = new ProyectoCN.CN_Usuarios();
                capaCN.Username = txtNomUsuario.Text;
                capaCN.Password = txtPass.Text;
                capaCN.Id_Rol = Convert.ToInt32(cBoxRoles.SelectedValue);
                capaCN.IdEmpleado = Convert.ToString(cBoxIdEmpleado.SelectedValue);
                capaCN.IDEstado = Convert.ToChar(cBoxIdEstado.SelectedValue);
                capaCN.GuardarUsuarios(capaCN);
                Limpiar();
                this.Close();
                MessageBox.Show("Usuario registrado correctamente", "Exito",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Limpiar()
        {
            txtNomUsuario.Clear();
            txtPass.Clear();
            txtRepPass.Clear();
            cBoxIdEstado.Text = "";
            cBoxIdEmpleado.Text = "";
            cBoxRoles.Text = "";
        }


        
    }
}
