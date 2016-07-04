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
    public class CD_TipoClientes: ConexionBD
    {

        #region StoredProcedures

        string INSERTAR_TIPO_CLIENTES = "sp_insertar_tiposClientes";
        string ELIMINAR_TIPO_CLIENTES = "sp_eliminar_tiposClientes";
        string OBTENER_TIPO_CLIENTES = "sp_lista_tiposClientes";
        string ACTUALIZAR_TIPO_CLIENTES = "sp_actualizar_tiposClientes";
        string LISTA_TIPO_CLIENTES= "sp_listaTodo_tiposClientes";

        #endregion

        #region Variables

        private int idTipoCliente;
        private string tipoCliente;
        private string descripcion;
        private char idEstado;

        #endregion

        #region Propiedades

        public int IdTipoCliente
        {
            get { return idTipoCliente; }
            set { idTipoCliente = value; }
        }
        public string TipoCliente
        {
            get { return tipoCliente; }
            set { tipoCliente = value; }
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

        public CD_TipoClientes( ) : base( )
        { }

        public void InsertarTipoClientes(CD_TipoClientes objeto)
        {
            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = INSERTAR_TIPO_CLIENTES;
            resuelva.Parameters.Add(new SqlParameter("@TipoCliente", objeto.TipoCliente));
            resuelva.Parameters.Add(new SqlParameter("@Descripcion", objeto.Descripcion));
            resuelva.Parameters.Add(new SqlParameter("@IdEstado", objeto.IDEstado));
            Ejecutar(resuelva);
        }

        public void EliminarTipoClientes(int ID)
        {
            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = ELIMINAR_TIPO_CLIENTES;
            resuelva.Parameters.Add(new SqlParameter("@IdTipoCliente", ID));
            Ejecutar(resuelva);
        }

        public DataSet ObtenerTipoClientes(int ID)
        {
            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = OBTENER_TIPO_CLIENTES;
            resuelva.Parameters.Add(new SqlParameter("@IdTipoCliente", ID));
            return Consultar(resuelva, "UnicoTipoClientes");
        }

        public void ActualizarTipoClientes(CD_TipoClientes objeto)
        {
            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = ACTUALIZAR_TIPO_CLIENTES;
            resuelva.Parameters.Add(new SqlParameter("@IdTipoCliente", objeto.IdTipoCliente));
            resuelva.Parameters.Add(new SqlParameter("@TipoCliente", objeto.TipoCliente));
            resuelva.Parameters.Add(new SqlParameter("@Descripcion", objeto.Descripcion));
            resuelva.Parameters.Add(new SqlParameter("@IdEstado", objeto.IDEstado));
            Ejecutar(resuelva);
        }

        public DataSet ListarTipoClientes()
        {
            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = LISTA_TIPO_CLIENTES;
            return Consultar(resuelva, "TblTipoClientes");
        }

        #endregion

    }
}
