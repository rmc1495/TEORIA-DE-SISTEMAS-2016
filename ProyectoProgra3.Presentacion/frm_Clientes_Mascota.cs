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

    public partial class frm_Clientes_Mascota : Form
    {
        //static int aux;

        public frm_Clientes_Mascota()
        {
            InitializeComponent();
            RefrescarGridClientes();
        }
        
       #region Validar

       private void validarCaracteres(object sender, KeyPressEventArgs e)
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
               MessageBox.Show("No se permiten caracteres especiales","Advertencia",MessageBoxButtons.OK,
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
            txtApellidos.Clear();
            txtCedula.Clear();
            txtIDCliente.Clear();
            txtNombre.Clear();
            txtTelefono.Clear();
            txtIDCliente.Enabled = true;
            cboxEstados.Text = "";
            cBoxTipoCliente.Text = "";
            DesabilitarControles();
            ActivarControles();

        }

        private void ActivarControles()
        {
            btnLimpiarCliente.Enabled = true;
            btnRegistrarCliente.Enabled = true;
        }

        private void DesabilitarControles()
        {
            btnModificarCliente.Enabled = false;
            btnEliminarCliente.Enabled = false;
            btnLimpiarCliente.Enabled = false;
            btnRegistrarCliente.Enabled = false;
            btnConsultar.Enabled = false;
        }

        #endregion

        #region Metodos

        private void frm_Clientes_Load(object sender, EventArgs e)
        {
            ProyectoCN.CN_ListarComboBox Lista = new ProyectoCN.CN_ListarComboBox();

            cboxEstados.DataSource = Lista.Listar_Estados_EnComboBox();
            cboxEstados.DisplayMember = "Descripcion";
            cboxEstados.ValueMember = "IdEstado";

            cBoxTipoCliente.DataSource = Lista.Listar_TipoClientes_EnComboBox();
            cBoxTipoCliente.DisplayMember = "Descripcion";
            cBoxTipoCliente.ValueMember = "IdTipoCliente";
        }
        
        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            #region Validaciones

            if (txtApellidos.Text == "" || txtCedula.Text == "" || txtIDCliente.Text == "" ||
                txtNombre.Text == "" || txtTelefono.Text == "")
            {
                MessageBox.Show("Se requieren todos los espacios completos", "Advertencia",
                MessageBoxButtons.OK,MessageBoxIcon.Warning);
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
                ProyectoCN.CN_Clientes capaCN = new ProyectoCN.CN_Clientes();
                capaCN.IdCliente = txtIDCliente.Text;
                capaCN.Nombre = txtNombre.Text;
                capaCN.Apellidos = txtApellidos.Text;
                capaCN.Telefono = txtTelefono.Text;
                capaCN.Cedula = txtCedula.Text;
                capaCN.IDTipoCliente = Convert.ToInt32(cBoxTipoCliente.SelectedValue);
                capaCN.IDEstado = Convert.ToChar(cboxEstados.SelectedValue);
                capaCN.GuardarCliente(capaCN);
                MessageBox.Show("Datos registrados correctamente", "Exito",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefrescarGridClientes();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnAtrasCliente_Click(object sender, EventArgs e)
        {

            if (btnRegistrarCliente.Enabled == false)
            {
                Limpiar();
            }
            else
                this.Close();
        }

        private void btnLimpiarCliente_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void RefrescarGridClientes()
        {
            ProyectoCN.CN_Clientes capaCli = new ProyectoCN.CN_Clientes();
            dgvClientes.DataSource = capaCli.ListarClientes().Tables[0];
            dgvClientes.Columns["IdCliente"].HeaderText = "ID de Cliente";
            dgvClientes.Columns["Cedula"].HeaderText = "Cedula";
            dgvClientes.Columns["Nombre"].HeaderText = "Nombre";
            dgvClientes.Columns["Apellidos"].HeaderText = "Apellidos";
            dgvClientes.Columns["Telefono"].HeaderText = "Telefono";
            dgvClientes.Columns["TipoCliente"].HeaderText = "Tipo de Cliente";
            dgvClientes.Columns["Descripcion"].HeaderText = "Estado";
            DesabilitarControles();
            ActivarControles();
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                ProyectoCN.CN_Clientes CNcli = new ProyectoCN.CN_Clientes();
                CNcli.IdCliente = dgvClientes.CurrentRow.Cells[0].Value.ToString();
                CNcli.EliminarCliente(ref CNcli);
                RefrescarGridClientes();
                Limpiar();
                ActivarControles();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            ProyectoCN.CN_Clientes capaClien = new ProyectoCN.CN_Clientes();
            capaClien.IdCliente = txtIDCliente.Text;
            capaClien.Nombre = txtNombre.Text;
            capaClien.Apellidos = txtApellidos.Text;
            capaClien.Telefono = txtTelefono.Text;
            capaClien.Cedula = txtCedula.Text;
            capaClien.IDTipoCliente = Convert.ToInt32(cBoxTipoCliente.SelectedValue);
            capaClien.IDEstado = Convert.ToChar(cboxEstados.SelectedValue);
            capaClien.ActualizarCliente(capaClien);
            RefrescarGridClientes();
            Limpiar();
            ActivarControles();
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvClientes.CurrentRow.Cells[0].Selected == true || dgvClientes.CurrentRow.Cells[1].Selected == true ||
                dgvClientes.CurrentRow.Cells[2].Selected == true || dgvClientes.CurrentRow.Cells[3].Selected == true ||
                dgvClientes.CurrentRow.Cells[4].Selected == true || dgvClientes.CurrentRow.Cells[5].Selected == true ||
                dgvClientes.CurrentRow.Cells[6].Selected == true)
            {
                DesabilitarControles();
                btnEliminarCliente.Enabled = true;
                btnModificarCliente.Enabled = true;
                btnConsultar.Enabled = true;
            }

            string idCliente = dgvClientes.CurrentRow.Cells[0].Value.ToString();
            ProyectoCN.CN_Clientes CNCli = new ProyectoCN.CN_Clientes();
            CNCli.IdCliente = idCliente;
            CNCli.BuscarClientes(ref CNCli);

            if (CNCli != null)
            {
                txtIDCliente.Text = dgvClientes.CurrentRow.Cells[0].Value.ToString();
                txtIDCliente.Enabled = false;
                txtCedula.Text = dgvClientes.CurrentRow.Cells[1].Value.ToString();
                txtNombre.Text = dgvClientes.CurrentRow.Cells[2].Value.ToString();
                txtApellidos.Text = dgvClientes.CurrentRow.Cells[3].Value.ToString();
                txtTelefono.Text = dgvClientes.CurrentRow.Cells[4].Value.ToString();

            }
        }

        #endregion

       /* private void btnFiltrar_Click(object sender, EventArgs e)
        {
            ProyectoCN.CN_Clientes capaCli = new ProyectoCN.CN_Clientes();
            string tipo = Convert.ToString(cBoxFiltrar.ComboBox.SelectedItem);
            string param = txtFiltrar.Text;
            dgvClientes.DataSource = capaCli.FiltrarClientes(tipo, param).Tables[0];
        }*/

      /*  private void btnRefrescar_Click(object sender, EventArgs e)
        {
            RefrescarGridClientes();
        }*/

        private void txtFiltrar_TextChanged(object sender, EventArgs e)
        {
            ProyectoCN.CN_Clientes capaCli = new ProyectoCN.CN_Clientes();
            string tipo = Convert.ToString(cBoxFiltrar.ComboBox.SelectedItem);
            string param = txtFiltrar.Text;
            dgvClientes.DataSource = capaCli.FiltrarClientes(tipo, param).Tables[0];
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            frm_Expediente fre = new frm_Expediente();
            fre.ShowDialog();

        }







    }
}