using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using ProyectoProgra3.ProyectoCN;

namespace ProyectoProgra3
{
    public partial class RecuperarClave : Form
    {
        public RecuperarClave()
        {
            InitializeComponent();
        }

        CN_Login objUserBU = new CN_Login();// instancia del obtego usuario de la clase BU
        frm_Login ventana = new frm_Login();

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
                mail.From = new MailAddress(from, "SOPORTE PROYECTO TEORIA SISTEMAS", System.Text.Encoding.UTF8);
                mail.Subject = "Recuperación de contraseña";
                mail.SubjectEncoding = System.Text.Encoding.UTF8;
                mail.Body = "El usuario: " + user + " ha hecho una solicitud de recuperacion de contraseña \n" +
                    "Su Contraseña es: " + pass + "\n Intente ingresar al sistema nuevamente.";
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
                    this.Hide();
                    ventana.Show();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }// end try
            }

        }

        private void btn_Enviar_Click(object sender, EventArgs e)
        {
            if (txb_Usuario.Text == "")
            {
                MessageBox.Show("El campo se encuentra vacio");
            }

            else
            {
                EmailRecuperarClave(txb_Usuario.Text);
                int desbloqueado = BorraIntentos(txb_Usuario.Text);
                if (desbloqueado > 0)
                {
                    MessageBox.Show("Se ha desbloqueado su usuario para que intente ingresar de nuevo");
                }
                else
                { MessageBox.Show("No se ha desbloqueado su usuario o este no existe"); }
            }

            
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            ventana.Show();
        }

        public int BorraIntentos(string usuario)
        {
            CN_Login obj = new CN_Login();
            int retorno = obj.BorraIntentos(usuario);
            return retorno;
        }//fin metodo aumentarintentos
    }
}

