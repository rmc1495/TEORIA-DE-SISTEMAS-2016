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
    public class CD_Clientes : ConexionBD
    {

        #region StoredProcedures

        string INSERTAR_CLIENTE = "sp_insertar_cliente";
        string ELIMINAR_CLIENTE = "sp_eliminar_cliente";
        string OBTENER_CLIENTE = "sp_lista_clientes";
        string ACTUALIZAR_CLIENTE = "sp_actualizar_clientes";
        string LISTA_CLIENTES = "sp_listaTodo_clientes";

        #endregion

        #region Variables

        private string idCliente;
        private string cedula;
        private string nombre;
        private string apellidos;
        private string telefono;
        private int idTipoCliente;
        private char idEstado;

        #endregion

        #region Propiedades

        public string IdCliente
        {
            get { return idCliente; }
            set { idCliente = value; }
        }
        public string Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        public int IDTipoCliente
        {
            get { return idTipoCliente; }
            set { idTipoCliente = value; }
        }
        public char IDEstado
        {
            get { return idEstado; }
            set { idEstado = value; }
        }
        #endregion

        #region Metodos

        public CD_Clientes( ) : base( )
        { }

        public void InsertarCliente(CD_Clientes objeto)
        {
            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = INSERTAR_CLIENTE;
            resuelva.Parameters.Add(new SqlParameter("@IdCliente", objeto.IdCliente));
            resuelva.Parameters.Add(new SqlParameter("@Cedula", objeto.Cedula));
            resuelva.Parameters.Add(new SqlParameter("@Nombre", objeto.Nombre));
            resuelva.Parameters.Add(new SqlParameter("@Apellidos", objeto.Apellidos));
            resuelva.Parameters.Add(new SqlParameter("@Telefono", objeto.Telefono));
            resuelva.Parameters.Add(new SqlParameter("@IdTipoCliente", objeto.IDTipoCliente));
            resuelva.Parameters.Add(new SqlParameter("@IdEstado", objeto.IDEstado));
            Ejecutar(resuelva);
        }

        public void EliminarCliente(string ID)
        {
            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = ELIMINAR_CLIENTE;
            resuelva.Parameters.Add(new SqlParameter("@IdCliente", ID));
            Ejecutar(resuelva);
        }

        public DataSet ObtenerCliente(string ID)
        {
            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = OBTENER_CLIENTE;
            resuelva.Parameters.Add(new SqlParameter("@IdCliente", ID));
            return Consultar(resuelva, "UnicoCliente");
        }

        public void ActualizarCliente(CD_Clientes objeto)
        {
            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = ACTUALIZAR_CLIENTE;
            resuelva.Parameters.Add(new SqlParameter("@IdCliente", objeto.IdCliente));
            resuelva.Parameters.Add(new SqlParameter("@Cedula", objeto.Cedula));
            resuelva.Parameters.Add(new SqlParameter("@Nombre", objeto.Nombre));
            resuelva.Parameters.Add(new SqlParameter("@Apellidos", objeto.Apellidos));
            resuelva.Parameters.Add(new SqlParameter("@Telefono", objeto.Telefono));
            resuelva.Parameters.Add(new SqlParameter("@IdTipoCliente", objeto.IDTipoCliente));
            resuelva.Parameters.Add(new SqlParameter("@IdEstado", objeto.IDEstado));
            Ejecutar(resuelva);
        }

        public DataSet ListarClientes()
        {
            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = LISTA_CLIENTES;
            return Consultar(resuelva, "TblClientes");
        }

        public DataSet FiltrarCliente(string tipo, string param)
        {
            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = String.Format("select * from T_Clientes where {0} like '{1}%' ",tipo,param);
            return ConsultarFiltros(resuelva, "filtrarCliente");
        }

        #endregion

    }
}
