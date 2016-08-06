namespace ProyectoProgra3.Ventas
{
    partial class frm_Ventas
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtIDUsuario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblHora = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbMetodoPago = new System.Windows.Forms.ComboBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gvVentas = new System.Windows.Forms.DataGridView();
            this.Int_Linea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Int_IdArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrch_Descripion_Articulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Int_IdServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrch_Descripion_Servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Int_Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mny_Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mny_Impuesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.int_Descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtEmpleado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cmbDevolucionCantidad = new System.Windows.Forms.ComboBox();
            this.txtDevolucionMonto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtDevolucionMotivo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDevolucionNombreUsuario = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDevolucionCodigoFactura = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvVentas)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1041, 570);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.tabPage1.Controls.Add(this.txtIDUsuario);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.txtTotal);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.txtSubTotal);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.lblHora);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.cbMetodoPago);
            this.tabPage1.Controls.Add(this.txtUsuario);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.gvVentas);
            this.tabPage1.Controls.Add(this.txtEmpleado);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtCodigo);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1033, 544);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cajero";
            // 
            // txtIDUsuario
            // 
            this.txtIDUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtIDUsuario.Location = new System.Drawing.Point(109, 431);
            this.txtIDUsuario.Name = "txtIDUsuario";
            this.txtIDUsuario.Size = new System.Drawing.Size(126, 20);
            this.txtIDUsuario.TabIndex = 18;
            this.txtIDUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDUsuario_KeyPress);
            this.txtIDUsuario.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp_1);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 434);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Codigo del Cliente";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(827, 490);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 20);
            this.label14.TabIndex = 13;
            this.label14.Text = "Total:";
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(910, 483);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(113, 27);
            this.txtTotal.TabIndex = 15;
            this.txtTotal.Text = "0";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(827, 425);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(72, 20);
            this.label16.TabIndex = 14;
            this.label16.Text = "Subtotal:";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSubTotal.Enabled = false;
            this.txtSubTotal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubTotal.Location = new System.Drawing.Point(910, 422);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(113, 27);
            this.txtSubTotal.TabIndex = 16;
            this.txtSubTotal.Text = "0";
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.Location = new System.Drawing.Point(534, 466);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Location = new System.Drawing.Point(376, 466);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Proceder Pago";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblHora
            // 
            this.lblHora.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(466, 21);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(30, 13);
            this.lblHora.TabIndex = 9;
            this.lblHora.Text = "Hora";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(595, 429);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Metodo de Pago";
            // 
            // cbMetodoPago
            // 
            this.cbMetodoPago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbMetodoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMetodoPago.FormattingEnabled = true;
            this.cbMetodoPago.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta Credito",
            "Tarjeta Debito"});
            this.cbMetodoPago.Location = new System.Drawing.Point(687, 426);
            this.cbMetodoPago.Name = "cbMetodoPago";
            this.cbMetodoPago.Size = new System.Drawing.Size(121, 21);
            this.cbMetodoPago.TabIndex = 1;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Location = new System.Drawing.Point(109, 468);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(126, 20);
            this.txtUsuario.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 471);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nombre del Cliente";
            // 
            // gvVentas
            // 
            this.gvVentas.AllowUserToAddRows = false;
            this.gvVentas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvVentas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.gvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Int_Linea,
            this.Int_IdArticulo,
            this.vrch_Descripion_Articulo,
            this.Int_IdServicio,
            this.vrch_Descripion_Servicio,
            this.Int_Cantidad,
            this.Mny_Monto,
            this.Mny_Impuesto,
            this.int_Descuento});
            this.gvVentas.Location = new System.Drawing.Point(1, 47);
            this.gvVentas.Name = "gvVentas";
            this.gvVentas.RowHeadersVisible = false;
            this.gvVentas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.gvVentas.Size = new System.Drawing.Size(1030, 368);
            this.gvVentas.TabIndex = 4;
            this.gvVentas.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvVentas_CellEndEdit);
            this.gvVentas.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.gvVentas_EditingControlShowing);
            this.gvVentas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gvVentas_KeyPress);
            // 
            // Int_Linea
            // 
            this.Int_Linea.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Int_Linea.HeaderText = "Int_Linea";
            this.Int_Linea.Name = "Int_Linea";
            this.Int_Linea.ReadOnly = true;
            // 
            // Int_IdArticulo
            // 
            this.Int_IdArticulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Int_IdArticulo.HeaderText = "Int_IdArticulo";
            this.Int_IdArticulo.Name = "Int_IdArticulo";
            this.Int_IdArticulo.ReadOnly = true;
            this.Int_IdArticulo.Visible = false;
            // 
            // vrch_Descripion_Articulo
            // 
            this.vrch_Descripion_Articulo.HeaderText = "vrch_Descripion_Articulo";
            this.vrch_Descripion_Articulo.Name = "vrch_Descripion_Articulo";
            this.vrch_Descripion_Articulo.ReadOnly = true;
            // 
            // Int_IdServicio
            // 
            this.Int_IdServicio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Int_IdServicio.HeaderText = "Int_IdServicio";
            this.Int_IdServicio.Name = "Int_IdServicio";
            this.Int_IdServicio.ReadOnly = true;
            this.Int_IdServicio.Visible = false;
            // 
            // vrch_Descripion_Servicio
            // 
            this.vrch_Descripion_Servicio.HeaderText = "vrch_Descripion_Servicio";
            this.vrch_Descripion_Servicio.Name = "vrch_Descripion_Servicio";
            this.vrch_Descripion_Servicio.ReadOnly = true;
            // 
            // Int_Cantidad
            // 
            this.Int_Cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Int_Cantidad.HeaderText = "Int_Cantidad";
            this.Int_Cantidad.Name = "Int_Cantidad";
            // 
            // Mny_Monto
            // 
            this.Mny_Monto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Mny_Monto.HeaderText = "Mny_Monto";
            this.Mny_Monto.Name = "Mny_Monto";
            this.Mny_Monto.ReadOnly = true;
            // 
            // Mny_Impuesto
            // 
            this.Mny_Impuesto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Mny_Impuesto.HeaderText = "Mny_Impuesto";
            this.Mny_Impuesto.Name = "Mny_Impuesto";
            // 
            // int_Descuento
            // 
            this.int_Descuento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.int_Descuento.HeaderText = "int_Descuento";
            this.int_Descuento.Name = "int_Descuento";
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmpleado.Enabled = false;
            this.txtEmpleado.Location = new System.Drawing.Point(925, 18);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Size = new System.Drawing.Size(100, 20);
            this.txtEmpleado.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(819, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre del Usuario";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(53, 21);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            this.txtCodigo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.tabPage2.Controls.Add(this.cmbDevolucionCantidad);
            this.tabPage2.Controls.Add(this.txtDevolucionMonto);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.txtDevolucionMotivo);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.txtDevolucionNombreUsuario);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txtDevolucionCodigoFactura);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1033, 544);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Devolucion";
            // 
            // cmbDevolucionCantidad
            // 
            this.cmbDevolucionCantidad.FormattingEnabled = true;
            this.cmbDevolucionCantidad.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.cmbDevolucionCantidad.Location = new System.Drawing.Point(134, 86);
            this.cmbDevolucionCantidad.Name = "cmbDevolucionCantidad";
            this.cmbDevolucionCantidad.Size = new System.Drawing.Size(100, 21);
            this.cmbDevolucionCantidad.TabIndex = 23;
            this.cmbDevolucionCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbDevolucionCantidad_KeyPress);
            // 
            // txtDevolucionMonto
            // 
            this.txtDevolucionMonto.Location = new System.Drawing.Point(134, 127);
            this.txtDevolucionMonto.Name = "txtDevolucionMonto";
            this.txtDevolucionMonto.Size = new System.Drawing.Size(100, 20);
            this.txtDevolucionMonto.TabIndex = 22;
            this.txtDevolucionMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDevolucionMonto_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Monto del Articulo";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 89);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "Cantidad";
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button4.Location = new System.Drawing.Point(529, 289);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(88, 46);
            this.button4.TabIndex = 18;
            this.button4.Text = "Cancelar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button3.Location = new System.Drawing.Point(396, 289);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 46);
            this.button3.TabIndex = 17;
            this.button3.Text = "Efectuar Proceso";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtDevolucionMotivo
            // 
            this.txtDevolucionMotivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDevolucionMotivo.Location = new System.Drawing.Point(716, 89);
            this.txtDevolucionMotivo.Multiline = true;
            this.txtDevolucionMotivo.Name = "txtDevolucionMotivo";
            this.txtDevolucionMotivo.Size = new System.Drawing.Size(268, 150);
            this.txtDevolucionMotivo.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(599, 162);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Motivo de Devolucion";
            // 
            // txtDevolucionNombreUsuario
            // 
            this.txtDevolucionNombreUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDevolucionNombreUsuario.Enabled = false;
            this.txtDevolucionNombreUsuario.Location = new System.Drawing.Point(884, 41);
            this.txtDevolucionNombreUsuario.Name = "txtDevolucionNombreUsuario";
            this.txtDevolucionNombreUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtDevolucionNombreUsuario.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(778, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Nombre del Usuario";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Codigo Detalle Factura";
            // 
            // txtDevolucionCodigoFactura
            // 
            this.txtDevolucionCodigoFactura.Location = new System.Drawing.Point(134, 45);
            this.txtDevolucionCodigoFactura.Name = "txtDevolucionCodigoFactura";
            this.txtDevolucionCodigoFactura.Size = new System.Drawing.Size(100, 20);
            this.txtDevolucionCodigoFactura.TabIndex = 0;
            this.txtDevolucionCodigoFactura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDevolucionCodigoFactura_KeyPress);
            this.txtDevolucionCodigoFactura.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDevolucionCodigoFactura_KeyUp);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frm_Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1041, 570);
            this.Controls.Add(this.tabControl1);
            this.Name = "frm_Ventas";
            this.Text = "Ventas";
            this.Activated += new System.EventHandler(this.frm_Ventas_Activated);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvVentas)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbMetodoPago;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView gvVentas;
        private System.Windows.Forms.TextBox txtEmpleado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtDevolucionMotivo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtDevolucionNombreUsuario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDevolucionCodigoFactura;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn int_Linea;
        private System.Windows.Forms.DataGridViewTextBoxColumn int_IdArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrch_Descripion_Articulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn int_IdServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrch_Descripion_Servicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn int_Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn mny_Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn mny_Impuesto;
        private System.Windows.Forms.DataGridViewTextBoxColumn int_Descuento;
        private System.Windows.Forms.TextBox txtIDUsuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Int_Linea;
        private System.Windows.Forms.DataGridViewTextBoxColumn Int_IdArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Int_IdServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Int_Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mny_Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mny_Impuesto;
        private System.Windows.Forms.TextBox txtDevolucionMonto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbDevolucionCantidad;
    }
}