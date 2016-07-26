namespace ProyectoProgra3.Inventario_y_Proveedor
{
    partial class frm_Producto
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Producto));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpVencimientoProducto = new System.Windows.Forms.DateTimePicker();
            this.cmbProveedorProducto = new System.Windows.Forms.ComboBox();
            this.spConsultarMarcaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_TSistemasDataSet = new ProyectoProgra3.DB_TSistemasDataSet();
            this.spConsultarProveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBTSistemasDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbMarcaProducto = new System.Windows.Forms.ComboBox();
            this.txtPorcentajeProducto = new System.Windows.Forms.TextBox();
            this.txtCantidadProducto = new System.Windows.Forms.TextBox();
            this.txtPrecioProducto = new System.Windows.Forms.TextBox();
            this.txtDescripcionProducto = new System.Windows.Forms.TextBox();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnRegistrarProducto = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.sp_ConsultarMarcaTableAdapter = new ProyectoProgra3.DB_TSistemasDataSetTableAdapters.sp_ConsultarMarcaTableAdapter();
            this.sp_ConsultarProveedorTableAdapter = new ProyectoProgra3.DB_TSistemasDataSetTableAdapters.sp_ConsultarProveedorTableAdapter();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spConsultarMarcaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_TSistemasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spConsultarProveedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTSistemasDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dtpVencimientoProducto);
            this.panel1.Controls.Add(this.cmbProveedorProducto);
            this.panel1.Controls.Add(this.cmbMarcaProducto);
            this.panel1.Controls.Add(this.txtPorcentajeProducto);
            this.panel1.Controls.Add(this.txtCantidadProducto);
            this.panel1.Controls.Add(this.txtPrecioProducto);
            this.panel1.Controls.Add(this.txtDescripcionProducto);
            this.panel1.Controls.Add(this.dgvProductos);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 487);
            this.panel1.TabIndex = 3;
            // 
            // dtpVencimientoProducto
            // 
            this.dtpVencimientoProducto.Location = new System.Drawing.Point(421, 182);
            this.dtpVencimientoProducto.Name = "dtpVencimientoProducto";
            this.dtpVencimientoProducto.Size = new System.Drawing.Size(200, 27);
            this.dtpVencimientoProducto.TabIndex = 55;
            // 
            // cmbProveedorProducto
            // 
            this.cmbProveedorProducto.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.spConsultarMarcaBindingSource, "int_IdMarca", true));
            this.cmbProveedorProducto.DataSource = this.spConsultarProveedorBindingSource;
            this.cmbProveedorProducto.DisplayMember = "vrch_Nombre";
            this.cmbProveedorProducto.FormattingEnabled = true;
            this.cmbProveedorProducto.Location = new System.Drawing.Point(406, 20);
            this.cmbProveedorProducto.Name = "cmbProveedorProducto";
            this.cmbProveedorProducto.Size = new System.Drawing.Size(121, 28);
            this.cmbProveedorProducto.TabIndex = 54;
            this.cmbProveedorProducto.ValueMember = "int_IdProveedor";
            // 
            // spConsultarMarcaBindingSource
            // 
            this.spConsultarMarcaBindingSource.DataMember = "sp_ConsultarMarca";
            this.spConsultarMarcaBindingSource.DataSource = this.dB_TSistemasDataSet;
            // 
            // dB_TSistemasDataSet
            // 
            this.dB_TSistemasDataSet.DataSetName = "DB_TSistemasDataSet";
            this.dB_TSistemasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spConsultarProveedorBindingSource
            // 
            this.spConsultarProveedorBindingSource.DataMember = "sp_ConsultarProveedor";
            this.spConsultarProveedorBindingSource.DataSource = this.dBTSistemasDataSetBindingSource;
            // 
            // dBTSistemasDataSetBindingSource
            // 
            this.dBTSistemasDataSetBindingSource.DataSource = this.dB_TSistemasDataSet;
            this.dBTSistemasDataSetBindingSource.Position = 0;
            // 
            // cmbMarcaProducto
            // 
            this.cmbMarcaProducto.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.spConsultarMarcaBindingSource, "int_IdMarca", true));
            this.cmbMarcaProducto.DataSource = this.spConsultarMarcaBindingSource;
            this.cmbMarcaProducto.DisplayMember = "vrch_Marca";
            this.cmbMarcaProducto.FormattingEnabled = true;
            this.cmbMarcaProducto.Location = new System.Drawing.Point(406, 72);
            this.cmbMarcaProducto.Name = "cmbMarcaProducto";
            this.cmbMarcaProducto.Size = new System.Drawing.Size(121, 28);
            this.cmbMarcaProducto.TabIndex = 53;
            this.cmbMarcaProducto.ValueMember = "int_IdMarca";
            // 
            // txtPorcentajeProducto
            // 
            this.txtPorcentajeProducto.Location = new System.Drawing.Point(495, 131);
            this.txtPorcentajeProducto.Name = "txtPorcentajeProducto";
            this.txtPorcentajeProducto.Size = new System.Drawing.Size(100, 27);
            this.txtPorcentajeProducto.TabIndex = 52;
            // 
            // txtCantidadProducto
            // 
            this.txtCantidadProducto.Location = new System.Drawing.Point(118, 131);
            this.txtCantidadProducto.Name = "txtCantidadProducto";
            this.txtCantidadProducto.Size = new System.Drawing.Size(100, 27);
            this.txtCantidadProducto.TabIndex = 51;
            // 
            // txtPrecioProducto
            // 
            this.txtPrecioProducto.Location = new System.Drawing.Point(118, 80);
            this.txtPrecioProducto.Name = "txtPrecioProducto";
            this.txtPrecioProducto.Size = new System.Drawing.Size(100, 27);
            this.txtPrecioProducto.TabIndex = 50;
            // 
            // txtDescripcionProducto
            // 
            this.txtDescripcionProducto.Location = new System.Drawing.Point(118, 27);
            this.txtDescripcionProducto.Name = "txtDescripcionProducto";
            this.txtDescripcionProducto.Size = new System.Drawing.Size(100, 27);
            this.txtDescripcionProducto.TabIndex = 49;
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.AllowUserToOrderColumns = true;
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(5, 286);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.Size = new System.Drawing.Size(848, 147);
            this.dgvProductos.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(312, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marca:";
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
            this.btnRegistrarProducto,
            this.toolStripSeparator2,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.toolStripSeparator3});
            this.toolStrip1.Location = new System.Drawing.Point(5, 233);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(848, 40);
            this.toolStrip1.TabIndex = 47;
            this.toolStrip1.Text = "Registrar Empleado";
            // 
            // btnRegistrarProducto
            // 
            this.btnRegistrarProducto.AutoSize = false;
            this.btnRegistrarProducto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRegistrarProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrarProducto.Image")));
            this.btnRegistrarProducto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRegistrarProducto.Name = "btnRegistrarProducto";
            this.btnRegistrarProducto.Size = new System.Drawing.Size(40, 40);
            this.btnRegistrarProducto.Text = "Registrar ";
            this.btnRegistrarProducto.Click += new System.EventHandler(this.btnRegistrarProducto_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 40);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 40);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 40);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cantidad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Precio:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 20);
            this.label8.TabIndex = 31;
            this.label8.Text = "Descripcion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(314, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Proveedor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(314, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Vencimiento:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(312, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Porcentaje de Ganancia:";
            // 
            // sp_ConsultarMarcaTableAdapter
            // 
            this.sp_ConsultarMarcaTableAdapter.ClearBeforeFill = true;
            // 
            // sp_ConsultarProveedorTableAdapter
            // 
            this.sp_ConsultarProveedorTableAdapter.ClearBeforeFill = true;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.Image = global::ProyectoProgra3.Properties.Resources.search_icon;
            this.toolStripLabel1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(29, 37);
            this.toolStripLabel1.Text = "Buscar:";
            // 
            // frm_Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 452);
            this.Controls.Add(this.panel1);
            this.Name = "frm_Producto";
            this.Text = "frm_Producto";
            this.Load += new System.EventHandler(this.frm_Producto_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spConsultarMarcaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_TSistemasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spConsultarProveedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTSistemasDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnRegistrarProducto;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpVencimientoProducto;
        private System.Windows.Forms.ComboBox cmbProveedorProducto;
        private System.Windows.Forms.ComboBox cmbMarcaProducto;
        private System.Windows.Forms.TextBox txtPorcentajeProducto;
        private System.Windows.Forms.TextBox txtCantidadProducto;
        private System.Windows.Forms.TextBox txtPrecioProducto;
        private System.Windows.Forms.TextBox txtDescripcionProducto;
        private DB_TSistemasDataSet dB_TSistemasDataSet;
        private System.Windows.Forms.BindingSource spConsultarMarcaBindingSource;
        private DB_TSistemasDataSetTableAdapters.sp_ConsultarMarcaTableAdapter sp_ConsultarMarcaTableAdapter;
        private System.Windows.Forms.BindingSource dBTSistemasDataSetBindingSource;
        private System.Windows.Forms.BindingSource spConsultarProveedorBindingSource;
        private DB_TSistemasDataSetTableAdapters.sp_ConsultarProveedorTableAdapter sp_ConsultarProveedorTableAdapter;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ToolStripButton toolStripLabel1;
    }
}