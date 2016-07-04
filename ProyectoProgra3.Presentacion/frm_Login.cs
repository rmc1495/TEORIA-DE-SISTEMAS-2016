using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ProyectoProgra3.ProyectoCN;
using System.Net.Mail;

namespace ProyectoProgra3
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
           
        }

        CN_Login objUserBU = new CN_Login();// instancia del obtego usuario de la clase BU

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "" || txtPass.Text == "")// valida los textbox que no esten vacios
            {
                MessageBox.Show("Los campos de Usuario y Contraseña son requeridos", "Hay Espacios Vacios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }//fin del if
            else
            {
                //luego valida que el usuario exista

                Ingresar();

            }//fin del else

        }



        private void btnRegistrarUsu_Click(object sender, EventArgs e)
        {
            this.Hide();//oculta la ventana login
            RecuperarClave ventana = new RecuperarClave();
            ventana.Show();
           /* frm_Registro_Usuarios frmRegUsu = new frm_Registro_Usuarios();
            frmRegUsu.ShowDialog();*/
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        #region Metodos
        //este metodo sirve para ingresar al sistema
        public void Ingresar()
        {
            try
            {

                /*******************************/
                //estas variables se cargan con la informacion del usuario
                DataTable verificaruser = objUserBU.RecuperarContraseña(txtUsuario.Text);//solo se usa para verificar que el usuario exista
                int intentosfallidos = Convert.ToInt16(verificaruser.Rows[0].ItemArray[3].ToString());
                if (verificaruser.Rows.Count <= 0)
                {
                    MessageBox.Show("El usuario no existe");
                }
                else
                {
                    DataTable InfoUser = objUserBU.BUselectUsario(txtUsuario.Text, txtPass.Text);

                    if (intentosfallidos >= 3)
                    {
                        MessageBox.Show("Ha superado el limite de intentos de Login, su usuario está bloqueado");
                        this.Hide();//oculta la ventana login
                        RecuperarClave ventana = new RecuperarClave();
                        ventana.Show();

                    }
                    else
                    {
                        if (InfoUser.Rows.Count <= 0)//Aumenta el numero de intentos fallidos
                        {
                            MessageBox.Show("Error en Usuario o Contraseña");
                            if (Convert.ToInt16(verificaruser.Rows[0].ItemArray[3].ToString()) == 0 && txtUsuario.Text == "admin")
                            {
                                MessageBox.Show("No se aumentaron los intentos");
                            }
                            else
                            {
                                AumentarIntentos(verificaruser.Rows[0].ItemArray[0].ToString());
                                MessageBox.Show("Ha realizado un intento de login fallido");
                            }

                        }
                        else
                        {
                            int iduser = Convert.ToInt16(InfoUser.Rows[0].ItemArray[0].ToString());
                            int idempleado = Convert.ToInt16(InfoUser.Rows[0].ItemArray[1].ToString());
                            int intentos = Convert.ToInt16(InfoUser.Rows[0].ItemArray[4].ToString());
                            string user = InfoUser.Rows[0].ItemArray[2].ToString();
                            string pass = InfoUser.Rows[0].ItemArray[3].ToString();
                            //este if verifica los intentos fallidos de ingreso de un usuario
                            if (intentos >= 3 && iduser != 1)
                            {
                                MessageBox.Show("Ha superado el limite de intentos de Login, su usuario está bloqueado");
                                EmailRecuperarClave(user);
                            }
                            else
                            {

                                if (txtUsuario.Text == user && txtPass.Text == pass)
                                {
                                    
                                    objUserBU.BorraIntentos(txtUsuario.Text);
                                    this.Hide();
                                    frmMenu sistema = new frmMenu(iduser, idempleado);
                                    sistema.Show();
                                }

                                else //este else aumenta el contador de intentos fallidos de un usuario
                                {
                                    MessageBox.Show("Error, es imposible acceder al sistema");
                                    
                                }


                            }//fin del else 
                        }


                    }//find del else




                    /*******************************/
                }//fin else que valida usuario


            }//fin del try
            catch (Exception e) { MessageBox.Show(e.Message); }
        }//fin del metodo ingresar   

        //este metodo es de prueba para enviar un email
        public void EmailRecuperarClave(string struser)
        {


            DataTable info = objUserBU.RecuperarContraseña(struser);

            if (info.Rows.Count <= 0)
            {
                MessageBox.Show("El usuario no existe");
            }
            else
            {

                string user = info.Rows[0].ItemArray[0].ToString();
                string pass = info.Rows[0].ItemArray[1].ToString();

                string from = "teoriasistemasuam@gmail.com"; //Correo para envio de correos 
                string to = info.Rows[0].ItemArray[2].ToString(); ; //este es el correo del usuario

                System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
                mail.To.Add(to);
                mail.From = new MailAddress(from, "SOPORTE PROYECTO ANALISIS", System.Text.Encoding.UTF8);
                mail.Subject = "Recuperación de contraseña";
                mail.SubjectEncoding = System.Text.Encoding.UTF8;
                mail.Body = "El usuario: " + user + " ha sido bloqueado por intentos fallidos \n" +
                    "Su Contraseña es: " + pass + "\t Intente ingresar al sistema nuevamente.";
                mail.BodyEncoding = System.Text.Encoding.UTF8;
                mail.IsBodyHtml = true;
                mail.Priority = MailPriority.High;

                SmtpClient client = new SmtpClient();
                //Aqui se agregan los credenciales para validar el envio del correo

                client.Credentials = new System.Net.NetworkCredential(from, "teoria2016");

                client.Port = 587; // Gmail works on this port
                client.Host = "smtp.gmail.com";
                client.EnableSsl = true; //Gmail works on Server Secured Layer
                try
                {
                    client.Send(mail);
                    MessageBox.Show("Se ha enviado un e-mail al correo: " + to + " con la información de recuperacion de contraseña");
                    objUserBU.BorraIntentos(user);//se llama al metodo para desbloquear al usuario por intentos fallidos
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }// end try
            }

        }

        private void btn_Email_Click(object sender, EventArgs e)
        {
            this.Hide();//oculta la ventana login
            RecuperarClave ventana = new RecuperarClave();
            ventana.Show();
            //EmailRecuperarClave(txb_Usuario.Text);
        }

        public int AumentarIntentos(string usuario)
        {
            ProyectoCN.CN_Login obj = new ProyectoCN.CN_Login();
            int retorno = obj.AumentaIntentos(usuario);
            return retorno;
        }

        private void frm_Principal_Load(object sender, EventArgs e)
        {

        }//fin metodo aumentarintentos
        #endregion

    }
}
