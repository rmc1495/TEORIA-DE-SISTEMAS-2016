using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace ProyectoProgra3.ProyectoCD
{
    public class CD_Login
    {

            private static string connStr = ConfigurationSettings.AppSettings["connectionString"];

            public CD_Login()
            { }

            #region
            private int _intIdUsuario;
            public int intIdUsuario { get; set; }

            private string _name;
            public string Name
            {
                set { this._name = value; }
                get { return this._name; }
            }

            private string _password;
            public string Password
            {
                set { this._password = value; }
                get { return this._password; }
            }

            private int _intentos;
            public int Intentos
            {
                set { this._intentos = value; }
                get { return this._intentos; }
            }

            private string _Email;
            public string Email
            {
                set { this._Email = value; }
                get { return this._Email; }
            }

            private string _strCodigo;
            public string strCodigo { get; set; }

            private int _intId_RolPermiso;
            public int IntId_RolPermiso { get; set; }
            #endregion

            //este metodo aumenta el numero de intentos fallidos de un usuario
            public static int AumentaIntentos(string strNombre)
            {
                int retorno = 0;
                using (SqlConnection _cnx = new SqlConnection(connStr))
                {
                    _cnx.Open();
                    SqlCommand comand = new SqlCommand("stp_AumentaIntentosFallidos", _cnx);
                    //se envia parametro strNombre 
                    comand.Parameters.Add("@vrch_Usuario", SqlDbType.VarChar).Value = strNombre.Trim();
                    comand.CommandType = CommandType.StoredProcedure;
                    retorno = comand.ExecuteNonQuery();
                }
                return retorno;
            }

            //Este metodo valida los credenciales para hacer login y lo devuelve en un datatable para utilizar 
            //la informacion en la capa UI
            public static DataTable InicioSecion(string strNombre, string strPass)
            {
                DataTable ListUser1 = new DataTable();// lista con usuariosque seran llevados a la capa IU

                using (SqlConnection _cnx = new SqlConnection(connStr))
                {
                    _cnx.Open();
                    SqlCommand comand = new SqlCommand("stp_Login", _cnx);
                    //se envian parametros strNombre y strPass al store procedure
                    comand.Parameters.Add("@vrch_Usuario", SqlDbType.VarChar).Value = strNombre.Trim();
                    comand.Parameters.Add("@vrch_Clave", SqlDbType.VarChar).Value = strPass.Trim();
                    comand.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter dap = new SqlDataAdapter(comand);
                    dap.Fill(ListUser1);
                    return ListUser1;


                }
            } // fin del metodo inicio de seccion

            //este metodo reinicia la variable IntentosFallidos
            public static int BorraIntentos(string strNombre)
            {
                int retorno = 0;
                using (SqlConnection _cnx = new SqlConnection(connStr))
                {
                    _cnx.Open();
                    SqlCommand comand = new SqlCommand("stp_BorraIntentosFallidos", _cnx);
                    //se envia parametro strNombre 
                    comand.Parameters.Add("@vrch_Usuario", SqlDbType.VarChar).Value = strNombre.Trim();
                    comand.CommandType = CommandType.StoredProcedure;
                    retorno = comand.ExecuteNonQuery();
                }
                return retorno;
            }


            //este metodo trae de la BD el email y contraseña de un usuario
            public static DataTable RecuperarContraseña(string strNombre)
            {
                DataTable ListUser1 = new DataTable();// lista con Info que sera llevada a la capa IU

                using (SqlConnection _cnx = new SqlConnection(connStr))
                {
                    _cnx.Open();
                    SqlCommand comand = new SqlCommand("stp_RecuperarClave", _cnx);
                    //se envia parametro strNombre al store procedure
                    comand.Parameters.Add("@vrch_Usuario", SqlDbType.VarChar).Value = strNombre.Trim();
                    comand.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter dap = new SqlDataAdapter(comand);
                    dap.Fill(ListUser1);
                    return ListUser1;

                }
            }//fin del metodo recuperar contraseña

            //este metodo se usa para traer los datos de usuario y clave por un id
            public static DataTable InfoUser(int Id)
            {
                DataTable ListUser1 = new DataTable();// lista con Info que sera llevada a la capa IU

                using (SqlConnection _cnx = new SqlConnection(connStr))
                {
                    _cnx.Open();
                    SqlCommand comand = new SqlCommand("stp_InfoUser", _cnx);
                    //se envia parametro Id al store procedure
                    comand.Parameters.Add("@int_IdUsuario", SqlDbType.Int).Value = Id;
                    comand.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter dap = new SqlDataAdapter(comand);
                    dap.Fill(ListUser1);
                    return ListUser1;

                }
            }//fin del metodo recuperar contraseña

            //este metodo se usa para traer solamente un id
            public static DataTable CargarId(string strNombre)
            {
                DataTable ListUser1 = new DataTable();// lista con Info que sera llevada a la capa IU

                using (SqlConnection _cnx = new SqlConnection(connStr))
                {
                    _cnx.Open();
                    SqlCommand comand = new SqlCommand("stp_CargarId", _cnx);
                    //se envia parametro strNombre al store procedure
                    comand.Parameters.Add("@vrch_Usuario", SqlDbType.VarChar).Value = strNombre.Trim();
                    comand.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter dap = new SqlDataAdapter(comand);
                    dap.Fill(ListUser1);
                    return ListUser1;

                }
            }//fin del metodo CargarId

        

    }
}
