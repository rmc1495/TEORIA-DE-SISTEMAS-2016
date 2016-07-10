namespace ProyectoProgra3
{
    partial class frm_Registro_Usuarios
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomUsuario = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtRepPass = new System.Windows.Forms.TextBox();
            this.lblerror = new System.Windows.Forms.Label();
            this.btnRegistrarUsuario = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cBoxIdEmpleado = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cBoxIdEstado = new System.Windows.Forms.ComboBox();
            this.cBoxRoles = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 139);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Repetir Contraseña:";
            // 
            // txtNomUsuario
            // 
            this.txtNomUsuario.Location = new System.Drawing.Point(215, 39);
            this.txtNomUsuario.Margin = new System.Windows.Forms.Padding(5);
            this.txtNomUsuario.Name = "txtNomUsuario";
            this.txtNomUsuario.Size = new System.Drawing.Size(164, 29);
            this.txtNomUsuario.TabIndex = 0;
            this.txtNomUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomUsuario_KeyPress);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(215, 87);
            this.txtPass.Margin = new System.Windows.Forms.Padding(5);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(164, 29);
            this.txtPass.TabIndex = 1;
            this.txtPass.UseSystemPasswordChar = true;
            this.txtPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPass_KeyPress);
            // 
            // txtRepPass
            // 
            this.txtRepPass.Location = new System.Drawing.Point(215, 136);
            this.txtRepPass.Margin = new System.Windows.Forms.Padding(5);
            this.txtRepPass.Name = "txtRepPass";
            this.txtRepPass.Size = new System.Drawing.Size(164, 29);
            this.txtRepPass.TabIndex = 2;
            this.txtRepPass.UseSystemPasswordChar = true;
            this.txtRepPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPass_KeyPress);
            // 
            // lblerror
            // 
            this.lblerror.Location = new System.Drawing.Point(53, 267);
            this.lblerror.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(313, 42);
            this.lblerror.TabIndex = 6;
            this.lblerror.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblerror.Visible = false;
            // 
            // btnRegistrarUsuario
            // 
            this.btnRegistrarUsuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarUsuario.Location = new System.Drawing.Point(241, 198);
            this.btnRegistrarUsuario.Margin = new System.Windows.Forms.Padding(5);
            this.btnRegistrarUsuario.Name = "btnRegistrarUsuario";
            this.btnRegistrarUsuario.Size = new System.Drawing.Size(125, 37);
            this.btnRegistrarUsuario.TabIndex = 4;
            this.btnRegistrarUsuario.Text = "Aceptar";
            this.btnRegistrarUsuario.UseVisualStyleBackColor = true;
            this.btnRegistrarUsuario.Click += new System.EventHandler(this.btnRegistrarUsuario_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(411, 198);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(125, 37);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(411, 42);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Rol de Usuario:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(411, 90);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "Id de Empleado:";
            // 
            // cBoxIdEmpleado
            // 
            this.cBoxIdEmpleado.FormattingEnabled = true;
            this.cBoxIdEmpleado.Location = new System.Drawing.Point(554, 87);
            this.cBoxIdEmpleado.Name = "cBoxIdEmpleado";
            this.cBoxIdEmpleado.Size = new System.Drawing.Size(164, 29);
            this.cBoxIdEmpleado.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(411, 139);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 21);
            this.label6.TabIndex = 13;
            this.label6.Text = "Id de Estado:";
            // 
            // cBoxIdEstado
            // 
            this.cBoxIdEstado.FormattingEnabled = true;
            this.cBoxIdEstado.Location = new System.Drawing.Point(554, 136);
            this.cBoxIdEstado.Name = "cBoxIdEstado";
            this.cBoxIdEstado.Size = new System.Drawing.Size(164, 29);
            this.cBoxIdEstado.TabIndex = 14;
            // 
            // cBoxRoles
            // 
            this.cBoxRoles.FormattingEnabled = true;
            this.cBoxRoles.Location = new System.Drawing.Point(554, 39);
            this.cBoxRoles.Name = "cBoxRoles";
            this.cBoxRoles.Size = new System.Drawing.Size(164, 29);
            this.cBoxRoles.TabIndex = 15;
            // 
            // frm_Registro_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(766, 258);
            this.Controls.Add(this.cBoxRoles);
            this.Controls.Add(this.cBoxIdEstado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cBoxIdEmpleado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegistrarUsuario);
            this.Controls.Add(this.lblerror);
            this.Controls.Add(this.txtRepPass);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtNomUsuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Registro_Usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REGISTRO DE USUARIOS";
            this.Load += new System.EventHandler(this.frm_Registro_Usuarios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomUsuario;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtRepPass;
        private System.Windows.Forms.Label lblerror;
        private System.Windows.Forms.Button btnRegistrarUsuario;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cBoxIdEmpleado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cBoxIdEstado;
        private System.Windows.Forms.ComboBox cBoxRoles;
    }
}