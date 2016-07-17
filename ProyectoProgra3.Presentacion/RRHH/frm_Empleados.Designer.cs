namespace ProyectoProgra3
{
    partial class frm_Empleados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Empleados));
            this.tbc_Empleados = new System.Windows.Forms.TabControl();
            this.tb_Empleado = new System.Windows.Forms.TabPage();
            this.dtp_FechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.dtp_FechaNacimineto = new System.Windows.Forms.DateTimePicker();
            this.CbxPuesto = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.tlsBtnRegis_Guardar = new System.Windows.Forms.ToolStrip();
            this.btnRegistrarEmp = new System.Windows.Forms.ToolStripButton();
            this.btnEliminarEmp = new System.Windows.Forms.ToolStripButton();
            this.btnModificarEmp = new System.Windows.Forms.ToolStripButton();
            this.btnLimpiarEmp = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAtrasEmp = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtFiltrarEmpleado = new System.Windows.Forms.ToolStripTextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtApellido1 = new System.Windows.Forms.TextBox();
            this.txtApellido2 = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.tb_Mant_Empleados = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnRegistrarPues = new System.Windows.Forms.ToolStripButton();
            this.btnEliminarPues = new System.Windows.Forms.ToolStripButton();
            this.btnModificarPues = new System.Windows.Forms.ToolStripButton();
            this.btnLimpiarPues = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAtrasPue = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.txtFiltrarPuesto = new System.Windows.Forms.ToolStripTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtDescripcionPuesto = new System.Windows.Forms.TextBox();
            this.tbc_Empleados.SuspendLayout();
            this.tb_Empleado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.tlsBtnRegis_Guardar.SuspendLayout();
            this.tb_Mant_Empleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbc_Empleados
            // 
            this.tbc_Empleados.Controls.Add(this.tb_Empleado);
            this.tbc_Empleados.Controls.Add(this.tb_Mant_Empleados);
            this.tbc_Empleados.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbc_Empleados.ItemSize = new System.Drawing.Size(65, 25);
            this.tbc_Empleados.Location = new System.Drawing.Point(12, 12);
            this.tbc_Empleados.Name = "tbc_Empleados";
            this.tbc_Empleados.SelectedIndex = 0;
            this.tbc_Empleados.Size = new System.Drawing.Size(860, 405);
            this.tbc_Empleados.TabIndex = 0;
            // 
            // tb_Empleado
            // 
            this.tb_Empleado.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.tb_Empleado.Controls.Add(this.dtp_FechaIngreso);
            this.tb_Empleado.Controls.Add(this.dtp_FechaNacimineto);
            this.tb_Empleado.Controls.Add(this.CbxPuesto);
            this.tb_Empleado.Controls.Add(this.label10);
            this.tb_Empleado.Controls.Add(this.label9);
            this.tb_Empleado.Controls.Add(this.label6);
            this.tb_Empleado.Controls.Add(this.txtCorreo);
            this.tb_Empleado.Controls.Add(this.dgvEmpleados);
            this.tb_Empleado.Controls.Add(this.tlsBtnRegis_Guardar);
            this.tb_Empleado.Controls.Add(this.txtCedula);
            this.tb_Empleado.Controls.Add(this.label8);
            this.tb_Empleado.Controls.Add(this.label1);
            this.tb_Empleado.Controls.Add(this.label2);
            this.tb_Empleado.Controls.Add(this.label3);
            this.tb_Empleado.Controls.Add(this.txtTelefono);
            this.tb_Empleado.Controls.Add(this.label4);
            this.tb_Empleado.Controls.Add(this.txtDireccion);
            this.tb_Empleado.Controls.Add(this.label5);
            this.tb_Empleado.Controls.Add(this.label7);
            this.tb_Empleado.Controls.Add(this.txtApellido1);
            this.tb_Empleado.Controls.Add(this.txtApellido2);
            this.tb_Empleado.Controls.Add(this.txtNombre);
            this.tb_Empleado.Location = new System.Drawing.Point(4, 29);
            this.tb_Empleado.Name = "tb_Empleado";
            this.tb_Empleado.Padding = new System.Windows.Forms.Padding(3);
            this.tb_Empleado.Size = new System.Drawing.Size(852, 372);
            this.tb_Empleado.TabIndex = 0;
            this.tb_Empleado.Text = "Empleados";
            // 
            // dtp_FechaIngreso
            // 
            this.dtp_FechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_FechaIngreso.Location = new System.Drawing.Point(169, 204);
            this.dtp_FechaIngreso.Name = "dtp_FechaIngreso";
            this.dtp_FechaIngreso.Size = new System.Drawing.Size(156, 29);
            this.dtp_FechaIngreso.TabIndex = 88;
            this.dtp_FechaIngreso.Value = new System.DateTime(2016, 7, 10, 0, 0, 0, 0);
            // 
            // dtp_FechaNacimineto
            // 
            this.dtp_FechaNacimineto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_FechaNacimineto.Location = new System.Drawing.Point(546, 204);
            this.dtp_FechaNacimineto.Name = "dtp_FechaNacimineto";
            this.dtp_FechaNacimineto.Size = new System.Drawing.Size(147, 29);
            this.dtp_FechaNacimineto.TabIndex = 86;
            this.dtp_FechaNacimineto.Value = new System.DateTime(2016, 7, 10, 17, 37, 21, 0);
            // 
            // CbxPuesto
            // 
            this.CbxPuesto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxPuesto.FormattingEnabled = true;
            this.CbxPuesto.Location = new System.Drawing.Point(555, 159);
            this.CbxPuesto.Name = "CbxPuesto";
            this.CbxPuesto.Size = new System.Drawing.Size(138, 28);
            this.CbxPuesto.TabIndex = 84;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(471, 161);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 21);
            this.label10.TabIndex = 85;
            this.label10.Text = "Puesto:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(353, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(175, 21);
            this.label9.TabIndex = 69;
            this.label9.Text = "Fecha de Nacimineto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 21);
            this.label6.TabIndex = 67;
            this.label6.Text = "Fecha de Ingreso:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(144, 159);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(265, 27);
            this.txtCorreo.TabIndex = 66;
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.AllowUserToAddRows = false;
            this.dgvEmpleados.AllowUserToDeleteRows = false;
            this.dgvEmpleados.AllowUserToOrderColumns = true;
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Location = new System.Drawing.Point(2, 308);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.ReadOnly = true;
            this.dgvEmpleados.Size = new System.Drawing.Size(848, 62);
            this.dgvEmpleados.TabIndex = 65;
            // 
            // tlsBtnRegis_Guardar
            // 
            this.tlsBtnRegis_Guardar.AutoSize = false;
            this.tlsBtnRegis_Guardar.BackColor = System.Drawing.Color.LightGreen;
            this.tlsBtnRegis_Guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tlsBtnRegis_Guardar.Dock = System.Windows.Forms.DockStyle.None;
            this.tlsBtnRegis_Guardar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tlsBtnRegis_Guardar.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.tlsBtnRegis_Guardar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRegistrarEmp,
            this.btnEliminarEmp,
            this.btnModificarEmp,
            this.btnLimpiarEmp,
            this.toolStripSeparator1,
            this.btnAtrasEmp,
            this.toolStripSeparator2,
            this.toolStripLabel1,
            this.txtFiltrarEmpleado});
            this.tlsBtnRegis_Guardar.Location = new System.Drawing.Point(2, 265);
            this.tlsBtnRegis_Guardar.Name = "tlsBtnRegis_Guardar";
            this.tlsBtnRegis_Guardar.Size = new System.Drawing.Size(848, 40);
            this.tlsBtnRegis_Guardar.TabIndex = 64;
            this.tlsBtnRegis_Guardar.Text = "Registrar Empleado";
            // 
            // btnRegistrarEmp
            // 
            this.btnRegistrarEmp.AutoSize = false;
            this.btnRegistrarEmp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRegistrarEmp.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrarEmp.Image")));
            this.btnRegistrarEmp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRegistrarEmp.Name = "btnRegistrarEmp";
            this.btnRegistrarEmp.Size = new System.Drawing.Size(40, 40);
            this.btnRegistrarEmp.Text = "Registrar";
            // 
            // btnEliminarEmp
            // 
            this.btnEliminarEmp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEliminarEmp.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarEmp.Image")));
            this.btnEliminarEmp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminarEmp.Name = "btnEliminarEmp";
            this.btnEliminarEmp.Size = new System.Drawing.Size(29, 37);
            this.btnEliminarEmp.Text = "Eliminar";
            // 
            // btnModificarEmp
            // 
            this.btnModificarEmp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnModificarEmp.Image = ((System.Drawing.Image)(resources.GetObject("btnModificarEmp.Image")));
            this.btnModificarEmp.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnModificarEmp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModificarEmp.Name = "btnModificarEmp";
            this.btnModificarEmp.Size = new System.Drawing.Size(36, 37);
            this.btnModificarEmp.Text = "Modificar";
            // 
            // btnLimpiarEmp
            // 
            this.btnLimpiarEmp.AutoSize = false;
            this.btnLimpiarEmp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLimpiarEmp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLimpiarEmp.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiarEmp.Image")));
            this.btnLimpiarEmp.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnLimpiarEmp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLimpiarEmp.Margin = new System.Windows.Forms.Padding(0);
            this.btnLimpiarEmp.Name = "btnLimpiarEmp";
            this.btnLimpiarEmp.Size = new System.Drawing.Size(40, 40);
            this.btnLimpiarEmp.Text = "Limpiar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 40);
            // 
            // btnAtrasEmp
            // 
            this.btnAtrasEmp.AutoSize = false;
            this.btnAtrasEmp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAtrasEmp.Image = ((System.Drawing.Image)(resources.GetObject("btnAtrasEmp.Image")));
            this.btnAtrasEmp.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAtrasEmp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAtrasEmp.Name = "btnAtrasEmp";
            this.btnAtrasEmp.Size = new System.Drawing.Size(40, 40);
            this.btnAtrasEmp.Text = "Atrás";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 40);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(61, 37);
            this.toolStripLabel1.Text = "Buscar:";
            // 
            // txtFiltrarEmpleado
            // 
            this.txtFiltrarEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiltrarEmpleado.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltrarEmpleado.Name = "txtFiltrarEmpleado";
            this.txtFiltrarEmpleado.Size = new System.Drawing.Size(130, 40);
            // 
            // txtCedula
            // 
            this.txtCedula.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedula.Location = new System.Drawing.Point(391, 31);
            this.txtCedula.MaxLength = 9;
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(137, 27);
            this.txtCedula.TabIndex = 51;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 21);
            this.label8.TabIndex = 61;
            this.label8.Text = "Correo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(437, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 21);
            this.label1.TabIndex = 44;
            this.label1.Text = "2do Apellido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 21);
            this.label2.TabIndex = 46;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(318, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 21);
            this.label3.TabIndex = 49;
            this.label3.Text = "Cedula:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(640, 31);
            this.txtTelefono.MaxLength = 8;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(191, 27);
            this.txtTelefono.TabIndex = 57;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 21);
            this.label4.TabIndex = 50;
            this.label4.Text = "1er Apellido:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(144, 115);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(687, 27);
            this.txtDireccion.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 21);
            this.label5.TabIndex = 53;
            this.label5.Text = "Dirección:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(541, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 21);
            this.label7.TabIndex = 56;
            this.label7.Text = "Telefono:";
            // 
            // txtApellido1
            // 
            this.txtApellido1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido1.Location = new System.Drawing.Point(145, 72);
            this.txtApellido1.Name = "txtApellido1";
            this.txtApellido1.Size = new System.Drawing.Size(264, 27);
            this.txtApellido1.TabIndex = 47;
            // 
            // txtApellido2
            // 
            this.txtApellido2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido2.Location = new System.Drawing.Point(555, 72);
            this.txtApellido2.Name = "txtApellido2";
            this.txtApellido2.Size = new System.Drawing.Size(276, 27);
            this.txtApellido2.TabIndex = 48;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(145, 31);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(153, 27);
            this.txtNombre.TabIndex = 45;
            // 
            // tb_Mant_Empleados
            // 
            this.tb_Mant_Empleados.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.tb_Mant_Empleados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Mant_Empleados.Controls.Add(this.label12);
            this.tb_Mant_Empleados.Controls.Add(this.dataGridView1);
            this.tb_Mant_Empleados.Controls.Add(this.toolStrip1);
            this.tb_Mant_Empleados.Controls.Add(this.label16);
            this.tb_Mant_Empleados.Controls.Add(this.txtDescripcionPuesto);
            this.tb_Mant_Empleados.Location = new System.Drawing.Point(4, 29);
            this.tb_Mant_Empleados.Name = "tb_Mant_Empleados";
            this.tb_Mant_Empleados.Padding = new System.Windows.Forms.Padding(3);
            this.tb_Mant_Empleados.Size = new System.Drawing.Size(852, 372);
            this.tb_Mant_Empleados.TabIndex = 1;
            this.tb_Mant_Empleados.Text = "Mantenimiento";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(33, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(215, 21);
            this.label12.TabIndex = 106;
            this.label12.Text = "Mantenimineto de Puestos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 307);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(848, 62);
            this.dataGridView1.TabIndex = 103;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.LightGreen;
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRegistrarPues,
            this.btnEliminarPues,
            this.btnModificarPues,
            this.btnLimpiarPues,
            this.toolStripSeparator3,
            this.btnAtrasPue,
            this.toolStripSeparator4,
            this.toolStripLabel2,
            this.txtFiltrarPuesto});
            this.toolStrip1.Location = new System.Drawing.Point(1, 264);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(848, 40);
            this.toolStrip1.TabIndex = 102;
            this.toolStrip1.Text = "Registrar Empleado";
            // 
            // btnRegistrarPues
            // 
            this.btnRegistrarPues.AutoSize = false;
            this.btnRegistrarPues.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRegistrarPues.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrarPues.Image")));
            this.btnRegistrarPues.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRegistrarPues.Name = "btnRegistrarPues";
            this.btnRegistrarPues.Size = new System.Drawing.Size(40, 40);
            this.btnRegistrarPues.Text = "Registrar";
            this.btnRegistrarPues.Click += new System.EventHandler(this.btnRegistrarPues_Click);
            // 
            // btnEliminarPues
            // 
            this.btnEliminarPues.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEliminarPues.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarPues.Image")));
            this.btnEliminarPues.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminarPues.Name = "btnEliminarPues";
            this.btnEliminarPues.Size = new System.Drawing.Size(29, 37);
            this.btnEliminarPues.Text = "Eliminar";
            // 
            // btnModificarPues
            // 
            this.btnModificarPues.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnModificarPues.Image = ((System.Drawing.Image)(resources.GetObject("btnModificarPues.Image")));
            this.btnModificarPues.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnModificarPues.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModificarPues.Name = "btnModificarPues";
            this.btnModificarPues.Size = new System.Drawing.Size(36, 37);
            this.btnModificarPues.Text = "Modificar";
            // 
            // btnLimpiarPues
            // 
            this.btnLimpiarPues.AutoSize = false;
            this.btnLimpiarPues.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLimpiarPues.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLimpiarPues.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiarPues.Image")));
            this.btnLimpiarPues.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnLimpiarPues.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLimpiarPues.Margin = new System.Windows.Forms.Padding(0);
            this.btnLimpiarPues.Name = "btnLimpiarPues";
            this.btnLimpiarPues.Size = new System.Drawing.Size(40, 40);
            this.btnLimpiarPues.Text = "Limpiar";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 40);
            // 
            // btnAtrasPue
            // 
            this.btnAtrasPue.AutoSize = false;
            this.btnAtrasPue.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAtrasPue.Image = ((System.Drawing.Image)(resources.GetObject("btnAtrasPue.Image")));
            this.btnAtrasPue.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAtrasPue.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAtrasPue.Name = "btnAtrasPue";
            this.btnAtrasPue.Size = new System.Drawing.Size(40, 40);
            this.btnAtrasPue.Text = "Atrás";
            this.btnAtrasPue.Click += new System.EventHandler(this.btnAtrasPue_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 40);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(61, 37);
            this.toolStripLabel2.Text = "Buscar:";
            // 
            // txtFiltrarPuesto
            // 
            this.txtFiltrarPuesto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiltrarPuesto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltrarPuesto.Name = "txtFiltrarPuesto";
            this.txtFiltrarPuesto.Size = new System.Drawing.Size(130, 40);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(33, 79);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(104, 21);
            this.label16.TabIndex = 91;
            this.label16.Text = "Descripción:";
            // 
            // txtDescripcionPuesto
            // 
            this.txtDescripcionPuesto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionPuesto.Location = new System.Drawing.Point(155, 77);
            this.txtDescripcionPuesto.Name = "txtDescripcionPuesto";
            this.txtDescripcionPuesto.Size = new System.Drawing.Size(153, 27);
            this.txtDescripcionPuesto.TabIndex = 90;
            // 
            // frm_Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(884, 431);
            this.Controls.Add(this.tbc_Empleados);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(900, 470);
            this.MinimumSize = new System.Drawing.Size(900, 470);
            this.Name = "frm_Empleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REGISTRO DE EMPLEADOS";
            this.Load += new System.EventHandler(this.frm_Registro_Empleados_Load);
            this.tbc_Empleados.ResumeLayout(false);
            this.tb_Empleado.ResumeLayout(false);
            this.tb_Empleado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.tlsBtnRegis_Guardar.ResumeLayout(false);
            this.tlsBtnRegis_Guardar.PerformLayout();
            this.tb_Mant_Empleados.ResumeLayout(false);
            this.tb_Mant_Empleados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbc_Empleados;
        private System.Windows.Forms.TabPage tb_Empleado;
        private System.Windows.Forms.TabPage tb_Mant_Empleados;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtApellido1;
        private System.Windows.Forms.TextBox txtApellido2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.ToolStrip tlsBtnRegis_Guardar;
        private System.Windows.Forms.ToolStripButton btnRegistrarEmp;
        private System.Windows.Forms.ToolStripButton btnEliminarEmp;
        private System.Windows.Forms.ToolStripButton btnModificarEmp;
        private System.Windows.Forms.ToolStripButton btnLimpiarEmp;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnAtrasEmp;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtFiltrarEmpleado;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.DateTimePicker dtp_FechaNacimineto;
        private System.Windows.Forms.ComboBox CbxPuesto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtp_FechaIngreso;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnRegistrarPues;
        private System.Windows.Forms.ToolStripButton btnEliminarPues;
        private System.Windows.Forms.ToolStripButton btnModificarPues;
        private System.Windows.Forms.ToolStripButton btnLimpiarPues;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnAtrasPue;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox txtFiltrarPuesto;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtDescripcionPuesto;
        private System.Windows.Forms.Label label12;


    }
}