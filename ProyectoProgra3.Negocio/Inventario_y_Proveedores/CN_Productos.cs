using System;
using System.Data;
using System.Data.SqlTypes;

namespace ProyectoProgra3.ProyectoCN.Inventario_y_Proveedores
{
    public class CN_Productos
    {

        #region Variables


        private string descripcion;
        private SqlMoney precio;
        private int cantidad;
        private int idProveedor;
        private int idMarca;
        private int idEstado;
        private int porcentaje;
        private DateTime ingreso;
        private DateTime vencimiento;
        
        #endregion;

        #region Propiedades

        public string Descripcion
        {
            get
            {
                return descripcion;
            }

            set
            {
                descripcion = value;
            }
        }

        public SqlMoney Precio
        {
            get
            {
                return precio;
            }

            set
            {
                precio = value;
            }
        }

        public int Cantidad
        {
            get
            {
                return cantidad;
            }

            set
            {
                cantidad = value;
            }
        }

        public int IdProveedor
        {
            get
            {
                return idProveedor;
            }

            set
            {
                idProveedor = value;
            }
        }

        public int IdMarca
        {
            get
            {
                return idMarca;
            }

            set
            {
                idMarca = value;
            }
        }

        public int IdEstado
        {
            get
            {
                return idEstado;
            }

            set
            {
                idEstado = value;
            }
        }

        public DateTime Ingreso
        {
            get
            {
                return ingreso;
            }

            set
            {
                ingreso = value;
            }
        }

        public DateTime Vencimiento
        {
            get
            {
                return vencimiento;
            }

            set
            {
                vencimiento = value;
            }
        }

        public int Porcentaje
        {
            get
            {
                return porcentaje;
            }

            set
            {
                porcentaje = value;
            }
        }

        #endregion


        #region metodos

        public void GuardarProductos(CN_Productos producto)
        {
            ProyectoCD.Inventario_y_Proveedores.CD_Productos capa = new ProyectoCD.Inventario_y_Proveedores.CD_Productos();
            capa.Descripcion = producto.Descripcion;
            capa.Precio= producto.Precio;
            capa.Cantidad = producto.Cantidad;
            capa.IdProveedor = producto.IdProveedor;
            capa.IdMarca = producto.IdMarca;
            capa.IdEstado = producto.IdEstado;
            capa.Porcentaje = producto.Porcentaje;
            capa.Ingreso = producto.Ingreso;
            capa.Vencimiento = producto.Vencimiento;
            capa.InsertarProductos(capa);
        }

      
        public DataSet BuscarProductos(ref CN_Productos pro)
        {
            ProyectoCD.Inventario_y_Proveedores.CD_Productos capa = new ProyectoCD.Inventario_y_Proveedores.CD_Productos();
            DataSet obtenerdts = capa.ObtenerProductos(pro.Descripcion);
            return obtenerdts;

        }
     

        //public void ActualizarProducto(CN_Productos producto)
        //{
        //    ProyectoCD.CD_Productos capa = new ProyectoCD.CD_Productos();
        //    capa.IdProducto = producto.IdProducto;
        //    capa.Nombre = producto.Nombre;
        //    capa.Precio = producto.Precio;
        //    capa.CantidadMinima = producto.CantidadMinima;
        //    capa.IdMarca = producto.IdMarca;
        //    capa.IdCategoria = producto.IdCategoria;
        //    capa.IdProveedor = producto.IdProveedor;
        //    capa.IdEstado = producto.IdEstado;
        //    capa.ActualizarProducto(capa);
        //}

      #endregion

    }
}
