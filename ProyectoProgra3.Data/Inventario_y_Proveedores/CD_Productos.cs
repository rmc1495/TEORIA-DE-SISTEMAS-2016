using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace ProyectoProgra3.ProyectoCD.Inventario_y_Proveedores
{
    public class CD_Productos : ConexionBD
    {
        #region storeProcedures
        string INSERTAR_PRODUCTO = "sp_AgregarArticulo";
        string OBTENER_PRODUCTO = "sp_ConsultarArticulo";

        #endregion

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

        public CD_Productos() : base()
        { }

        public void InsertarProductos(CD_Productos objeto)
        {

            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = INSERTAR_PRODUCTO;
            resuelva.Parameters.Add(new SqlParameter("@Descripcion", objeto.Descripcion));
            resuelva.Parameters.Add(new SqlParameter("@Precio", objeto.Precio));
            resuelva.Parameters.Add(new SqlParameter("@Cantidad", objeto.Cantidad));
            resuelva.Parameters.Add(new SqlParameter("@IdProveedor", objeto.IdProveedor));
            resuelva.Parameters.Add(new SqlParameter("@IdMarca", objeto.IdMarca));
            resuelva.Parameters.Add(new SqlParameter("@IdEstado", objeto.IdEstado));
            resuelva.Parameters.Add(new SqlParameter("@Porcentaje", objeto.Porcentaje));
            resuelva.Parameters.Add(new SqlParameter("@Ingreso", objeto.Ingreso));
            resuelva.Parameters.Add(new SqlParameter("@Vencimiento", objeto.Vencimiento));
            Ejecutar(resuelva);
        }

                

        public DataSet ObtenerProductos(string id)
        {
            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = OBTENER_PRODUCTO;
            resuelva.Parameters.Add(new SqlParameter("@IdArticulo", id));
            return Consultar(resuelva, "Marca");
        }

      
        //public void ActualizarProducto(CD_Productos objeto)
        //{
        //    SqlCommand resuelva = new SqlCommand();
        //    resuelva.CommandText = ACTUALIZAR_PRODUCTO;
        //    resuelva.Parameters.Add(new SqlParameter("@Idproducto", objeto.IdProducto));
        //    resuelva.Parameters.Add(new SqlParameter("@Nombre", objeto.Nombre));
        //    resuelva.Parameters.Add(new SqlParameter("@Precio", objeto.Precio));
        //    resuelva.Parameters.Add(new SqlParameter("@CantidadMinima", objeto.CantidadMinima));
        //    resuelva.Parameters.Add(new SqlParameter("@IdMarca", objeto.IdMarca));
        //    resuelva.Parameters.Add(new SqlParameter("@IdCategoria", objeto.IdCategoria));
        //    resuelva.Parameters.Add(new SqlParameter("@IdProveedor", objeto.IdProveedor));
        //    resuelva.Parameters.Add(new SqlParameter("@IdEstado", objeto.IdEstado));
        //    Ejecutar(resuelva);
        //}

        //public DataSet FiltrarProducto(string tipo, string param)
        //{
        //    SqlCommand resuelva = new SqlCommand();
        //    resuelva.CommandText = String.Format("select * from T_Productos where {0} like '{1}%' ", tipo, param);
        //    return ConsultarFiltros(resuelva, "filtrarProducto");
        //}
        #endregion
    }
}
