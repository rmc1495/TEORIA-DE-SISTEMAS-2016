using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProyectoProgra3.ProyectoCN;

namespace ProyectoProgra3
{
    public partial class frm_Empleados : Form
    {
        public frm_Empleados()
        {
            InitializeComponent();
            RefrescarGridEmpleados();
        }

        # region Validaciones

        private void ValidacionCaracteres(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten caractéres", "Advertencia",
                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void ValidarNumeros(object sender, KeyPressEventArgs e)
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

        private void ValidarEspeciales(object sender, KeyPressEventArgs e)
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

        private void tlsBtnRegis_Atras_Click(object sender, EventArgs e)
        {
            if (btnRegistrarEmp.Enabled == false)
            {
                Limpiar();
            }
            else
                this.Close();
        }

        private void btnRegistrarEmp_Click(object sender, EventArgs e)
        {
            #region Validaciones

            if (txtApellidos.Text == "" || txtCedula.Text == "" || txtDireccion.Text == "" || txtEdad.Text == "" ||
            txtIdempleado.Text == "" || txtNombre.Text == "" || txtTele.Text == "" || cBoxDepartamento.Text == ""
             || cBoxEstado.Text == "" || cBoxTipoEmpleado.Text == "")
            {
                MessageBox.Show("Se requieren todos los espacios completos", "Advertencia", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            else if (txtCedula.TextLength < 9)
            {
                MessageBox.Show("Formato de cédula incorrecta", "Advertencia", 
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (txtTele.TextLength < 8)
            {
                MessageBox.Show("Formato de teléfono incorrecto", "Advertencia",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            #endregion
            try
            {
                ProyectoCN.CN_Empleados capaCN = new ProyectoCN.CN_Empleados();
                capaCN.IdEmpleado = txtIdempleado.Text;
                capaCN.Nombre = txtNombre.Text;
                capaCN.Cedula = txtCedula.Text;
                capaCN.Apellidos = txtApellidos.Text;
                capaCN.Direccion = txtDireccion.Text;
                capaCN.Telefono = txtTele.Text;
                capaCN.Edad = Convert.ToInt32(txtEdad.Text);
                capaCN.IdTipoEmpleado = Convert.ToInt32(cBoxTipoEmpleado.SelectedValue);
                capaCN.IdDepartamento = Convert.ToInt32(cBoxDepartamento.SelectedValue);
                capaCN.IdEstado = Convert.ToChar(cBoxEstado.SelectedValue);
                capaCN.GuardarEmpelado(capaCN);
                RefrescarGridEmpleados();
                Limpiar();
                MessageBox.Show("Datos registrados correctamente", "Exito",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void tlsBtnRegis_Limpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void frm_Registro_Empleados_Load(object sender, EventArgs e)
        {
            ProyectoCN.CN_ListarComboBox Lista = new ProyectoCN.CN_ListarComboBox();

            cBoxEstado.DataSource = Lista.Listar_Estados_EnComboBox();
            cBoxEstado.DisplayMember = "Descripcion";
            cBoxEstado.ValueMember = "IdEstado";

            cBoxTipoEmpleado.DataSource = Lista.Listar_TipoEmpleados_EnComboBox();
            cBoxTipoEmpleado.DisplayMember = "Tipo";
            cBoxTipoEmpleado.ValueMember = "IdTipoEmpleado";

            cBoxDepartamento.DataSource = Lista.Listar_Departamentos_EnComboBox();
            cBoxDepartamento.DisplayMember = "NombreDepartamento";
            cBoxDepartamento.ValueMember = "IdDepartamento";

        }

        private void RefrescarGridEmpleados()
        {
            ProyectoCN.CN_Empleados capaEmp = new ProyectoCN.CN_Empleados();
            dgvEmpleados.DataSource = capaEmp.ListarEmpleados().Tables[0];
            dgvEmpleados.Columns["IdEmpleado"].HeaderText = "ID de Empleado";
            dgvEmpleados.Columns["Cedula"].HeaderText = "Cedula";
            dgvEmpleados.Columns["Nombre"].HeaderText = "Nombre";
            dgvEmpleados.Columns["Apellidos"].HeaderText = "Apellidos";
            dgvEmpleados.Columns["Direccion"].HeaderText = "Direccion";
            dgvEmpleados.Columns["Edad"].HeaderText = "Edad";
            dgvEmpleados.Columns["Telefono1"].HeaderText = "Telefono";
            dgvEmpleados.Columns["Tipo de Empleado"].HeaderText = "Tipo Empleado";
            dgvEmpleados.Columns["Departamento"].HeaderText = "Departamento";
            dgvEmpleados.Columns["Estado"].HeaderText = "Estado";
            DesabilitarControles();
            ActivarControles();
        }

        private void tlsBtn_Consul_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                ProyectoCN.CN_Empleados CNemp = new ProyectoCN.CN_Empleados();
                CNemp.IdEmpleado = dgvEmpleados.CurrentRow.Cells[0].Value.ToString();
                CNemp.EliminarEmpleado(ref CNemp);
                RefrescarGridEmpleados();
                Limpiar();
                ActivarControles();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tlsBtn_Consul_Modificar_Click(object sender, EventArgs e)
        {
            ProyectoCN.CN_Empleados capaEmpl = new ProyectoCN.CN_Empleados();
            capaEmpl.IdEmpleado = txtIdempleado.Text;
            capaEmpl.Nombre = txtNombre.Text;
            capaEmpl.Cedula = txtCedula.Text;
            capaEmpl.Apellidos = txtApellidos.Text;
            capaEmpl.Direccion = txtDireccion.Text;
            capaEmpl.Edad = Convert.ToInt32(txtEdad.Text);
            capaEmpl.Telefono = txtTele.Text;
            capaEmpl.IdTipoEmpleado = Convert.ToInt32(cBoxTipoEmpleado.SelectedValue);
            capaEmpl.IdDepartamento = Convert.ToInt32(cBoxDepartamento.SelectedValue);
            capaEmpl.IdEstado = Convert.ToChar(cBoxEstado.SelectedValue);
            capaEmpl.ActualizarEmpleado(capaEmpl);
            RefrescarGridEmpleados();
            Limpiar();
            ActivarControles();
        }

        private void Limpiar()
        {
            txtApellidos.Clear();
            txtCedula.Clear();
            txtDireccion.Clear();
            txtEdad.Clear();
            txtIdempleado.Clear();
            txtIdempleado.Enabled = true;
            txtNombre.Clear();
            txtTele.Clear();
            cBoxDepartamento.Text = "";
            cBoxEstado.Text = "";
            cBoxTipoEmpleado.Text = "";
            DesabilitarControles();
            ActivarControles();

        }

        private void dgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEmpleados.CurrentRow.Cells[0].Selected == true || dgvEmpleados.CurrentRow.Cells[1].Selected == true ||
               dgvEmpleados.CurrentRow.Cells[2].Selected == true || dgvEmpleados.CurrentRow.Cells[3].Selected == true ||
               dgvEmpleados.CurrentRow.Cells[4].Selected == true || dgvEmpleados.CurrentRow.Cells[5].Selected == true ||
               dgvEmpleados.CurrentRow.Cells[6].Selected == true || dgvEmpleados.CurrentRow.Cells[7].Selected == true ||
               dgvEmpleados.CurrentRow.Cells[8].Selected == true)
            {
                DesabilitarControles();
                btnEliminar.Enabled = true;
                btnModificar.Enabled = true;
            }

            string idEmpleado = dgvEmpleados.CurrentRow.Cells[0].Value.ToString();
            ProyectoCN.CN_Empleados CNEmp = new ProyectoCN.CN_Empleados();
            CNEmp.IdEmpleado = idEmpleado;
            CNEmp.BuscarEmpelados(ref CNEmp);

            if (CNEmp != null)
            {
                txtIdempleado.Text = dgvEmpleados.CurrentRow.Cells[0].Value.ToString();
                txtIdempleado.Enabled = false;
                txtCedula.Text = dgvEmpleados.CurrentRow.Cells[1].Value.ToString();
                txtNombre.Text = dgvEmpleados.CurrentRow.Cells[2].Value.ToString();
                txtApellidos.Text = dgvEmpleados.CurrentRow.Cells[3].Value.ToString();
                txtDireccion.Text = dgvEmpleados.CurrentRow.Cells[4].Value.ToString();
                txtEdad.Text = dgvEmpleados.CurrentRow.Cells[5].Value.ToString();
                txtTele.Text = dgvEmpleados.CurrentRow.Cells[6].Value.ToString();

            }
        }

        private void ActivarControles()
        {
            tlsBtnRegis_Limpiar.Enabled = true;
            btnRegistrarEmp.Enabled = true;
        }

        private void DesabilitarControles()
        {
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            tlsBtnRegis_Limpiar.Enabled = false;
            btnRegistrarEmp.Enabled = false;
        }

        private void txtFiltrar_TextChanged(object sender, EventArgs e)
        {
            ProyectoCN.CN_Empleados capaCli = new ProyectoCN.CN_Empleados();
            string tipo = Convert.ToString(cBoxFiltrar.ComboBox.SelectedItem);
            string param = txtFiltrar.Text;
            dgvEmpleados.DataSource = capaCli.FiltEmpleados(tipo, param).Tables[0];
        }



    }
}
