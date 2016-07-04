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
   public class CD_Roles : ConexionBD
    {

        #region StoredProcedures

        string INSERTAR_ROLES = "sp_insertar_roles";
        string ELIMINAR_ROLES = "sp_eliminar_roles";
        string OBTENER_ROLES = "sp_lista_roles";
        string ACTUALIZAR_ROLES = "sp_actualizar_roles";
        string LISTA_ROLES = "sp_listaTodo_roles";

        #endregion

        #region Variables

        private int id_rol;
        private string nombre;
        private string descripcion;
        private char idEstado;

        #endregion

        #region Propiedades

        public int IdRol
        {
            get { return id_rol; }
            set { id_rol = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        public char IDEstado
        {
            get { return idEstado; }
            set { idEstado = value; }
        }
        #endregion

        #region Metodos

        public CD_Roles( ) : base( )
        { }

        public void InsertarRoles(CD_Roles objeto)
        {
            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = INSERTAR_ROLES;
            resuelva.Parameters.Add(new SqlParameter("@Nombre", objeto.Nombre));
            resuelva.Parameters.Add(new SqlParameter("@Descripcion", objeto.Descripcion));
            resuelva.Parameters.Add(new SqlParameter("@IdEstado", objeto.IDEstado));
            Ejecutar(resuelva);
        }

        public void EliminarRoles (int ID)
        {
            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = ELIMINAR_ROLES;
            resuelva.Parameters.Add(new SqlParameter("@Id_Rol", ID));
            Ejecutar(resuelva);
        }

        public DataSet ObtenerRoles(int ID)
        {
            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = OBTENER_ROLES;
            resuelva.Parameters.Add(new SqlParameter("@Id_Rol", ID));
            return Consultar(resuelva, "UnicoRol");
        }

        public void ActualizarRoles(CD_Roles objeto)
        {
            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = ACTUALIZAR_ROLES;
            resuelva.Parameters.Add(new SqlParameter("@Id_Rol", objeto.IdRol));
            resuelva.Parameters.Add(new SqlParameter("@Nombre", objeto.Nombre));
            resuelva.Parameters.Add(new SqlParameter("@Descripcion", objeto.Descripcion));
            resuelva.Parameters.Add(new SqlParameter("@IdEstado", objeto.IDEstado));
            Ejecutar(resuelva);
        }

        public DataSet ListarRoles()
        {
            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = LISTA_ROLES;
            return Consultar(resuelva, "TblRoles");
        }

        #endregion

    }
}
