namespace ProyectoProgra3.Devolucion
{
    partial class frm_Devolucion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Devolucion));
            this.cBoxFiltrar = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreEmpleado = new System.Windows.Forms.TextBox();
            this.tlsBtnRegis_Guardar = new System.Windows.Forms.ToolStrip();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.btnModificar = new System.Windows.Forms.ToolStripButton();
            this.tlsBtnRegis_Limpiar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtFiltrar = new System.Windows.Forms.ToolStripTextBox();
            this.gvDevolucion = new System.Windows.Forms.DataGridView();
            this.IdDevolucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdDetalleFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.int_Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mny_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrch_Detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlsBtnRegis_Guardar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDevolucion)).BeginInit();
            this.SuspendLayout();
            // 
            // cBoxFiltrar
            // 
            this.cBoxFiltrar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxFiltrar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxFiltrar.FormattingEnabled = true;
            this.cBoxFiltrar.Location = new System.Drawing.Point(316, 14);
            this.cBoxFiltrar.Name = "cBoxFiltrar";
            this.cBoxFiltrar.Size = new System.Drawing.Size(149, 28);
            this.cBoxFiltrar.TabIndex = 57;
            this.cBoxFiltrar.SelectedValueChanged += new System.EventHandler(this.cBoxFiltrar_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 387);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 21);
            this.label2.TabIndex = 55;
            this.label2.Text = "Nombre del Empleado";
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.Enabled = false;
            this.txtNombreEmpleado.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreEmpleado.Location = new System.Drawing.Point(200, 385);
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.ReadOnly = true;
            this.txtNombreEmpleado.Size = new System.Drawing.Size(194, 27);
            this.txtNombreEmpleado.TabIndex = 54;
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
            this.btnEliminar,
            this.btnModificar,
            this.tlsBtnRegis_Limpiar,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.txtFiltrar});
            this.tlsBtnRegis_Guardar.Location = new System.Drawing.Point(9, 9);
            this.tlsBtnRegis_Guardar.Name = "tlsBtnRegis_Guardar";
            this.tlsBtnRegis_Guardar.Size = new System.Drawing.Size(528, 40);
            this.tlsBtnRegis_Guardar.TabIndex = 52;
            this.tlsBtnRegis_Guardar.Text = "Registrar Empleado";
            // 
            // btnEliminar
            // 
            this.btnEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(29, 37);
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
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
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
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
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(61, 37);
            this.toolStripLabel1.Text = "Buscar:";
            // 
            // txtFiltrar
            // 
            this.txtFiltrar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiltrar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltrar.Name = "txtFiltrar";
            this.txtFiltrar.Size = new System.Drawing.Size(130, 40);
            this.txtFiltrar.TextChanged += new System.EventHandler(this.txtFiltrar_TextChanged);
            // 
            // gvDevolucion
            // 
            this.gvDevolucion.AllowUserToAddRows = false;
            this.gvDevolucion.AllowUserToDeleteRows = false;
            this.gvDevolucion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvDevolucion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDevolucion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdDevolucion,
            this.IdDetalleFactura,
            this.IdEmpleado,
            this.int_Cantidad,
            this.mny_Total,
            this.vrch_Detalle});
            this.gvDevolucion.Location = new System.Drawing.Point(9, 52);
            this.gvDevolucion.Name = "gvDevolucion";
            this.gvDevolucion.ReadOnly = true;
            this.gvDevolucion.RowHeadersVisible = false;
            this.gvDevolucion.Size = new System.Drawing.Size(530, 327);
            this.gvDevolucion.TabIndex = 51;
            this.gvDevolucion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvDevolucion_CellClick);
            // 
            // IdDevolucion
            // 
            this.IdDevolucion.HeaderText = "Devolucion";
            this.IdDevolucion.Name = "IdDevolucion";
            this.IdDevolucion.ReadOnly = true;
            // 
            // IdDetalleFactura
            // 
            this.IdDetalleFactura.HeaderText = "ID Detalle Factura";
            this.IdDetalleFactura.Name = "IdDetalleFactura";
            this.IdDetalleFactura.ReadOnly = true;
            // 
            // IdEmpleado
            // 
            this.IdEmpleado.HeaderText = "Empleado";
            this.IdEmpleado.Name = "IdEmpleado";
            this.IdEmpleado.ReadOnly = true;
            // 
            // int_Cantidad
            // 
            this.int_Cantidad.HeaderText = "Cantidad";
            this.int_Cantidad.Name = "int_Cantidad";
            this.int_Cantidad.ReadOnly = true;
            // 
            // mny_Total
            // 
            this.mny_Total.HeaderText = "Total";
            this.mny_Total.Name = "mny_Total";
            this.mny_Total.ReadOnly = true;
            // 
            // vrch_Detalle
            // 
            this.vrch_Detalle.HeaderText = "Detalle";
            this.vrch_Detalle.Name = "vrch_Detalle";
            this.vrch_Detalle.ReadOnly = true;
            // 
            // frm_Devolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(551, 417);
            this.Controls.Add(this.cBoxFiltrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombreEmpleado);
            this.Controls.Add(this.tlsBtnRegis_Guardar);
            this.Controls.Add(this.gvDevolucion);
            this.Name = "frm_Devolucion";
            this.Text = "Devolucion";
            this.tlsBtnRegis_Guardar.ResumeLayout(false);
            this.tlsBtnRegis_Guardar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDevolucion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cBoxFiltrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreEmpleado;
        private System.Windows.Forms.ToolStrip tlsBtnRegis_Guardar;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripButton btnModificar;
        private System.Windows.Forms.ToolStripButton tlsBtnRegis_Limpiar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtFiltrar;
        private System.Windows.Forms.DataGridView gvDevolucion;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDevolucion;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDetalleFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn int_Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn mny_Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrch_Detalle;
    }
}