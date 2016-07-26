namespace ProyectoProgra3.Mantenimineto.Inventario_y_Proveedores
{
    partial class frm_Marcas
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAgregarMarca = new System.Windows.Forms.Button();
            this.lblIDCliente = new System.Windows.Forms.Label();
            this.txtNombreMarca = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btmBuscarEspecifico = new System.Windows.Forms.Button();
            this.btnTodos = new System.Windows.Forms.Button();
            this.dgvtodos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dgvMarca = new System.Windows.Forms.DataGridView();
            this.dB_TSistemasDataSet = new ProyectoProgra3.DB_TSistemasDataSet();
            this.spConsultarMarcaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_ConsultarMarcaTableAdapter = new ProyectoProgra3.DB_TSistemasDataSetTableAdapters.sp_ConsultarMarcaTableAdapter();
            this.intIdMarcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrchMarcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtodos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_TSistemasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spConsultarMarcaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dgvMarca);
            this.panel1.Controls.Add(this.btnAgregarMarca);
            this.panel1.Controls.Add(this.lblIDCliente);
            this.panel1.Controls.Add(this.txtNombreMarca);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(24, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(597, 185);
            this.panel1.TabIndex = 15;
            // 
            // btnAgregarMarca
            // 
            this.btnAgregarMarca.Location = new System.Drawing.Point(108, 107);
            this.btnAgregarMarca.Name = "btnAgregarMarca";
            this.btnAgregarMarca.Size = new System.Drawing.Size(91, 29);
            this.btnAgregarMarca.TabIndex = 1;
            this.btnAgregarMarca.Text = "Agregar";
            this.btnAgregarMarca.UseVisualStyleBackColor = true;
            this.btnAgregarMarca.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblIDCliente
            // 
            this.lblIDCliente.AutoSize = true;
            this.lblIDCliente.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDCliente.Location = new System.Drawing.Point(41, 39);
            this.lblIDCliente.Name = "lblIDCliente";
            this.lblIDCliente.Size = new System.Drawing.Size(71, 20);
            this.lblIDCliente.TabIndex = 0;
            this.lblIDCliente.Text = "Nombre:";
            // 
            // txtNombreMarca
            // 
            this.txtNombreMarca.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreMarca.Location = new System.Drawing.Point(139, 36);
            this.txtNombreMarca.Name = "txtNombreMarca";
            this.txtNombreMarca.Size = new System.Drawing.Size(124, 27);
            this.txtNombreMarca.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(632, 271);
            this.tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(624, 245);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Agregar Marca";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(624, 245);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Buscar Marca";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btmBuscarEspecifico);
            this.panel2.Controls.Add(this.btnTodos);
            this.panel2.Controls.Add(this.dgvtodos);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(15, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(607, 229);
            this.panel2.TabIndex = 16;
            // 
            // btmBuscarEspecifico
            // 
            this.btmBuscarEspecifico.Location = new System.Drawing.Point(27, 96);
            this.btmBuscarEspecifico.Name = "btmBuscarEspecifico";
            this.btmBuscarEspecifico.Size = new System.Drawing.Size(175, 31);
            this.btmBuscarEspecifico.TabIndex = 50;
            this.btmBuscarEspecifico.Text = "Buscar";
            this.btmBuscarEspecifico.UseVisualStyleBackColor = true;
            // 
            // btnTodos
            // 
            this.btnTodos.Location = new System.Drawing.Point(347, 13);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(175, 36);
            this.btnTodos.TabIndex = 49;
            this.btnTodos.Text = "Buscar Todos";
            this.btnTodos.UseVisualStyleBackColor = true;
            this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
            // 
            // dgvtodos
            // 
            this.dgvtodos.AllowUserToAddRows = false;
            this.dgvtodos.AllowUserToDeleteRows = false;
            this.dgvtodos.AllowUserToOrderColumns = true;
            this.dgvtodos.AutoGenerateColumns = false;
            this.dgvtodos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvtodos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvtodos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtodos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.intIdMarcaDataGridViewTextBoxColumn,
            this.vrchMarcaDataGridViewTextBoxColumn});
            this.dgvtodos.DataSource = this.spConsultarMarcaBindingSource;
            this.dgvtodos.Enabled = false;
            this.dgvtodos.Location = new System.Drawing.Point(265, 55);
            this.dgvtodos.Name = "dgvtodos";
            this.dgvtodos.ReadOnly = true;
            this.dgvtodos.Size = new System.Drawing.Size(330, 132);
            this.dgvtodos.TabIndex = 48;
            this.dgvtodos.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(100, 39);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(124, 27);
            this.textBox2.TabIndex = 0;
            // 
            // dgvMarca
            // 
            this.dgvMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarca.Location = new System.Drawing.Point(291, 19);
            this.dgvMarca.Name = "dgvMarca";
            this.dgvMarca.Size = new System.Drawing.Size(302, 150);
            this.dgvMarca.TabIndex = 16;
            // 
            // dB_TSistemasDataSet
            // 
            this.dB_TSistemasDataSet.DataSetName = "DB_TSistemasDataSet";
            this.dB_TSistemasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spConsultarMarcaBindingSource
            // 
            this.spConsultarMarcaBindingSource.DataMember = "sp_ConsultarMarca";
            this.spConsultarMarcaBindingSource.DataSource = this.dB_TSistemasDataSet;
            // 
            // sp_ConsultarMarcaTableAdapter
            // 
            this.sp_ConsultarMarcaTableAdapter.ClearBeforeFill = true;
            // 
            // intIdMarcaDataGridViewTextBoxColumn
            // 
            this.intIdMarcaDataGridViewTextBoxColumn.DataPropertyName = "int_IdMarca";
            this.intIdMarcaDataGridViewTextBoxColumn.HeaderText = "ID Marca";
            this.intIdMarcaDataGridViewTextBoxColumn.Name = "intIdMarcaDataGridViewTextBoxColumn";
            this.intIdMarcaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vrchMarcaDataGridViewTextBoxColumn
            // 
            this.vrchMarcaDataGridViewTextBoxColumn.DataPropertyName = "vrch_Marca";
            this.vrchMarcaDataGridViewTextBoxColumn.HeaderText = "Marca";
            this.vrchMarcaDataGridViewTextBoxColumn.Name = "vrchMarcaDataGridViewTextBoxColumn";
            this.vrchMarcaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frm_Marcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 295);
            this.Controls.Add(this.tabControl1);
            this.Name = "frm_Marcas";
            this.Text = "frm_Marcas";
            this.Load += new System.EventHandler(this.frm_Marcas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtodos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_TSistemasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spConsultarMarcaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblIDCliente;
        private System.Windows.Forms.TextBox txtNombreMarca;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvtodos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnAgregarMarca;
        private System.Windows.Forms.Button btnTodos;
        private System.Windows.Forms.Button btmBuscarEspecifico;
        private System.Windows.Forms.DataGridView dgvMarca;
        private DB_TSistemasDataSet dB_TSistemasDataSet;
        private System.Windows.Forms.BindingSource spConsultarMarcaBindingSource;
        private DB_TSistemasDataSetTableAdapters.sp_ConsultarMarcaTableAdapter sp_ConsultarMarcaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn intIdMarcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrchMarcaDataGridViewTextBoxColumn;
    }
}