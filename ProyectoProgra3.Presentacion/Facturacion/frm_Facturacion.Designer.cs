﻿namespace ProyectoProgra3.Facturacion
{
    partial class frm_Facturacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Facturacion));
            this.gvFactura = new System.Windows.Forms.DataGridView();
            this.IdFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gvDetalleFactura = new System.Windows.Forms.DataGridView();
            this.IdDetalleFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Linea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Impuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlsBtnRegis_Guardar = new System.Windows.Forms.ToolStrip();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.btnModificar = new System.Windows.Forms.ToolStripButton();
            this.tlsBtnRegis_Limpiar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtFiltrar = new System.Windows.Forms.ToolStripTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtNombreEmpleado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreServicio = new System.Windows.Forms.TextBox();
            this.txtNombreArticulo = new System.Windows.Forms.TextBox();
            this.cBoxFiltrar = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDetalleFactura)).BeginInit();
            this.tlsBtnRegis_Guardar.SuspendLayout();
            this.SuspendLayout();
            // 
            // gvFactura
            // 
            this.gvFactura.AllowUserToAddRows = false;
            this.gvFactura.AllowUserToDeleteRows = false;
            this.gvFactura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdFactura,
            this.IdEmpleado,
            this.IdCliente,
            this.Fecha,
            this.Total1});
            this.gvFactura.Location = new System.Drawing.Point(12, 56);
            this.gvFactura.Name = "gvFactura";
            this.gvFactura.ReadOnly = true;
            this.gvFactura.RowHeadersVisible = false;
            this.gvFactura.Size = new System.Drawing.Size(528, 231);
            this.gvFactura.TabIndex = 5;
            this.gvFactura.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvFactura_CellClick);
            // 
            // IdFactura
            // 
            this.IdFactura.HeaderText = "Factura";
            this.IdFactura.Name = "IdFactura";
            this.IdFactura.ReadOnly = true;
            // 
            // IdEmpleado
            // 
            this.IdEmpleado.HeaderText = "Empleado";
            this.IdEmpleado.Name = "IdEmpleado";
            this.IdEmpleado.ReadOnly = true;
            // 
            // IdCliente
            // 
            this.IdCliente.HeaderText = "Cliente";
            this.IdCliente.Name = "IdCliente";
            this.IdCliente.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Total1
            // 
            this.Total1.HeaderText = "Total";
            this.Total1.Name = "Total1";
            this.Total1.ReadOnly = true;
            // 
            // gvDetalleFactura
            // 
            this.gvDetalleFactura.AllowUserToAddRows = false;
            this.gvDetalleFactura.AllowUserToDeleteRows = false;
            this.gvDetalleFactura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvDetalleFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDetalleFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdDetalleFactura,
            this.Linea,
            this.IdArticulo,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn4,
            this.Impuesto,
            this.dataGridViewTextBoxColumn7});
            this.gvDetalleFactura.Location = new System.Drawing.Point(539, 286);
            this.gvDetalleFactura.Name = "gvDetalleFactura";
            this.gvDetalleFactura.ReadOnly = true;
            this.gvDetalleFactura.RowHeadersVisible = false;
            this.gvDetalleFactura.Size = new System.Drawing.Size(583, 277);
            this.gvDetalleFactura.TabIndex = 6;
            this.gvDetalleFactura.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvDetalleFactura_CellClick);
            // 
            // IdDetalleFactura
            // 
            this.IdDetalleFactura.HeaderText = "ID";
            this.IdDetalleFactura.Name = "IdDetalleFactura";
            this.IdDetalleFactura.ReadOnly = true;
            // 
            // Linea
            // 
            this.Linea.HeaderText = "Linea";
            this.Linea.Name = "Linea";
            this.Linea.ReadOnly = true;
            // 
            // IdArticulo
            // 
            this.IdArticulo.HeaderText = "IdArticulo";
            this.IdArticulo.Name = "IdArticulo";
            this.IdArticulo.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "IdServicio";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // Impuesto
            // 
            this.Impuesto.HeaderText = "Impuesto";
            this.Impuesto.Name = "Impuesto";
            this.Impuesto.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Descuento";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
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
            this.tlsBtnRegis_Guardar.Location = new System.Drawing.Point(12, 13);
            this.tlsBtnRegis_Guardar.Name = "tlsBtnRegis_Guardar";
            this.tlsBtnRegis_Guardar.Size = new System.Drawing.Size(528, 40);
            this.tlsBtnRegis_Guardar.TabIndex = 41;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(575, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 21);
            this.label1.TabIndex = 42;
            this.label1.Text = "Nombre del Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(575, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 21);
            this.label2.TabIndex = 44;
            this.label2.Text = "Nombre del Empleado";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Enabled = false;
            this.txtNombreCliente.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCliente.Location = new System.Drawing.Point(763, 103);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(194, 27);
            this.txtNombreCliente.TabIndex = 45;
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.Enabled = false;
            this.txtNombreEmpleado.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreEmpleado.Location = new System.Drawing.Point(763, 54);
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.Size = new System.Drawing.Size(194, 27);
            this.txtNombreEmpleado.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 21);
            this.label3.TabIndex = 46;
            this.label3.Text = "Nombre del Servicio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 21);
            this.label4.TabIndex = 48;
            this.label4.Text = "Nombre del Articulo(Codigo)";
            // 
            // txtNombreServicio
            // 
            this.txtNombreServicio.Enabled = false;
            this.txtNombreServicio.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreServicio.Location = new System.Drawing.Point(248, 351);
            this.txtNombreServicio.Name = "txtNombreServicio";
            this.txtNombreServicio.Size = new System.Drawing.Size(194, 27);
            this.txtNombreServicio.TabIndex = 49;
            // 
            // txtNombreArticulo
            // 
            this.txtNombreArticulo.Enabled = false;
            this.txtNombreArticulo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreArticulo.Location = new System.Drawing.Point(248, 302);
            this.txtNombreArticulo.Name = "txtNombreArticulo";
            this.txtNombreArticulo.Size = new System.Drawing.Size(194, 27);
            this.txtNombreArticulo.TabIndex = 47;
            // 
            // cBoxFiltrar
            // 
            this.cBoxFiltrar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxFiltrar.FormattingEnabled = true;
            this.cBoxFiltrar.Location = new System.Drawing.Point(319, 18);
            this.cBoxFiltrar.Name = "cBoxFiltrar";
            this.cBoxFiltrar.Size = new System.Drawing.Size(149, 28);
            this.cBoxFiltrar.TabIndex = 50;
            // 
            // frm_Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1134, 575);
            this.Controls.Add(this.cBoxFiltrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNombreServicio);
            this.Controls.Add(this.txtNombreArticulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.txtNombreEmpleado);
            this.Controls.Add(this.tlsBtnRegis_Guardar);
            this.Controls.Add(this.gvDetalleFactura);
            this.Controls.Add(this.gvFactura);
            this.Name = "frm_Facturacion";
            this.Text = "frm_Facturacion";
            ((System.ComponentModel.ISupportInitialize)(this.gvFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDetalleFactura)).EndInit();
            this.tlsBtnRegis_Guardar.ResumeLayout(false);
            this.tlsBtnRegis_Guardar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridView gvDetalleFactura;
        private System.Windows.Forms.ToolStrip tlsBtnRegis_Guardar;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripButton btnModificar;
        private System.Windows.Forms.ToolStripButton tlsBtnRegis_Limpiar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtFiltrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtNombreEmpleado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombreServicio;
        private System.Windows.Forms.TextBox txtNombreArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDetalleFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Linea;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Impuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.ComboBox cBoxFiltrar;
    }
}