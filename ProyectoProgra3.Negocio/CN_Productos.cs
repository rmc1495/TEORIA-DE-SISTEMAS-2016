using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace ProyectoProgra3.ProyectoCN
{
    public class CN_Productos
    {

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

        public void GuardarProductos(CN_Productos producto)
        {
            ProyectoCD.CD_Productos capa = new ProyectoCD.CD_Productos();
            capa.IdProducto = producto.IdProducto;
            capa.Nombre = producto.Nombre;
            capa.Precio= producto.Precio;
            capa.CantidadMinima = producto.CantidadMinima;
            capa.IdMarca = producto.IdMarca;
            capa.IdCategoria = producto.IdCategoria;
            capa.IdProveedor = producto.IdProveedor;
            capa.IdEstado = producto.IdEstado;
            capa.InsertarProductos(capa);
        }

        public DataSet ListarProductos()
        {
            ProyectoCD.CD_Productos capa = new ProyectoCD.CD_Productos();
            return capa.ListarProductos();
        }

        public DataSet BuscarProductos(ref CN_Productos pro)
        {
            ProyectoCD.CD_Productos capa = new ProyectoCD.CD_Productos();
            DataSet obtenerdts = capa.ObtenerProductos(pro.IdProducto);
            return obtenerdts;

        }
        public void EliminarProductos(ref CN_Productos Pro)
        {

            ProyectoCD.CD_Productos capa = new ProyectoCD.CD_Productos();
            capa.EliminarProductos(capa.IdProducto = Pro.IdProducto);

        }

        public void ActualizarProducto(CN_Productos producto)
        {
            ProyectoCD.CD_Productos capa = new ProyectoCD.CD_Productos();
            capa.IdProducto = producto.IdProducto;
            capa.Nombre = producto.Nombre;
            capa.Precio = producto.Precio;
            capa.CantidadMinima = producto.CantidadMinima;
            capa.IdMarca = producto.IdMarca;
            capa.IdCategoria = producto.IdCategoria;
            capa.IdProveedor = producto.IdProveedor;
            capa.IdEstado = producto.IdEstado;
            capa.ActualizarProducto(capa);
        }

        public DataSet FiltrarProd(string tipo, string param)
        {
            ProyectoCD.CD_Productos capa = new ProyectoCD.CD_Productos();
            DataSet obtenerDts = capa.FiltrarProducto(tipo, param);
            return obtenerDts;
        }
        #endregion

    }
}
