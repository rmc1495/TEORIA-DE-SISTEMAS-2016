namespace ProyectoProgra3
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btn_Inicio = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsLogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_RRHH = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsGestionEmp = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Ventas = new System.Windows.Forms.ToolStripMenuItem();
            this.venderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarCajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Inventario = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsGestionProd = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Mantenimientos = new System.Windows.Forms.ToolStripMenuItem();
            this.tlsRRHH = new System.Windows.Forms.ToolStripMenuItem();
            this.seguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hacerloEnTablasCatalogoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expedientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeExpedientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblBienvenidos = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Inicio,
            this.btn_RRHH,
            this.btn_Ventas,
            this.btn_Inventario,
            this.btn_Mantenimientos,
            this.expedientesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1354, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btn_Inicio
            // 
            this.btn_Inicio.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsLogOut,
            this.tlsSalir});
            this.btn_Inicio.Name = "btn_Inicio";
            this.btn_Inicio.Size = new System.Drawing.Size(59, 24);
            this.btn_Inicio.Text = "Inicio";
            // 
            // tlsLogOut
            // 
            this.tlsLogOut.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tlsLogOut.Image = global::ProyectoProgra3.Properties.Resources.candados;
            this.tlsLogOut.Name = "tlsLogOut";
            this.tlsLogOut.Size = new System.Drawing.Size(134, 24);
            this.tlsLogOut.Text = "Log Out";
            this.tlsLogOut.Click += new System.EventHandler(this.tlsLogOut_Click);
            // 
            // tlsSalir
            // 
            this.tlsSalir.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tlsSalir.Image = global::ProyectoProgra3.Properties.Resources.Exit;
            this.tlsSalir.Name = "tlsSalir";
            this.tlsSalir.Size = new System.Drawing.Size(134, 24);
            this.tlsSalir.Text = "Salir";
            this.tlsSalir.Click += new System.EventHandler(this.tlsSalir_Click);
            // 
            // btn_RRHH
            // 
            this.btn_RRHH.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsGestionEmp});
            this.btn_RRHH.Name = "btn_RRHH";
            this.btn_RRHH.Size = new System.Drawing.Size(63, 24);
            this.btn_RRHH.Text = "RRHH";
            this.btn_RRHH.Click += new System.EventHandler(this.btn_RRHH_Click);
            // 
            // tlsGestionEmp
            // 
            this.tlsGestionEmp.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tlsGestionEmp.Image = global::ProyectoProgra3.Properties.Resources.employee;
            this.tlsGestionEmp.Name = "tlsGestionEmp";
            this.tlsGestionEmp.Size = new System.Drawing.Size(212, 24);
            this.tlsGestionEmp.Text = "Gestion Empleados";
            // 
            // btn_Ventas
            // 
            this.btn_Ventas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.venderToolStripMenuItem,
            this.clienteToolStripMenuItem1,
            this.cerrarCajaToolStripMenuItem});
            this.btn_Ventas.Name = "btn_Ventas";
            this.btn_Ventas.Size = new System.Drawing.Size(68, 24);
            this.btn_Ventas.Text = "Ventas";
            // 
            // venderToolStripMenuItem
            // 
            this.venderToolStripMenuItem.Name = "venderToolStripMenuItem";
            this.venderToolStripMenuItem.Size = new System.Drawing.Size(154, 24);
            this.venderToolStripMenuItem.Text = "Facturar";
            this.venderToolStripMenuItem.Click += new System.EventHandler(this.venderToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem1
            // 
            this.clienteToolStripMenuItem1.Name = "clienteToolStripMenuItem1";
            this.clienteToolStripMenuItem1.Size = new System.Drawing.Size(154, 24);
            this.clienteToolStripMenuItem1.Text = "Cliente";
            // 
            // cerrarCajaToolStripMenuItem
            // 
            this.cerrarCajaToolStripMenuItem.Name = "cerrarCajaToolStripMenuItem";
            this.cerrarCajaToolStripMenuItem.Size = new System.Drawing.Size(154, 24);
            this.cerrarCajaToolStripMenuItem.Text = "Cerrar Caja";
            this.cerrarCajaToolStripMenuItem.Click += new System.EventHandler(this.cerrarCajaToolStripMenuItem_Click);
            // 
            // btn_Inventario
            // 
            this.btn_Inventario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsGestionProd,
            this.proveedoresToolStripMenuItem1});
            this.btn_Inventario.Name = "btn_Inventario";
            this.btn_Inventario.Size = new System.Drawing.Size(93, 24);
            this.btn_Inventario.Text = "Inventario";
            // 
            // tlsGestionProd
            // 
            this.tlsGestionProd.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tlsGestionProd.Image = global::ProyectoProgra3.Properties.Resources.Compras;
            this.tlsGestionProd.Name = "tlsGestionProd";
            this.tlsGestionProd.Size = new System.Drawing.Size(228, 24);
            this.tlsGestionProd.Text = "Gestion de Productos";
            this.tlsGestionProd.Click += new System.EventHandler(this.tlsGestionProd_Click);
            // 
            // proveedoresToolStripMenuItem1
            // 
            this.proveedoresToolStripMenuItem1.Name = "proveedoresToolStripMenuItem1";
            this.proveedoresToolStripMenuItem1.Size = new System.Drawing.Size(228, 24);
            this.proveedoresToolStripMenuItem1.Text = "Proveedores";
            this.proveedoresToolStripMenuItem1.Click += new System.EventHandler(this.proveedoresToolStripMenuItem1_Click);
            // 
            // btn_Mantenimientos
            // 
            this.btn_Mantenimientos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsRRHH,
            this.seguridadToolStripMenuItem,
            this.hacerloEnTablasCatalogoToolStripMenuItem,
            this.toolStripSeparator1,
            this.inventarioToolStripMenuItem});
            this.btn_Mantenimientos.Name = "btn_Mantenimientos";
            this.btn_Mantenimientos.Size = new System.Drawing.Size(136, 24);
            this.btn_Mantenimientos.Text = "Mantenimientos";
            // 
            // tlsRRHH
            // 
            this.tlsRRHH.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tlsRRHH.Image = ((System.Drawing.Image)(resources.GetObject("tlsRRHH.Image")));
            this.tlsRRHH.Name = "tlsRRHH";
            this.tlsRRHH.Size = new System.Drawing.Size(260, 24);
            this.tlsRRHH.Text = "RRHH";
            this.tlsRRHH.Click += new System.EventHandler(this.tlsRRHH_Click);
            // 
            // seguridadToolStripMenuItem
            // 
            this.seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            this.seguridadToolStripMenuItem.Size = new System.Drawing.Size(260, 24);
            this.seguridadToolStripMenuItem.Text = "Seguridad";
            // 
            // hacerloEnTablasCatalogoToolStripMenuItem
            // 
            this.hacerloEnTablasCatalogoToolStripMenuItem.Name = "hacerloEnTablasCatalogoToolStripMenuItem";
            this.hacerloEnTablasCatalogoToolStripMenuItem.Size = new System.Drawing.Size(260, 24);
            this.hacerloEnTablasCatalogoToolStripMenuItem.Text = "hacerlo en tablas catalogo";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(257, 6);
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.marcaToolStripMenuItem,
            this.proveedoresToolStripMenuItem,
            this.productosToolStripMenuItem});
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(260, 24);
            this.inventarioToolStripMenuItem.Text = "Inventario";
            // 
            // marcaToolStripMenuItem
            // 
            this.marcaToolStripMenuItem.Name = "marcaToolStripMenuItem";
            this.marcaToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.marcaToolStripMenuItem.Text = "Marca";
            this.marcaToolStripMenuItem.Click += new System.EventHandler(this.marcaToolStripMenuItem_Click);
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // expedientesToolStripMenuItem
            // 
            this.expedientesToolStripMenuItem.Name = "expedientesToolStripMenuItem";
            this.expedientesToolStripMenuItem.Size = new System.Drawing.Size(12, 24);
            // 
            // consultaDeExpedientesToolStripMenuItem
            // 
            this.consultaDeExpedientesToolStripMenuItem.Name = "consultaDeExpedientesToolStripMenuItem";
            this.consultaDeExpedientesToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // lblBienvenidos
            // 
            this.lblBienvenidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenidos.ForeColor = System.Drawing.Color.White;
            this.lblBienvenidos.Location = new System.Drawing.Point(-1, 20);
            this.lblBienvenidos.Name = "lblBienvenidos";
            this.lblBienvenidos.Size = new System.Drawing.Size(997, 62);
            this.lblBienvenidos.TabIndex = 2;
            this.lblBienvenidos.Text = "VETERINARIA \"LA MASOTA\"";
            this.lblBienvenidos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblBienvenidos);
            this.panel1.Location = new System.Drawing.Point(180, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(997, 100);
            this.panel1.TabIndex = 14;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(489, 273);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(395, 402);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1354, 733);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenu";
            this.Text = "MENU PRINCIPAL";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btn_Inicio;
        private System.Windows.Forms.ToolStripMenuItem tlsLogOut;
        private System.Windows.Forms.ToolStripMenuItem tlsSalir;
        private System.Windows.Forms.ToolStripMenuItem btn_Ventas;
        private System.Windows.Forms.Label lblBienvenidos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem btn_Inventario;
        private System.Windows.Forms.ToolStripMenuItem tlsGestionProd;
        private System.Windows.Forms.ToolStripMenuItem btn_RRHH;
        private System.Windows.Forms.ToolStripMenuItem tlsGestionEmp;
        private System.Windows.Forms.ToolStripMenuItem btn_Mantenimientos;
        private System.Windows.Forms.ToolStripMenuItem tlsRRHH;
        private System.Windows.Forms.ToolStripMenuItem expedientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeExpedientesToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem venderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cerrarCajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hacerloEnTablasCatalogoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
    }
}