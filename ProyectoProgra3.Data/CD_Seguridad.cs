using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace ProyectoProgra3.ProyectoCD
{
    public class CD_Seguridad
    {

        public CD_Seguridad()
        { }

#pragma warning disable CS0618 // Type or member is obsolete
        private static string connStr = ConfigurationSettings.AppSettings["connectionString"];
#pragma warning restore CS0618 // Type or member is obsolete

        //este metodo trae los datos de seguridad para mostar el menu
        public static DataTable SeguridadMenu(int iduser)
        {
            DataTable ListUser1 = new DataTable();// lista con Info que sera llevada a la capa IU

            using (SqlConnection _cnx = new SqlConnection(connStr))
            {
                _cnx.Open();
                SqlCommand comand = new SqlCommand("stp_SeguridadMenu", _cnx);
                //se envia parametro strNombre al store procedure
                comand.Parameters.Add("@IdUsuario", SqlDbType.Int).Value = iduser;
                comand.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter dap = new SqlDataAdapter(comand);
                dap.Fill(ListUser1);
                return ListUser1;

            }
        }//fin del metodo Seguridad Menu

        //Este metodo lo usa el usuario Administrador para realizar cambios de clave
        public static int AdminCambiaClave(string strNombre, string Clave)
        {
            int retorno = 0;
            using (SqlConnection _cnx = new SqlConnection(connStr))
            {
                _cnx.Open();
                SqlCommand comand = new SqlCommand("stp_AdminCambiaClave", _cnx);
                //se envia parametro strNombre 
                comand.Parameters.Add("@vrch_Usuario", SqlDbType.VarChar).Value = strNombre.Trim();
                comand.Parameters.Add("@vrch_Clave", SqlDbType.VarChar).Value = Clave.Trim();
                comand.CommandType = CommandType.StoredProcedure;
                retorno = comand.ExecuteNonQuery();
            }
            return retorno;
        }//Fin del metodo AdminCambiaClave

        //Este metodo se usa para cargar el total de los permisos del menu de un usuario
        public static DataTable CargarSeguridad(int iduser)
        {
            DataTable ListUser1 = new DataTable();// lista con Info que sera llevada a la capa IU

            using (SqlConnection _cnx = new SqlConnection(connStr))
            {
                _cnx.Open();
                SqlCommand comand = new SqlCommand("stp_CargarSeguridad", _cnx);
                //se envia parametro strNombre al store procedure
                comand.Parameters.Add("@int_IdUsuario", SqlDbType.Int).Value = iduser;
                comand.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter dap = new SqlDataAdapter(comand);
                dap.Fill(ListUser1);
                return ListUser1;

            }
        }//fin del metodo CargarSeguridad

        //Este metodo lo usa el usuario para realizar cambios Seguridad
        public static int AgregarPermiso(int iduser, int idMenu, int idSubMenu)
        {
            int retorno = 0;
            using (SqlConnection _cnx = new SqlConnection(connStr))
            {
                _cnx.Open();
                SqlCommand comand = new SqlCommand("stp_AgregarPermiso", _cnx);
                //se envia parametro strNombre 
                comand.Parameters.Add("@int_IdUsuario", SqlDbType.Int).Value = iduser;
                comand.Parameters.Add("@int_IdMenu", SqlDbType.Int).Value = idMenu;
                comand.Parameters.Add("@int_IdSubMenu", SqlDbType.Int).Value = idSubMenu;
                comand.CommandType = CommandType.StoredProcedure;
                retorno = comand.ExecuteNonQuery();
            }
            return retorno;
        }//Fin del metodo AgregarPermiso

        //Este metodo lo usa el usuario para realizar cambios Seguridad
        public static int QuitarPermiso(int iduser, int idMenu, int idSubMenu)
        {
            int retorno = 0;
            using (SqlConnection _cnx = new SqlConnection(connStr))
            {
                _cnx.Open();
                SqlCommand comand = new SqlCommand("stp_QuitarPermiso", _cnx);
                //se envia parametro strNombre 
                comand.Parameters.Add("@int_IdUsuario", SqlDbType.Int).Value = iduser;
                comand.Parameters.Add("@int_IdMenu", SqlDbType.Int).Value = idMenu;
                comand.Parameters.Add("@int_IdSubMenu", SqlDbType.Int).Value = idSubMenu;
                comand.CommandType = CommandType.StoredProcedure;
                retorno = comand.ExecuteNonQuery();
            }
            return retorno;
        }//Fin del metodo AgregarPermiso

    }
}
