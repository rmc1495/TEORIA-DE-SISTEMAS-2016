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
            RefrescarGridPuestos();
        }

        public static string consulta;

        #region Empleado

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

            if (txtApellido1.Text == "" || txtCedula.Text == "" || txtDireccion.Text == "" || txtApellido2.Text == "" || txtNombre.Text == "" || txtTelefono.Text == "")
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
            else if (txtTelefono.TextLength < 8)
            {
                MessageBox.Show("Formato de teléfono incorrecto", "Advertencia",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            #endregion
            try
            {
                ProyectoCN.CN_Empleados capaCN = new ProyectoCN.CN_Empleados();
                capaCN.Nombre = txtNombre.Text;
                capaCN.Apellido1 = txtApellido1.Text;
                capaCN.Apellido2 = txtApellido2.Text;
                capaCN.Cedula = txtCedula.Text;
                capaCN.IdPuesto = Convert.ToInt32(cbxPuesto.SelectedValue);
                capaCN.Direccion = txtDireccion.Text;
                capaCN.Telefono = txtTelefono.Text;
                capaCN.Correo = txtCorreo.Text;
                capaCN.FechaNacimiento = Convert.ToDateTime(dtp_FechaNacimineto.Text);
                capaCN.FechaIngreso = Convert.ToDateTime(dtp_FechaIngreso.Text);
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
            // TODO: This line of code loads data into the 'dB_TSistemasDataSet4.sp_ConsultarPuesto' table. You can move, or remove it, as needed.
            this.sp_ConsultarPuestoTableAdapter.Fill(this.dB_TSistemasDataSet4.sp_ConsultarPuesto);

        }

        private void RefrescarGridEmpleados()
        {
            ProyectoCN.CN_Empleados capaEmp = new ProyectoCN.CN_Empleados();
            dgvEmpleados.DataSource = capaEmp.ListarEmpleados().Tables[0];
            dgvEmpleados.Columns["int_IdEmpleado"].HeaderText = "ID de Empleado";
            dgvEmpleados.Columns["vrch_Cedula"].HeaderText = "Cedula";
            dgvEmpleados.Columns["vrch_Nombre"].HeaderText = "Nombre";
            dgvEmpleados.Columns["vrch_Apellido1"].HeaderText = "Apellidos";
            dgvEmpleados.Columns["vrch_Apellido2"].HeaderText = "Apellidos";
            dgvEmpleados.Columns["vrch_Direccion"].HeaderText = "Direccion";
            dgvEmpleados.Columns["vrch_Telefono"].HeaderText = "Telefono";
            dgvEmpleados.Columns["int_IdPuesto"].HeaderText = "Id de Puesto ";
            dgvEmpleados.Columns["vrch_Correo"].HeaderText = "Correo";
            dgvEmpleados.Columns["dtm_FechaNacimiento"].HeaderText = "Fecha Nacimiento";
            dgvEmpleados.Columns["dtm_FechaIngreso"].HeaderText = "Fecha Ingreso";
            DesabilitarControles();
            ActivarControles();
        }

       /* private void tlsBtn_Consul_Eliminar_Click(object sender, EventArgs e)
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
        }*/

       /* private void tlsBtn_Consul_Modificar_Click(object sender, EventArgs e)
        {
            ProyectoCN.CN_Empleados capaEmpl = new ProyectoCN.CN_Empleados();
            capaEmpl.IdEmpleado = txtApellido2.Text;
            capaEmpl.Nombre = txtNombre.Text;
            capaEmpl.Cedula = txtCedula.Text;
            capaEmpl.Apellidos = txtApellido1.Text;
            capaEmpl.Direccion = txtDireccion.Text;
            //capaEmpl.Edad = Convert.ToInt32(txtEdad.Text);
            capaEmpl.Telefono = txtTelefono.Text;
            //capaEmpl.IdTipoEmpleado = Convert.ToInt32(cBoxTipoEmpleado.SelectedValue);
            //capaEmpl.IdDepartamento = Convert.ToInt32(cBoxDepartamento.SelectedValue);
            //capaEmpl.IdEstado = Convert.ToChar(cBoxEstado.SelectedValue);
            capaEmpl.ActualizarEmpleado(capaEmpl);
            RefrescarGridEmpleados();
            Limpiar();
            ActivarControles();
        }*/

        //arreglar
        private void Limpiar()
        {
            txtApellido1.Clear();
            txtCedula.Clear();
            txtDireccion.Clear();
            //txtEdad.Clear();
            txtApellido2.Clear();
            txtApellido2.Enabled = true;
            txtNombre.Clear();
            txtTelefono.Clear();
            //cBoxDepartamento.Text = "";
            //cBoxEstado.Text = "";
            //cBoxTipoEmpleado.Text = "";
            DesabilitarControles();
            ActivarControles();

        }
        //arreglar
       /* private void dgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEmpleados.CurrentRow.Cells[0].Selected == true || dgvEmpleados.CurrentRow.Cells[1].Selected == true ||
               dgvEmpleados.CurrentRow.Cells[2].Selected == true || dgvEmpleados.CurrentRow.Cells[3].Selected == true ||
               dgvEmpleados.CurrentRow.Cells[4].Selected == true || dgvEmpleados.CurrentRow.Cells[5].Selected == true ||
               dgvEmpleados.CurrentRow.Cells[6].Selected == true || dgvEmpleados.CurrentRow.Cells[7].Selected == true ||
               dgvEmpleados.CurrentRow.Cells[8].Selected == true)
            {
                DesabilitarControles();
                btnEliminarEmp.Enabled = true;
                btnModificarEmp.Enabled = true;
            }

            string idEmpleado = dgvEmpleados.CurrentRow.Cells[0].Value.ToString();
            ProyectoCN.CN_Empleados CNEmp = new ProyectoCN.CN_Empleados();
            CNEmp.IdEmpleado = idEmpleado;
            CNEmp.BuscarEmpelados(ref CNEmp);

            if (CNEmp != null)
            {
                txtApellido2.Text = dgvEmpleados.CurrentRow.Cells[0].Value.ToString();
                txtApellido2.Enabled = false;
                txtCedula.Text = dgvEmpleados.CurrentRow.Cells[1].Value.ToString();
                txtNombre.Text = dgvEmpleados.CurrentRow.Cells[2].Value.ToString();
                txtApellido1.Text = dgvEmpleados.CurrentRow.Cells[3].Value.ToString();
                txtDireccion.Text = dgvEmpleados.CurrentRow.Cells[4].Value.ToString();
                //txtEdad.Text = dgvEmpleados.CurrentRow.Cells[5].Value.ToString();
                txtTelefono.Text = dgvEmpleados.CurrentRow.Cells[6].Value.ToString();

            }
        }*/

        private void ActivarControles()
        {
            btnLimpiarEmp.Enabled = true;
            btnRegistrarEmp.Enabled = true;
        }

        private void DesabilitarControles()
        {
            btnModificarEmp.Enabled = false;
            btnEliminarEmp.Enabled = false;
            btnLimpiarEmp.Enabled = false;
            btnRegistrarEmp.Enabled = false;
        }

         private void txtFiltrarEmpleado_TextChanged(object sender, EventArgs e)
         {
             ProyectoCN.CN_Empleados capaCli = new ProyectoCN.CN_Empleados();
             consulta = txtFiltrarEmpleado.Text;
             dgvEmpleados.DataSource = capaCli.FiltEmpleados(consulta).Tables[0];
         }

        #endregion


        #region Puesto

        private void btnRegistrarPues_Click(object sender, EventArgs e)
        {
            #region Validaciones

            if (txtDescripcionPuesto.Text == "")
            {
                MessageBox.Show("Se requieren todos los espacios completos", "Advertencia", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            #endregion
            
            try
            {
                ProyectoCN.CN_Puesto capaCN = new ProyectoCN.CN_Puesto();
                capaCN.Descripcion = txtDescripcionPuesto.Text;
                capaCN.GuardarPuesto(capaCN);
                RefrescarGridPuestos();
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

        private void btnAtrasPue_Click(object sender, EventArgs e)
        {
            if (btnRegistrarPues.Enabled == false)
            {
                Limpiar();
            }
            else
                this.Close();
        }

        private void RefrescarGridPuestos()
        {
            ProyectoCN.CN_Puesto capaPues = new ProyectoCN.CN_Puesto();
            dgvPuestos.DataSource = capaPues.ListarPuestos().Tables[0];
            dgvPuestos.Columns["int_IdPuesto"].HeaderText = "ID de Puesto";
            dgvPuestos.Columns["vrch_Descripcion"].HeaderText = "Descripcion";
            //DesabilitarControles();
            //ActivarControles();
        }

        #endregion










        //Agregar Procedure de eliminar
       /* private void btnEliminarPues_Click(object sender, EventArgs e)
        {
            try
            {
                ProyectoCN.CN_Puesto CNpues = new ProyectoCN.CN_Puesto();
                CNpues.IdPuesto = Convert.ToInt32(dgvEmpleados.CurrentRow.Cells[0].Value);
                CNpues.Eliminar(ref CNpues);
                RefrescarGridPuestos();
                //Limpiar();
                //ActivarControles();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }*/

    }
}
