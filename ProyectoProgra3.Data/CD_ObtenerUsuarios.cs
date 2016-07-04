using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace ProyectoProgra3.ProyectoCD
{
    
    public class CD_ObtenerUsuarios
    {

        public static int Autentificar(string pUsuarios, string pContraseña)
        {
            int resultado = -1;

            SqlConnection conexion = ConexionBD.obtenerconexionListas();

            SqlCommand comando = new SqlCommand(string.Format("select * from T_Estados Where Username = '{0}' and PwdCompare('{1}', Password) = 1 ", pUsuarios, pContraseña), conexion);
            SqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                resultado = 50;
            }
            conexion.Close();
            return resultado;
        }


    }
}
