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
    public class CD_Estados : ConexionBD
    {

        #region StoredProcedures

        string INSERTAR_ESTADO = "sp_insertar_estados";
        string ELIMINAR_ESTADO = "sp_eliminar_estados";
        string OBTENER_ESTADO= "sp_lista_estados";
        string ACTUALIZAR_ESTADO = "sp_actualizar_estados";
        string LISTA_ESTADO = "sp_listaTodo_estados";

        #endregion

        #region Variables

        private char idEstado;
        private string descripcion;

        #endregion

        #region Propiedades

        public char IdEstado
        {
            get { return idEstado; }
            set { idEstado = value;}
        }
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        #endregion

         #region Metodos

        public CD_Estados() : base()
        { }

        public void InsertarEstado(CD_Estados objeto)
        {
            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = INSERTAR_ESTADO;
            resuelva.Parameters.Add(new SqlParameter("@IdEstado", objeto.IdEstado));
            resuelva.Parameters.Add(new SqlParameter("@Descripcion", objeto.Descripcion));
            Ejecutar(resuelva);
        }

        public void EliminarEstado(char ID)
        {
            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = ELIMINAR_ESTADO;
            resuelva.Parameters.Add(new SqlParameter("@IdEstado", ID));
            Ejecutar(resuelva);
        }

        public DataSet ObtenerEstado(char ID)
        {
            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = OBTENER_ESTADO;
            resuelva.Parameters.Add(new SqlParameter("@IdEstado", ID));
            return Consultar(resuelva, "UnicoEstado");
        }

        public void ActualizarEstado(CD_Estados objeto)
        {
            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = ACTUALIZAR_ESTADO;
            resuelva.Parameters.Add(new SqlParameter("@IdEstado", objeto.IdEstado));
            resuelva.Parameters.Add(new SqlParameter("@Descripcion", objeto.Descripcion));
            Ejecutar(resuelva);
        }

        public DataSet ListarEstados()
        {
            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = LISTA_ESTADO;
            return Consultar(resuelva, "TblEstados");
        }

        #endregion

    }
}
