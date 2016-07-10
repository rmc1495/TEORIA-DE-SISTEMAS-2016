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
    public class CD_Proveedores : ConexionBD
    {

        #region stored Procedures
        string INSERTAR_PROVEEDOR = "sp_insertar_proveedores";
        string ELIMINAR_PROVEEDOR = "sp_eliminar_proveedores";
        string OBTENER_PROVEEDOR = "sp_lista_proveedores";
        string LISTA_PROVEEDOR = "sp_listaTodo_proveedores";
        string ACTUALIZAR_PROVEEDOR = "sp_actualizar_proveedores";
        #endregion

        #region Variables

        private string idProveedor;
        private string nombre;
        private string direccion;
        private string telefono;
        private char idEstado;

        #endregion;

        #region Propiedades

        public string IdProveedor
        {
            get { return idProveedor; }
            set { idProveedor = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }

        }
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }

        }
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }


        }
        public char IdEstado
        {
            get { return idEstado; }
            set { idEstado = value; }

        }
        #endregion

        #region metodos

        public CD_Proveedores(): base()
        { }

        public void InsertarProveedor(CD_Proveedores objeto)
        {

            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = INSERTAR_PROVEEDOR;
            resuelva.Parameters.Add(new SqlParameter("@IdProveedor", objeto.IdProveedor));
            resuelva.Parameters.Add(new SqlParameter("@Nombre", objeto.Nombre));
            resuelva.Parameters.Add(new SqlParameter("@Direccion", objeto.Direccion));
            resuelva.Parameters.Add(new SqlParameter("@Telefono", objeto.Telefono));
            resuelva.Parameters.Add(new SqlParameter("@IdEstado", objeto.IdEstado));
            Ejecutar(resuelva);
        }

        public DataSet ListarProveedores()
        {
            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = LISTA_PROVEEDOR;
            return Consultar(resuelva, "TblProveedores");

        }
        public void EliminarProveedores(string Id)
        {
            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = ELIMINAR_PROVEEDOR;
            resuelva.Parameters.Add(new SqlParameter("@IdProveedor", Id));
            Ejecutar(resuelva);
        }
        public DataSet ObtenerProveedores(string Id)
        {
            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = OBTENER_PROVEEDOR;
            resuelva.Parameters.Add(new SqlParameter("@IdProveedor", Id));
            return Consultar(resuelva, "UnicoProveedor");
        }

        public void ActualizarProveedor(CD_Proveedores objeto)
        {
            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = ACTUALIZAR_PROVEEDOR;
            resuelva.Parameters.Add(new SqlParameter("@IdProveedor", objeto.IdProveedor));
            resuelva.Parameters.Add(new SqlParameter("@Nombre", objeto.Nombre));
            resuelva.Parameters.Add(new SqlParameter("@Direccion", objeto.Direccion));
            resuelva.Parameters.Add(new SqlParameter("@Telefono", objeto.Telefono));
            resuelva.Parameters.Add(new SqlParameter("@IdEstado", objeto.IdEstado));
            Ejecutar(resuelva);
        }

        public DataSet FiltrarProveedor(string tipo, string param)
        {
            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = String.Format("select * from T_Proveedores where {0} like '{1}%' ", tipo, param);
            return ConsultarFiltros(resuelva, "filtrarproveedor");
        }
        #endregion


    }
}
