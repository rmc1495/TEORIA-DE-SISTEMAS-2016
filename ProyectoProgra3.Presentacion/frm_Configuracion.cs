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
    public partial class frm_Configuracion : Form
    {
        public frm_Configuracion()
        {
            InitializeComponent();
            RefrescarGridEstados();
            RefrescarGridMarcas();
            RefrescarGridCategorias();
            RefrescarGridTClientes();
            RefrescarGridTEmpleados();
            RefrescarGridRoles();
            RefrescarGridDepartamentos();
            cBoxEstadoCategoria.Text = "";
            CBoxEstadoDepartamento.Text = "";
            cBoxEstadoMarca.Text = "";
            cBoxEstadoRol.Text = "";
            cBoxEstadoTCliente.Text = "";
            cBoxEstadoTEmpleado.Text = "";

        }

        #region Validaciones

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten caractéres", "Advertencia",
                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtIdEstado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (!(char.IsLetter(e.KeyChar))) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("No se permiten caracteres especiales", "Advertencia", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                e.Handled = true;
                return;
            }
        }

        private void ValidartxtCategoria(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten caractéres", "Advertencia",
                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void ValidarEstadoCategoria(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show("Ingrese un valor correcto", "Advertencia", MessageBoxButtons.OK,
            MessageBoxIcon.Warning);
            e.Handled = true;
            return;
        }

        private void ValidarMarca(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten caractéres", "Advertencia",
                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void ValidarEstadoMarca(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show("Ingrese un valor correcto", "Advertencia", MessageBoxButtons.OK,
            MessageBoxIcon.Warning);
            e.Handled = true;
            return;
        }

        private void ValidarTiposClientes(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten caractéres", "Advertencia",
                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void ValidarEstadoTCliente(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show("Ingrese un valor correcto", "Advertencia", MessageBoxButtons.OK,
            MessageBoxIcon.Warning);
            e.Handled = true;
            return;
        }

        private void ValidarTipoEmpleado(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten caractéres", "Advertencia",
                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void ValidarEstadoTEmpleados(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show("Ingrese un valor correcto", "Advertencia", MessageBoxButtons.OK,
            MessageBoxIcon.Warning);
            e.Handled = true;
            return;
        }

        private void ValidarRoles(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten caractéres", "Advertencia",
                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void ValidarEstadoRoles(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show("Ingrese un valor correcto", "Advertencia", MessageBoxButtons.OK,
            MessageBoxIcon.Warning);
            e.Handled = true;
            return;
        }

        private void ValidarNombreDepart(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten caractéres", "Advertencia",
                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void ValidarEstadoDepart(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show("Ingrese un valor correcto", "Advertencia", MessageBoxButtons.OK,
            MessageBoxIcon.Warning);
            e.Handled = true;
            return;
        }


        #endregion

        #region Utilitario

        private void ActivarControles()
        {
            btnLimpiarEstado.Enabled = true;
            btnLimpiarCategoria.Enabled = true;
            btnLimpiarMarca.Enabled = true;
            btnLimpiarRoles.Enabled = true;
            btnLimpiarTCliente.Enabled = true;
            btnLimpiarTEmpleados.Enabled = true;
            btnLimpiarDepart.Enabled = true;
            btnRegistrarEstado.Enabled = true;
            btnRegistrarCategoria.Enabled = true;
            btnRegistrarMarca.Enabled = true;
            btnRegistrarRoles.Enabled = true;
            btnRegistrarTCliente.Enabled = true;
            btnRegistrarTEmpleados.Enabled = true;
            btnRegistrarDepart.Enabled = true;

            Limpiar();

        }

        private void DesabilitarControles()
        {
            btnActualizarEstado.Enabled = false;
            btnEliminarEstado.Enabled = false;
            btnLimpiarEstado.Enabled = false;
            btnRegistrarEstado.Enabled = false;

            btnModificarCategoria.Enabled = false;
            btnEliminarCategoria.Enabled = false;
            btnLimpiarCategoria.Enabled = false;
            btnRegistrarCategoria.Enabled = false;

            btnModificarMarca.Enabled = false;
            btnEliminarMarca.Enabled = false;
            btnLimpiarMarca.Enabled = false;
            btnRegistrarMarca.Enabled = false;

            btnModificarRoles.Enabled = false;
            btnEliminarRoles.Enabled = false;
            btnLimpiarRoles.Enabled = false;
            btnRegistrarRoles.Enabled = false;

            btnModificarTCliente.Enabled = false;
            btnEliminarTCliente.Enabled = false;
            btnLimpiarTCliente.Enabled = false;
            btnRegistrarTCliente.Enabled = false;

            btnModificarTEmpleados.Enabled = false;
            btnEliminarTEmpleados.Enabled = false;
            btnLimpiarTEmpleados.Enabled = false;
            btnRegistrarTEmpleados.Enabled = false;

            btnModificarDepart.Enabled = false;
            btnEliminarDepart.Enabled = false;
            btnLimpiarDepart.Enabled = false;
            btnRegistrarDepart.Enabled = false;
            
            Limpiar();
        }

        private void Limpiar()
        {
            txtIdEstado.Clear();
            txtNombreEstado.Clear();
            txtIdEstado.Enabled = true;
            txtCategoria.Clear();
            txtMarca.Clear();
            txtTipoCliente.Clear();
            txtDescripcionTCliente.Clear();
            txtTEmpleado.Clear();
            txtNombreRol.Clear();
            txtDescripcionRol.Clear();
            txtNombreDepartamento.Clear();
            cBoxEstadoCategoria.Text = "";
            CBoxEstadoDepartamento.Text = "";
            cBoxEstadoMarca.Text = "";
            cBoxEstadoRol.Text = "";
            cBoxEstadoTCliente.Text = "";
            cBoxEstadoTEmpleado.Text = "";
        }

        private void ActualizarTabMarcas(object sender, TabControlCancelEventArgs e)
        {


        }

        #endregion

        #region TabEstado

        private void btnRegistrarEstado_Click(object sender, EventArgs e)
        {
            if (txtIdEstado.Text == "" || txtNombreEstado.Text == "")
            {
                MessageBox.Show("Se requieren todos los espacios completos", "Advertencia",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                try
                {
                ProyectoCN.CN_Estados capaCN = new ProyectoCN.CN_Estados();
                capaCN.IdEstado = Convert.ToChar(txtIdEstado.Text);
                capaCN.Descripcion = txtNombreEstado.Text;
                capaCN.InsertarEstado(capaCN);
                RefrescarGridEstados();
                Limpiar();
                }
              catch (Exception ex)
                {
                MessageBox.Show(ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnAtrasEstado_Click(object sender, EventArgs e)
        {
            if (btnRegistrarEstado.Enabled == false)
            {
                ActivarControles();
            }
            else
                this.Close();
        }

        private void RefrescarGridEstados()
        {
            ProyectoCN.CN_Estados capaEstados = new ProyectoCN.CN_Estados();
            dgvEstados.DataSource = capaEstados.ListarEstados().Tables[0];
            dgvEstados.Columns["IdEstado"].HeaderText = "ID de Estado";
            dgvEstados.Columns["Descripcion"].HeaderText = "Descripcion";
            DesabilitarControles();
            ActivarControles();
        }

        private void btnLimpiarEstado_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnEliminarEstado_Click(object sender, EventArgs e)
        {
            try
            {
                ProyectoCN.CN_Estados estadoCN = new ProyectoCN.CN_Estados();
                estadoCN.IdEstado = Convert.ToChar(txtIdEstado.Text);
                estadoCN.EliminarEstado(ref estadoCN);
                RefrescarGridEstados();
                ActivarControles();
            }
            catch (Exception ex)
            { 
            throw new Exception(ex.Message);
            }
        }

        private void btnActualizarEstado_Click(object sender, EventArgs e)
        {
            ProyectoCN.CN_Estados capaCN = new ProyectoCN.CN_Estados();
            capaCN.IdEstado = Convert.ToChar(txtIdEstado.Text);
            capaCN.Descripcion = txtNombreEstado.Text;
            capaCN.ActualizarEstado(capaCN);
            RefrescarGridEstados();
            ActivarControles();
        }

        private void dgvEstadosSeleccionarCedas(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEstados.CurrentRow.Cells[0].Selected == true || dgvEstados.CurrentRow.Cells[1].Selected == true)
            {
                DesabilitarControles();
                btnEliminarEstado.Enabled = true;
                btnActualizarEstado.Enabled = true;
            }

            char idEst = Convert.ToChar(dgvEstados.CurrentRow.Cells[0].Value.ToString());
            ProyectoCN.CN_Estados CNestado = new ProyectoCN.CN_Estados();
            CNestado.IdEstado = idEst;
            CNestado.BuscarEstados(ref CNestado);

            if (CNestado != null)
            {
                txtIdEstado.Text = Convert.ToString(CNestado.IdEstado);
                txtIdEstado.Enabled = false;
                txtNombreEstado.Text = dgvEstados.CurrentRow.Cells[1].Value.ToString();
            }
        }

        #endregion

        #region TabMarcas

        private void btnRegistrarMarca_Click(object sender, EventArgs e)
        {
            if (txtMarca.Text == "")
            {
                MessageBox.Show("Se requieren todos los espacios completos", "Advertencia",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                try
                {
                    ProyectoCN.CN_Marcas capaCN = new ProyectoCN.CN_Marcas();
                    capaCN.Marca = txtMarca.Text;
                    capaCN.IdEstado = Convert.ToChar(cBoxEstadoMarca.SelectedValue);
                    capaCN.GuardarMarcas(capaCN);
                    RefrescarGridMarcas();
                    Limpiar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnAtrasMarca_Click(object sender, EventArgs e)
        {
            if (btnRegistrarMarca.Enabled == false)
            {
                ActivarControles();
            }
            else
                this.Close();
        }

        private void RefrescarGridMarcas()
        {
            ProyectoCN.CN_Marcas capaMarcas = new ProyectoCN.CN_Marcas();
            dgvMarca.DataSource = capaMarcas.ListarMarcas().Tables[0];
            dgvMarca.Columns["IdMarca"].HeaderText = "ID de Marca";
            dgvMarca.Columns["Marca"].HeaderText = "Marca";
            dgvMarca.Columns["IdEstado"].HeaderText = "ID de Estado";
            DesabilitarControles();
            ActivarControles();
        }

        private void btnLimpiarMarca_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnEliminarMarca_Click(object sender, EventArgs e)
        {
            try
            {
                ProyectoCN.CN_Marcas CNmarcas = new ProyectoCN.CN_Marcas();
                CNmarcas.IdMarca = Convert.ToInt32(dgvMarca.CurrentRow.Cells[0].Value.ToString()); ;
                CNmarcas.EliminarMarca(ref CNmarcas);
                RefrescarGridMarcas();
                ActivarControles();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificarMarca_Click(object sender, EventArgs e)
        {
            ProyectoCN.CN_Marcas capaCN = new ProyectoCN.CN_Marcas();
            capaCN.IdMarca = Convert.ToInt32(dgvMarca.CurrentRow.Cells[0].Value.ToString());
            capaCN.Marca = txtMarca.Text;
            capaCN.IdEstado = Convert.ToChar(cBoxEstadoMarca.SelectedValue);
            capaCN.ActualizarMarca(capaCN);
            RefrescarGridMarcas();
            Limpiar();
            ActivarControles();
        }

        private void dgvMarca_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMarca.CurrentRow.Cells[0].Selected == true || dgvMarca.CurrentRow.Cells[1].Selected == true ||
                  dgvMarca.CurrentRow.Cells[2].Selected)
            {
                DesabilitarControles();
                btnEliminarMarca.Enabled = true;
                btnModificarMarca.Enabled = true;
            }

            int idMar = Convert.ToInt32(dgvMarca.CurrentRow.Cells[0].Value.ToString());
            ProyectoCN.CN_Marcas CNmarcas = new ProyectoCN.CN_Marcas();
            CNmarcas.IdMarca = idMar;
            CNmarcas.BuscarMarcas(ref CNmarcas);

            if (CNmarcas != null)
            {
                txtMarca.Text = dgvMarca.CurrentRow.Cells[1].Value.ToString();
            }
        }



        #endregion

        #region TabCategorias

        private void btnRegistrarCategoria_Click(object sender, EventArgs e)
        {
            if (txtCategoria.Text == "")
            {
                MessageBox.Show("Se requieren todos los espacios completos", "Advertencia",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                try
                {
                    ProyectoCN.CN_Categorias capaCN = new ProyectoCN.CN_Categorias();
                    capaCN.Categoria = txtCategoria.Text;
                    capaCN.IdEstado = Convert.ToChar(cBoxEstadoCategoria.SelectedValue);
                    capaCN.GuardarCategoria(capaCN);
                    RefrescarGridCategorias();
                    Limpiar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnAtrasCategoria_Click(object sender, EventArgs e)
        {
            if (btnRegistrarCategoria.Enabled == false)
            {
                ActivarControles();
            }
            else
                this.Close();
        }

        private void RefrescarGridCategorias()
        {
            ProyectoCN.CN_Categorias capaCat = new ProyectoCN.CN_Categorias();
            dgvCategoria.DataSource = capaCat.ListarCategorias().Tables[0];
            dgvCategoria.Columns["IdCategoria"].HeaderText = "ID de Categoria";
            dgvCategoria.Columns["Categoria"].HeaderText = "Categoria";
            dgvCategoria.Columns["IdEstado"].HeaderText = "ID de Estado";
            DesabilitarControles();
            ActivarControles();
        }

        private void btnLimpiarCategoria_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnEliminarCategoria_Click(object sender, EventArgs e)
        {
            try
            {
                ProyectoCN.CN_Categorias CNcat = new ProyectoCN.CN_Categorias();
                CNcat.IdCategoria = Convert.ToInt32(dgvCategoria.CurrentRow.Cells[0].Value.ToString()); ;
                CNcat.EliminarCategorias(ref CNcat);
                RefrescarGridCategorias();
                ActivarControles();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", 
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificarCategoria_Click(object sender, EventArgs e)
        {
            ProyectoCN.CN_Categorias capaCN = new ProyectoCN.CN_Categorias();
            capaCN.IdCategoria = Convert.ToInt32(dgvCategoria.CurrentRow.Cells[0].Value.ToString());
            capaCN.Categoria = txtCategoria.Text;
            capaCN.IdEstado = Convert.ToChar(cBoxEstadoCategoria.SelectedValue);
            capaCN.ActualizarCategorias(capaCN);
            RefrescarGridCategorias();
            Limpiar();
            ActivarControles();
        }

        private void dgvCategoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCategoria.CurrentRow.Cells[0].Selected == true || dgvCategoria.CurrentRow.Cells[1].Selected == true ||
                  dgvCategoria.CurrentRow.Cells[2].Selected)
            {
                DesabilitarControles();
                btnEliminarCategoria.Enabled = true;
                btnModificarCategoria.Enabled = true;
            }

            int idCat = Convert.ToInt32(dgvCategoria.CurrentRow.Cells[0].Value.ToString());
            ProyectoCN.CN_Categorias CNcat = new ProyectoCN.CN_Categorias();
            CNcat.IdCategoria = idCat;
            CNcat.BuscarCategorias(ref CNcat);

            if (CNcat != null)
            {
                txtCategoria.Text = dgvCategoria.CurrentRow.Cells[1].Value.ToString();
            }
        }

        #endregion

        #region TabTiposClientes

        private void btnRegistrarTCliente_Click(object sender, EventArgs e)
        {
            if (txtTipoCliente.Text == "" || txtDescripcionTCliente.Text == "")
            {
                MessageBox.Show("Se requieren todos los espacios completos", "Advertencia",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                try
                {
                    ProyectoCN.CN_TipoClientes capaCN = new ProyectoCN.CN_TipoClientes();
                    capaCN.TipoCliente = txtTipoCliente.Text;
                    capaCN.Descripcion = txtDescripcionTCliente.Text;
                    capaCN.IDEstado = Convert.ToChar(cBoxEstadoTCliente.SelectedValue);
                    capaCN.GuardarTipoClientes(capaCN);
                    RefrescarGridTClientes();
                    Limpiar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAtrasTCliente_Click(object sender, EventArgs e)
        {
            if (btnRegistrarTCliente.Enabled == false)
            {
                ActivarControles();
            }
            else
                this.Close();
        }

        private void RefrescarGridTClientes()
        {
            ProyectoCN.CN_TipoClientes capaCli = new ProyectoCN.CN_TipoClientes();
            dgvTCliente.DataSource = capaCli.ListarTipoClientes().Tables[0];
            dgvTCliente.Columns["IdTipoCliente"].HeaderText = "ID Tipo de Cliente";
            dgvTCliente.Columns["TipoCliente"].HeaderText = "Tipo de Cliente";
            dgvTCliente.Columns["Descripcion"].HeaderText = "Descripcion";
            dgvTCliente.Columns["IdEstado"].HeaderText = "ID de Estado";
            DesabilitarControles();
            ActivarControles();
        }

        private void btnLimpiarTCliente_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnEliminarTCliente_Click(object sender, EventArgs e)
        {
            try
            {
                ProyectoCN.CN_TipoClientes CNclie = new ProyectoCN.CN_TipoClientes();
                CNclie.IdTipoCliente = Convert.ToInt32(dgvTCliente.CurrentRow.Cells[0].Value.ToString()); ;
                CNclie.EliminarTipoClientes(ref CNclie);
                RefrescarGridTClientes();
                ActivarControles();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificarTCliente_Click(object sender, EventArgs e)
        {
            ProyectoCN.CN_TipoClientes capaClie = new ProyectoCN.CN_TipoClientes();
            capaClie.IdTipoCliente = Convert.ToInt32(dgvTCliente.CurrentRow.Cells[0].Value.ToString());
            capaClie.TipoCliente = txtTipoCliente.Text;
            capaClie.Descripcion = txtDescripcionTCliente.Text;
            capaClie.IDEstado = Convert.ToChar(cBoxEstadoTCliente.SelectedValue);
            capaClie.ActualizarTipoClientes(capaClie);
            RefrescarGridTClientes();
            Limpiar();
            ActivarControles();
        }

        private void dgvTCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTCliente.CurrentRow.Cells[0].Selected == true || dgvTCliente.CurrentRow.Cells[1].Selected == true ||
                  dgvTCliente.CurrentRow.Cells[2].Selected == true || dgvTCliente.CurrentRow.Cells[3].Selected == true)
            {
                DesabilitarControles();
                btnEliminarTCliente.Enabled = true;
                btnModificarTCliente.Enabled = true;
            }

            int idCliente = Convert.ToInt32(dgvTCliente.CurrentRow.Cells[0].Value.ToString());
            ProyectoCN.CN_TipoClientes CNclie = new ProyectoCN.CN_TipoClientes();
            CNclie.IdTipoCliente = idCliente;
            CNclie.BuscarTipoClientes(ref CNclie);

            if (CNclie != null)
            {
                txtTipoCliente.Text = dgvTCliente.CurrentRow.Cells[1].Value.ToString();
                txtDescripcionTCliente.Text = dgvTCliente.CurrentRow.Cells[2].Value.ToString();
            }
        }

        #endregion

        #region TabTiposEmpleados

        private void btnRegistrarTEmpleados_Click(object sender, EventArgs e)
        {
            if (txtTEmpleado.Text == "")
            {
                MessageBox.Show("Se requieren todos los espacios completos", "Advertencia",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                try
                {
                    ProyectoCN.CN_TipoEmpleados capaCN = new ProyectoCN.CN_TipoEmpleados();
                    capaCN.Tipo = txtTEmpleado.Text;
                    capaCN.IDEstado = Convert.ToChar(cBoxEstadoTEmpleado.SelectedValue);
                    capaCN.GuardarTipoEmpleados(capaCN);
                    RefrescarGridTEmpleados();
                    Limpiar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAtrasTEmpleados_Click(object sender, EventArgs e)
        {
            if (btnRegistrarTEmpleados.Enabled == false)
            {
                ActivarControles();
            }
            else
                this.Close();
        }

        private void RefrescarGridTEmpleados()
        {
            ProyectoCN.CN_TipoEmpleados capaEmp = new ProyectoCN.CN_TipoEmpleados();
            dgvTEmpleados.DataSource = capaEmp.ListarTipoEmpleados().Tables[0];
            dgvTEmpleados.Columns["IdTipoEmpleado"].HeaderText = "ID Tipo de Empleado";
            dgvTEmpleados.Columns["Tipo"].HeaderText = "Tipo de Empleado";
            dgvTEmpleados.Columns["IdEstado"].HeaderText = "ID de Estado";
            DesabilitarControles();
            ActivarControles();
        }

        private void btnLimpiarTEmpleados_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnEliminarTEmpleados_Click(object sender, EventArgs e)
        {
            try
            {
                ProyectoCN.CN_TipoEmpleados CNem = new ProyectoCN.CN_TipoEmpleados();
                CNem.IdTipoEmpleado = Convert.ToInt32(dgvTEmpleados.CurrentRow.Cells[0].Value.ToString()); ;
                CNem.EliminarTipoEmpleados(ref CNem);
                RefrescarGridTEmpleados();
                ActivarControles();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificarTEmpleados_Click(object sender, EventArgs e)
        {
            ProyectoCN.CN_TipoEmpleados capaEmp = new ProyectoCN.CN_TipoEmpleados();
            capaEmp.IdTipoEmpleado = Convert.ToInt32(dgvTEmpleados.CurrentRow.Cells[0].Value.ToString());
            capaEmp.Tipo= txtTEmpleado.Text;
            capaEmp.IDEstado = Convert.ToChar(cBoxEstadoTCliente.SelectedValue);
            capaEmp.ActualizarTipoEmpleados(capaEmp);
            RefrescarGridTEmpleados();
            Limpiar();
            ActivarControles();
        }

        private void dgvTEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTEmpleados.CurrentRow.Cells[0].Selected == true || dgvTEmpleados.CurrentRow.Cells[1].Selected == true ||
                  dgvTEmpleados.CurrentRow.Cells[2].Selected == true)
            {
                DesabilitarControles();
                btnEliminarTEmpleados.Enabled = true;
                btnModificarTEmpleados.Enabled = true;
            }

            int idTEmp = Convert.ToInt32(dgvTEmpleados.CurrentRow.Cells[0].Value.ToString());
            ProyectoCN.CN_TipoEmpleados CNemp = new ProyectoCN.CN_TipoEmpleados();
            CNemp.IdTipoEmpleado = idTEmp;
            CNemp.BuscarTipoEmpleados(ref CNemp);

            if (CNemp != null)
            {
                txtTEmpleado.Text = dgvTEmpleados.CurrentRow.Cells[1].Value.ToString();
            }
        }

        #endregion

        #region TabRoles

        private void btnRegistrarRoles_Click(object sender, EventArgs e)
        {
            if (txtNombreRol.Text == "" || txtDescripcionRol.Text == "")
            {
                MessageBox.Show("Se requieren todos los espacios completos", "Advertencia",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                try
                {
                    ProyectoCN.CN_Roles capaCN = new ProyectoCN.CN_Roles();
                    capaCN.Nombre = txtNombreRol.Text;
                    capaCN.DescripcionRol = txtDescripcionRol.Text;
                    capaCN.IDEstado = Convert.ToChar(cBoxEstadoRol.SelectedValue);
                    capaCN.GuardarRoles(capaCN);
                    RefrescarGridRoles();
                    Limpiar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAtrasRoles_Click(object sender, EventArgs e)
        {
            if (btnRegistrarRoles.Enabled == false)
            {
                ActivarControles();
            }
            else
                this.Close();
        }

        private void RefrescarGridRoles()
        {
            ProyectoCN.CN_Roles capaRol = new ProyectoCN.CN_Roles();
            dgvRoles.DataSource = capaRol.ListarRoles().Tables[0];
            dgvRoles.Columns["Id_Rol"].HeaderText = "ID Rol";
            dgvRoles.Columns["Nombre"].HeaderText = "Nombre del Rol";
            dgvRoles.Columns["Descripcion"].HeaderText = "Descripcion del Rol";
            dgvRoles.Columns["IdEstado"].HeaderText = "ID de Estado";
            DesabilitarControles();
            ActivarControles();
        }

        private void btnLimpiarRoles_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnEliminarRoles_Click(object sender, EventArgs e)
        {
            try
            {
                ProyectoCN.CN_Roles CNrol = new ProyectoCN.CN_Roles();
                CNrol.IdRol = Convert.ToInt32(dgvRoles.CurrentRow.Cells[0].Value.ToString()); ;
                CNrol.EliminarRoles(ref CNrol);
                RefrescarGridRoles();
                ActivarControles();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificarRoles_Click(object sender, EventArgs e)
        {
            ProyectoCN.CN_Roles capaRol = new ProyectoCN.CN_Roles();
            capaRol.IdRol = Convert.ToInt32(dgvRoles.CurrentRow.Cells[0].Value.ToString());
            capaRol.Nombre = txtNombreRol.Text;
            capaRol.DescripcionRol = txtDescripcionRol.Text;
            capaRol.IDEstado = Convert.ToChar(cBoxEstadoRol.SelectedValue);
            capaRol.ActualizarRoles(capaRol);
            RefrescarGridRoles();
            Limpiar();
            ActivarControles();
        }

        private void dgvRoles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvRoles.CurrentRow.Cells[0].Selected == true || dgvRoles.CurrentRow.Cells[1].Selected == true ||
                  dgvRoles.CurrentRow.Cells[2].Selected == true || dgvRoles.CurrentRow.Cells[3].Selected == true)
            {
                DesabilitarControles();
                btnEliminarRoles.Enabled = true;
                btnModificarRoles.Enabled = true;
            }

            int idRol = Convert.ToInt32(dgvRoles.CurrentRow.Cells[0].Value.ToString());
            ProyectoCN.CN_Roles CNrol = new ProyectoCN.CN_Roles();
            CNrol.IdRol= idRol;
            CNrol.BuscarRoles(ref CNrol);

            if (CNrol != null)
            {
                txtNombreRol.Text = dgvRoles.CurrentRow.Cells[1].Value.ToString();
                txtDescripcionRol.Text = dgvRoles.CurrentRow.Cells[2].Value.ToString();
            }
        }

        #endregion

        #region TabDepartamentos

        private void btnRegistrarDepart_Click(object sender, EventArgs e)
        {
            if (txtNombreDepartamento.Text == "")
            {
                MessageBox.Show("Se requieren todos los espacios completos", "Advertencia",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                try
                {
                    ProyectoCN.CN_Departamentos capaCN = new ProyectoCN.CN_Departamentos();
                    capaCN.NombreDepartamento = txtNombreDepartamento.Text;
                    capaCN.IdEstado = Convert.ToChar(CBoxEstadoDepartamento.SelectedValue);
                    capaCN.GuardarDepartamento(capaCN);
                    RefrescarGridDepartamentos();
                    Limpiar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAtrasDepart_Click(object sender, EventArgs e)
        {
            if (btnRegistrarDepart.Enabled == false)
            {
                ActivarControles();
            }
            else
                this.Close();
        }

        private void RefrescarGridDepartamentos()
        {
            ProyectoCN.CN_Departamentos capaDep = new ProyectoCN.CN_Departamentos();
            dgvDepartamentos.DataSource = capaDep.ListarDepartamentos().Tables[0];
            dgvDepartamentos.Columns["IdDepartamento"].HeaderText = "ID de Departamento";
            dgvDepartamentos.Columns["NombreDepartamento"].HeaderText = "Nombre de Departamento";
            dgvDepartamentos.Columns["IdEstado"].HeaderText = "ID de Estado";
            DesabilitarControles();
            ActivarControles();
        }

        private void btnLimpiarDepart_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnEliminarDepart_Click(object sender, EventArgs e)
        {
            try
            {
                ProyectoCN.CN_Departamentos CNdep = new ProyectoCN.CN_Departamentos();
                CNdep.IdDepartamento = Convert.ToInt32(dgvDepartamentos.CurrentRow.Cells[0].Value.ToString()); ;
                CNdep.EliminarDepartamento(ref CNdep);
                RefrescarGridDepartamentos();
                ActivarControles();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificarDepart_Click(object sender, EventArgs e)
        {
            ProyectoCN.CN_Departamentos capaDep = new ProyectoCN.CN_Departamentos();
            capaDep.IdDepartamento = Convert.ToInt32(dgvDepartamentos.CurrentRow.Cells[0].Value.ToString());
            capaDep.NombreDepartamento = txtNombreDepartamento.Text;
            capaDep.IdEstado = Convert.ToChar(CBoxEstadoDepartamento.SelectedValue);
            capaDep.ActualizarDepartamento(capaDep);
            RefrescarGridDepartamentos();
            Limpiar();
            ActivarControles();
        }

        private void dgvDepartamentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDepartamentos.CurrentRow.Cells[0].Selected == true || dgvDepartamentos.CurrentRow.Cells[1].Selected == true ||
            dgvDepartamentos.CurrentRow.Cells[2].Selected == true)
            {
                DesabilitarControles();
                btnEliminarDepart.Enabled = true;
                btnModificarDepart.Enabled = true;
            }

            int idDep = Convert.ToInt32(dgvDepartamentos.CurrentRow.Cells[0].Value.ToString());
            ProyectoCN.CN_Departamentos CNdep = new ProyectoCN.CN_Departamentos();
            CNdep.IdDepartamento= idDep;
            CNdep.BuscarDepartamentos(ref CNdep);

            if (CNdep != null)
            {
                txtNombreDepartamento.Text = dgvDepartamentos.CurrentRow.Cells[1].Value.ToString();
            }
        }

        #endregion

        private void tabConfiguraciones_Selected(object sender, TabControlEventArgs e)
        {
            ProyectoCN.CN_ListarComboBox Lista = new ProyectoCN.CN_ListarComboBox();
            cBoxEstadoMarca.DataSource = Lista.Listar_Estados_EnComboBox();
            cBoxEstadoMarca.DisplayMember = "Descripcion";
            cBoxEstadoMarca.ValueMember = "IdEstado";

            cBoxEstadoCategoria.DataSource = Lista.Listar_Estados_EnComboBox();
            cBoxEstadoCategoria.DisplayMember = "Descripcion";
            cBoxEstadoCategoria.ValueMember = "IdEstado";

            cBoxEstadoTCliente.DataSource = Lista.Listar_Estados_EnComboBox();
            cBoxEstadoTCliente.DisplayMember = "Descripcion";
            cBoxEstadoTCliente.ValueMember = "IdEstado";

            cBoxEstadoTEmpleado.DataSource = Lista.Listar_Estados_EnComboBox();
            cBoxEstadoTEmpleado.DisplayMember = "Descripcion";
            cBoxEstadoTEmpleado.ValueMember = "IdEstado";

            cBoxEstadoRol.DataSource = Lista.Listar_Estados_EnComboBox();
            cBoxEstadoRol.DisplayMember = "Descripcion";
            cBoxEstadoRol.ValueMember = "IdEstado";

            CBoxEstadoDepartamento.DataSource = Lista.Listar_Estados_EnComboBox();
            CBoxEstadoDepartamento.DisplayMember = "Descripcion";
            CBoxEstadoDepartamento.ValueMember = "IdEstado";

            Limpiar();
            DesabilitarControles();
            ActivarControles();
        }

        private void frm_Configuracion_Load(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
