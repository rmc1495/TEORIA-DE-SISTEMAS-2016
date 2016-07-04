using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace ProyectoProgra3.ProyectoCN
{
    public class CN_Usuarios
    {

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

        public void GuardarUsuarios(CN_Usuarios usu)
        {
            ProyectoCD.CD_Usuarios capa = new ProyectoCD.CD_Usuarios();
            capa.Username = usu.Username;
            capa.Password = usu.Password;
            capa.IdEmpleado = usu.IdEmpleado;
            capa.Id_Rol = usu.Id_Rol;
            capa.IDEstado = usu.IDEstado;
            capa.InsertarUsuarios(capa);
        }

        public void ActualizarUsuarios(CN_Usuarios usu)
        {
            ProyectoCD.CD_Usuarios capa = new ProyectoCD.CD_Usuarios();
            capa.Username = usu.Username;
            capa.Password = usu.Password;
            capa.IdEmpleado = usu.IdEmpleado;
            capa.Id_Rol = usu.Id_Rol;
            capa.IDEstado = usu.IDEstado;
            capa.ActualizarUsuarios(capa);
        }

        public DataSet ListarUsuarios()
        {
            ProyectoCD.CD_Usuarios capa = new ProyectoCD.CD_Usuarios();
            return capa.ListarUsuarios();
        }

        public DataSet BuscarUsuarios(ref CN_Usuarios usu)
        {
            ProyectoCD.CD_Usuarios capa = new ProyectoCD.CD_Usuarios();
            DataSet obtenerDts = capa.ObtenerUsuarios(usu.Username);
            return obtenerDts;
        }

        public void EliminarUsuarios(ref CN_Usuarios usu)
        {
            ProyectoCD.CD_Usuarios capa = new ProyectoCD.CD_Usuarios();
            capa.EliminarUsuarios(capa.Username = usu.Username);
        }

        public int Verificar(string usuario, string pass)
        {
            ProyectoCD.CD_Usuarios capa = new ProyectoCD.CD_Usuarios();
            return capa.Autentificar(usuario, pass);
        }

        public int RoldeUsuario(string user)
        {
            ProyectoCD.CD_Usuarios capa = new ProyectoCD.CD_Usuarios();
            return capa.AveriguarRol(user);
        }

        public DataSet FiltrarUsu(string tipo, string param)
        {
            ProyectoCD.CD_Usuarios capa = new ProyectoCD.CD_Usuarios();
            DataSet obtenerDts = capa.FiltrarUsuario(tipo, param);
            return obtenerDts;
        }

        #endregion

    }
}
