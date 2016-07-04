using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Configuration;

namespace ProyectoProgra3.ProyectoCD
{
    public class CD_Usuarios: ConexionBD
    {

        #region StoredProcedures

        string INSERTAR_USUARIOS = "sp_insertar_usuarios";
        string ELIMINAR_USUARIOS= "sp_eliminar_usuarios";
        string OBTENER_USUARIOS = "sp_lista_usuarios";
        string ACTUALIZAR_USUARIOS = "sp_actualizar_usuarios";
        string LISTA_USUARIOS = "sp_listaTodo_usuarios";

        #endregion

        #region Variables


        private string username;
        private string password;
        private string idEmpleado;
        private int id_Rol;
        private char idEstado;

        #endregion

        #region Propiedades

        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string IdEmpleado
        {
            get { return idEmpleado; }
            set { idEmpleado = value; }
        }
        public int Id_Rol
        {
            get { return id_Rol; }
            set { id_Rol = value; }
        }
        public char IDEstado
        {
            get { return idEstado; }
            set { idEstado = value; }
        }
        #endregion

        #region Metodos

        public CD_Usuarios( ) : base( )
        { }

        public void InsertarUsuarios(CD_Usuarios objeto)
        {
            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = INSERTAR_USUARIOS;
            resuelva.Parameters.Add(new SqlParameter("@Username", objeto.Username));
            resuelva.Parameters.Add(new SqlParameter("@Password", objeto.Password));
            resuelva.Parameters.Add(new SqlParameter("@IdEmpleado", objeto.IdEmpleado));
            resuelva.Parameters.Add(new SqlParameter("@Id_Rol", objeto.Id_Rol));
            resuelva.Parameters.Add(new SqlParameter("@IdEstado", objeto.IDEstado));
            Ejecutar(resuelva);
        }

        public void EliminarUsuarios(string user)
        {
            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = ELIMINAR_USUARIOS;
            resuelva.Parameters.Add(new SqlParameter("@Username", user));
            Ejecutar(resuelva);
        }

        public DataSet ObtenerUsuarios(string user)
        {
            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = OBTENER_USUARIOS;
            resuelva.Parameters.Add(new SqlParameter("@Username", user));
            return Consultar(resuelva, "UnicoUsuario");
        }

        public void ActualizarUsuarios(CD_Usuarios objeto)
        {
            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = ACTUALIZAR_USUARIOS;
            resuelva.Parameters.Add(new SqlParameter("@Username", objeto.Username));
            resuelva.Parameters.Add(new SqlParameter("@Password", objeto.Password));
            resuelva.Parameters.Add(new SqlParameter("@IdEmpleado", objeto.IdEmpleado));
            resuelva.Parameters.Add(new SqlParameter("@Id_Rol", objeto.Id_Rol));
            resuelva.Parameters.Add(new SqlParameter("@IdEstado", objeto.IDEstado));
            Ejecutar(resuelva);
        }

        public DataSet ListarUsuarios()
        {
            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = LISTA_USUARIOS;
            return Consultar(resuelva, "TblUsuarios");
        }

        public  int Autentificar(string pUsuarios, string pContrasena)
        {
            int resultado = -1;

            SqlConnection conexion = ConexionBD.obtenerconexionListas();

            SqlCommand comando = new SqlCommand(string.Format("Select * From T_Usuarios Where Username = '{0}' and Password = '{1}'", pUsuarios, pContrasena), conexion);
            SqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                resultado = 50;
            }
            conexion.Close();
            return resultado;
        }

        public int AveriguarRol(string user)
        {
            int numeroRol = 0;
            SqlConnection conexion = ConexionBD.obtenerconexionListas();

            SqlCommand _comando = new SqlCommand(string.Format("select Id_Rol from T_Usuarios where Username = '{0}'", user), conexion);
            SqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                CD_Usuarios pUsuarios = new CD_Usuarios();
                pUsuarios.Id_Rol= _reader.GetInt32(0);
                numeroRol = pUsuarios.Id_Rol;

            }
            conexion.Close();
            return numeroRol;
        }

        public DataSet FiltrarUsuario(string tipo, string param)
        {
            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = String.Format("select * from T_Usuarios where {0} like '{1}%' ", tipo, param);
            return ConsultarFiltros(resuelva, "filtrarUsuario");
        }

        #endregion
    }
}
