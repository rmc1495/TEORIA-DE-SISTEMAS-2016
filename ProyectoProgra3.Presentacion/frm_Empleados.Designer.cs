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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.cBoxEstado = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cBoxDepartamento = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cBoxTipoEmpleado = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tlsBtnRegis_Guardar = new System.Windows.Forms.ToolStrip();
            this.btnRegistrarEmp = new System.Windows.Forms.ToolStripButton();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.btnModificar = new System.Windows.Forms.ToolStripButton();
            this.tlsBtnRegis_Limpiar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tlsBtnRegis_Atras = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cBoxFiltrar = new System.Windows.Forms.ToolStripComboBox();
            this.txtFiltrar = new System.Windows.Forms.ToolStripTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTele = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtIdempleado = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.tlsBtnRegis_Guardar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dgvEmpleados);
            this.panel1.Controls.Add(this.txtCedula);
            this.panel1.Controls.Add(this.cBoxEstado);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.cBoxDepartamento);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.cBoxTipoEmpleado);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.tlsBtnRegis_Guardar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtTele);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtDireccion);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtEdad);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtApellidos);
            this.panel1.Controls.Add(this.txtIdempleado);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 487);
            this.panel1.TabIndex = 12;
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.AllowUserToAddRows = false;
            this.dgvEmpleados.AllowUserToDeleteRows = false;
            this.dgvEmpleados.AllowUserToOrderColumns = true;
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Location = new System.Drawing.Point(5, 333);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.ReadOnly = true;
            this.dgvEmpleados.Size = new System.Drawing.Size(848, 147);
            this.dgvEmpleados.TabIndex = 44;
            this.dgvEmpleados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpleados_CellClick);
            // 
            // txtCedula
            // 
            this.txtCedula.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedula.Location = new System.Drawing.Point(468, 80);
            this.txtCedula.MaxLength = 9;
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(104, 27);
            this.txtCedula.TabIndex = 30;
            this.txtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidarNumeros);
            // 
            // cBoxEstado
            // 
            this.cBoxEstado.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxEstado.FormattingEnabled = true;
            this.cBoxEstado.Location = new System.Drawing.Point(549, 230);
            this.cBoxEstado.Name = "cBoxEstado";
            this.cBoxEstado.Size = new System.Drawing.Size(149, 28);
            this.cBoxEstado.TabIndex = 39;
            this.cBoxEstado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidarComboBox);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(453, 232);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 21);
            this.label10.TabIndex = 43;
            this.label10.Text = "Estado:";
            // 
            // cBoxDepartamento
            // 
            this.cBoxDepartamento.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxDepartamento.FormattingEnabled = true;
            this.cBoxDepartamento.Location = new System.Drawing.Point(269, 230);
            this.cBoxDepartamento.Name = "cBoxDepartamento";
            this.cBoxDepartamento.Size = new System.Drawing.Size(149, 28);
            this.cBoxDepartamento.TabIndex = 38;
            this.cBoxDepartamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidarComboBox);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(138, 232);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 21);
            this.label9.TabIndex = 42;
            this.label9.Text = "Departamento:";
            // 
            // cBoxTipoEmpleado
            // 
            this.cBoxTipoEmpleado.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxTipoEmpleado.FormattingEnabled = true;
            this.cBoxTipoEmpleado.Location = new System.Drawing.Point(549, 179);
            this.cBoxTipoEmpleado.Name = "cBoxTipoEmpleado";
            this.cBoxTipoEmpleado.Size = new System.Drawing.Size(149, 28);
            this.cBoxTipoEmpleado.TabIndex = 37;
            this.cBoxTipoEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidarComboBox);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(391, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 21);
            this.label8.TabIndex = 41;
            this.label8.Text = "Tipo de Empleado:";
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
            this.btnEliminar,
            this.btnModificar,
            this.tlsBtnRegis_Limpiar,
            this.toolStripSeparator1,
            this.tlsBtnRegis_Atras,
            this.toolStripSeparator2,
            this.toolStripLabel1,
            this.cBoxFiltrar,
            this.txtFiltrar});
            this.tlsBtnRegis_Guardar.Location = new System.Drawing.Point(5, 290);
            this.tlsBtnRegis_Guardar.Name = "tlsBtnRegis_Guardar";
            this.tlsBtnRegis_Guardar.Size = new System.Drawing.Size(848, 40);
            this.tlsBtnRegis_Guardar.TabIndex = 40;
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
            this.btnRegistrarEmp.Click += new System.EventHandler(this.btnRegistrarEmp_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(29, 37);
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.tlsBtn_Consul_Eliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(36, 37);
            this.btnModificar.Text = "Modificar";
            this.btnModificar.Click += new System.EventHandler(this.tlsBtn_Consul_Modificar_Click);
            // 
            // tlsBtnRegis_Limpiar
            // 
            this.tlsBtnRegis_Limpiar.AutoSize = false;
            this.tlsBtnRegis_Limpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tlsBtnRegis_Limpiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsBtnRegis_Limpiar.Image = ((System.Drawing.Image)(resources.GetObject("tlsBtnRegis_Limpiar.Image")));
            this.tlsBtnRegis_Limpiar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tlsBtnRegis_Limpiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsBtnRegis_Limpiar.Margin = new System.Windows.Forms.Padding(0);
            this.tlsBtnRegis_Limpiar.Name = "tlsBtnRegis_Limpiar";
            this.tlsBtnRegis_Limpiar.Size = new System.Drawing.Size(40, 40);
            this.tlsBtnRegis_Limpiar.Text = "Limpiar";
            this.tlsBtnRegis_Limpiar.Click += new System.EventHandler(this.tlsBtnRegis_Limpiar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 40);
            // 
            // tlsBtnRegis_Atras
            // 
            this.tlsBtnRegis_Atras.AutoSize = false;
            this.tlsBtnRegis_Atras.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsBtnRegis_Atras.Image = ((System.Drawing.Image)(resources.GetObject("tlsBtnRegis_Atras.Image")));
            this.tlsBtnRegis_Atras.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tlsBtnRegis_Atras.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsBtnRegis_Atras.Name = "tlsBtnRegis_Atras";
            this.tlsBtnRegis_Atras.Size = new System.Drawing.Size(40, 40);
            this.tlsBtnRegis_Atras.Text = "Atrás";
            this.tlsBtnRegis_Atras.Click += new System.EventHandler(this.tlsBtnRegis_Atras_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 40);
            // 
            // cBoxFiltrar
            // 
            this.cBoxFiltrar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxFiltrar.Items.AddRange(new object[] {
            "IdEmpleado",
            "Cedula",
            "Nombre",
            "Apellidos\t\t",
            "Direccion",
            "Edad",
            "Telefono1\t\t\t",
            "IdTipoEmpleado",
            "IdDepartamento",
            "IdEstado"});
            this.cBoxFiltrar.Name = "cBoxFiltrar";
            this.cBoxFiltrar.Size = new System.Drawing.Size(121, 40);
            this.cBoxFiltrar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidarComboBox);
            // 
            // txtFiltrar
            // 
            this.txtFiltrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiltrar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltrar.Name = "txtFiltrar";
            this.txtFiltrar.Size = new System.Drawing.Size(130, 40);
            this.txtFiltrar.TextChanged += new System.EventHandler(this.txtFiltrar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 21);
            this.label1.TabIndex = 23;
            this.label1.Text = "ID Empleado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(138, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 21);
            this.label2.TabIndex = 25;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(375, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 21);
            this.label3.TabIndex = 28;
            this.label3.Text = "Cedula:";
            // 
            // txtTele
            // 
            this.txtTele.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTele.Location = new System.Drawing.Point(260, 179);
            this.txtTele.MaxLength = 8;
            this.txtTele.Name = "txtTele";
            this.txtTele.Size = new System.Drawing.Size(100, 27);
            this.txtTele.TabIndex = 36;
            this.txtTele.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidarNumeros);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(375, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 21);
            this.label4.TabIndex = 29;
            this.label4.Text = "Apellidos:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(259, 129);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(472, 27);
            this.txtDireccion.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(138, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 21);
            this.label5.TabIndex = 32;
            this.label5.Text = "Dirección:";
            // 
            // txtEdad
            // 
            this.txtEdad.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdad.Location = new System.Drawing.Point(631, 80);
            this.txtEdad.MaxLength = 3;
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(100, 27);
            this.txtEdad.TabIndex = 31;
            this.txtEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidarNumeros);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(578, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 21);
            this.label6.TabIndex = 33;
            this.label6.Text = "Edad:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(138, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 21);
            this.label7.TabIndex = 35;
            this.label7.Text = "Telefono:";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidos.Location = new System.Drawing.Point(468, 31);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(264, 27);
            this.txtApellidos.TabIndex = 26;
            this.txtApellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidacionCaracteres);
            // 
            // txtIdempleado
            // 
            this.txtIdempleado.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdempleado.Location = new System.Drawing.Point(260, 80);
            this.txtIdempleado.Name = "txtIdempleado";
            this.txtIdempleado.Size = new System.Drawing.Size(100, 27);
            this.txtIdempleado.TabIndex = 27;
            this.txtIdempleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidarEspeciales);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(260, 31);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 27);
            this.txtNombre.TabIndex = 24;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidacionCaracteres);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(61, 37);
            this.toolStripLabel1.Text = "Buscar:";
            // 
            // frm_Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 550);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(900, 550);
            this.Name = "frm_Empleados";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REGISTRO DE EMPLEADOS";
            this.Load += new System.EventHandler(this.frm_Registro_Empleados_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.tlsBtnRegis_Guardar.ResumeLayout(false);
            this.tlsBtnRegis_Guardar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.ComboBox cBoxEstado;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cBoxDepartamento;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cBoxTipoEmpleado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStrip tlsBtnRegis_Guardar;
        private System.Windows.Forms.ToolStripButton btnRegistrarEmp;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripButton btnModificar;
        private System.Windows.Forms.ToolStripButton tlsBtnRegis_Limpiar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tlsBtnRegis_Atras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTele;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtIdempleado;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripComboBox cBoxFiltrar;
        private System.Windows.Forms.ToolStripTextBox txtFiltrar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;

    }
}