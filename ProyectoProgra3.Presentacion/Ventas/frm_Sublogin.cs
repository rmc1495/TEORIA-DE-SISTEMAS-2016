using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoProgra3.Ventas
{
    public partial class frm_Sublogin : Form
    {
        ProyectoCN.CN_Login objUserBU = new ProyectoCN.CN_Login();
        Ventas.CN_Ventas CN = new Ventas.CN_Ventas();

        public frm_Sublogin()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if (txtUsuario.Text == "" || txtPass.Text == "")// valida los textbox que no esten vacios
            {
                MessageBox.Show("Favor rellenar datos", "Hay Espacios Vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Verificar();
            }
            

           
        }
    private void Verificar()
            {
                DataTable verificaruser = objUserBU.RecuperarContraseña(txtUsuario.Text);
                if (verificaruser.Rows.Count <= 0)
                {
                    MessageBox.Show("El usuario no existe");
                }
                else
                {
                    try
                    {
                        DataTable InfoUser = objUserBU.BUselectUsario(txtUsuario.Text, txtPass.Text);

                        int iduser = Convert.ToInt16(InfoUser.Rows[0].ItemArray[0].ToString());
                        int idempleado = Convert.ToInt16(InfoUser.Rows[0].ItemArray[1].ToString());
                        int intentos = Convert.ToInt16(InfoUser.Rows[0].ItemArray[4].ToString());
                        string user = InfoUser.Rows[0].ItemArray[2].ToString();
                        string pass = InfoUser.Rows[0].ItemArray[3].ToString();
                        int rol = Convert.ToInt32(InfoUser.Rows[0].ItemArray[7].ToString());
                        Ventas.CN_Ventas CN = new Ventas.CN_Ventas(); //ocupo nombre de usuario y id para el uso en el Cajero
                        CN.DevolucionempleadoID = idempleado;
                        CN.DevolucionempleadoNombre = user;


                        if (txtUsuario.Text == user && txtPass.Text == pass && (rol == 1 || rol == 4))
                        {
                            this.Close();
                        }

                        else //este else aumenta el contador de intentos fallidos de un usuario
                        {
                            MessageBox.Show("Error, es imposible acceder al sistema o no tienes los privilegios suficientes para utilizar esta opción");
                        }
                    }//fin del try
                    catch (Exception e) { MessageBox.Show("Usuario o contraseña incorrectos"); }
                }                  
            }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Ventas.frm_Ventas ventas = new Ventas.frm_Ventas();
            CN.LoginC = true;
            //ventas.CambiarTAB();
            this.Close();        
        }
    }
}
