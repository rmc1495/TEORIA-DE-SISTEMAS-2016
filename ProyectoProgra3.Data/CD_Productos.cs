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
    public class CD_Productos : ConexionBD
    {
        #region storeProcedures
        string INSERTAR_PRODUCTO = "sp_insertar_productos";
        string ELIMINAR_PRODUCTO = "sp_eliminar_productos";
        string OBTENER_PRODUCTO = "sp_lista_productos";
        string LISTA_PRODUCTO = "sp_listaTodo_productos";
        string ACTUALIZAR_PRODUCTO = "sp_actualizar_productos";
        #endregion

        #region Variables

        private string idproducto;
        private string nombre;
        private int precio;
        private int cantidadMinima;
        private int idMarca;
        private int idCategoria;
        private string idProveedor;
        private char idEstado;

        #endregion;

        #region Propiedades

        public string IdProducto
        {
            get { return idproducto; }
            set { idproducto = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }

        }

        public int Precio
        {
            get { return precio; }
            set { precio = value; }

        }
        public int CantidadMinima
        {
            get { return cantidadMinima; }
            set { cantidadMinima = value; }

        }
        public int IdMarca
        {
            get { return idMarca; }
            set { idMarca = value; }


        }
        public int IdCategoria
        {
            get { return idCategoria; }
            set { idCategoria = value; }


        }

        public string IdProveedor
        {
            get { return idProveedor; }
            set { idProveedor = value; }


        }
        public char IdEstado
        {
            get { return idEstado; }
            set { idEstado = value; }

        }


        #endregion

        #region metodos

        public CD_Productos() : base()
        { }

        public void InsertarProductos(CD_Productos objeto)
        {

            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = INSERTAR_PRODUCTO;
            resuelva.Parameters.Add(new SqlParameter("@Idproducto", objeto.IdProducto));
            resuelva.Parameters.Add(new SqlParameter("@Nombre", objeto.Nombre));
            resuelva.Parameters.Add(new SqlParameter("@Precio", objeto.Precio));
            resuelva.Parameters.Add(new SqlParameter("@CantidadMinima", objeto.CantidadMinima));
            resuelva.Parameters.Add(new SqlParameter("@IdMarca", objeto.IdMarca));
            resuelva.Parameters.Add(new SqlParameter("@IdCategoria", objeto.IdCategoria));
            resuelva.Parameters.Add(new SqlParameter("@IdProveedor", objeto.IdProveedor));
            resuelva.Parameters.Add(new SqlParameter("@IdEstado", objeto.IdEstado));
            Ejecutar(resuelva);
        }

        public DataSet ListarProductos()
        {
            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = LISTA_PRODUCTO;
            return Consultar(resuelva, "TblProductos");

        }
        public void EliminarProductos(string Id)
        {
            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = ELIMINAR_PRODUCTO;
            resuelva.Parameters.Add(new SqlParameter("@Idproducto", Id));
            Ejecutar(resuelva);
        }
        public DataSet ObtenerProductos(string Id)
        {
            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = OBTENER_PRODUCTO;
            resuelva.Parameters.Add(new SqlParameter("@Idproducto", Id));
            return Consultar(resuelva, "UnicoProducto");
        }

        public void ActualizarProducto(CD_Productos objeto)
        {
            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = ACTUALIZAR_PRODUCTO;
            resuelva.Parameters.Add(new SqlParameter("@Idproducto", objeto.IdProducto));
            resuelva.Parameters.Add(new SqlParameter("@Nombre", objeto.Nombre));
            resuelva.Parameters.Add(new SqlParameter("@Precio", objeto.Precio));
            resuelva.Parameters.Add(new SqlParameter("@CantidadMinima", objeto.CantidadMinima));
            resuelva.Parameters.Add(new SqlParameter("@IdMarca", objeto.IdMarca));
            resuelva.Parameters.Add(new SqlParameter("@IdCategoria", objeto.IdCategoria));
            resuelva.Parameters.Add(new SqlParameter("@IdProveedor", objeto.IdProveedor));
            resuelva.Parameters.Add(new SqlParameter("@IdEstado", objeto.IdEstado));
            Ejecutar(resuelva);
        }

        public DataSet FiltrarProducto(string tipo, string param)
        {
            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = String.Format("select * from T_Productos where {0} like '{1}%' ", tipo, param);
            return ConsultarFiltros(resuelva, "filtrarProducto");
        }
        #endregion
    }
}
