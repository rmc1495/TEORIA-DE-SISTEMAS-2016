using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Configuration;
using ProyectoProgra3.ProyectoCD;

namespace ProyectoProgra3.Facturacion
{
    public class CD_Facturacion : ConexionBD
    {
       
        #region StoredProcedures

        string ELIMINAR_FACTURAS = "sp_EliminarFactura";
        //string FILTRA_FACTURAS = "sp_FiltraFactura";
        //string FILTRA_DETALLEFACTURA = "sp_FiltraDetalleFactura";
        //string BUSCAR_NOMBREEMPLEADO = "sp_BuscarNombreEmpleado";
        //string BUSCAR_NOMBRECLIENTE = "sp_BuscarNombreCliente";
        //string BUSCAR_NOMBREARTICULO = "sp_BuscarNombreArticulo";
        //string BUSCAR_NOMBRESERVICIO = "sp_BuscarNombreServicio";
        //string Listar_Factura = "sp_ListaFactura";
        //string Listar_DetalleFactura = "sp_ListaDetalleFactura";

        #endregion

        #region Variables
        
        private string v_id;
        private string dato;

        //private int idFactura;
        //private int idDetalleFactura;


        //private string tipo;
        //private string param;
        //private string nombreTabla;
        //private string id;       



        #endregion

        #region Propiedades

        public string V_id
        {
            get { return v_id; }
            set { v_id = value; }
        }
        public string Dato
        {
            get { return dato; }
            set { dato = value; }
        }
        //public int IdFactura
        //{
        //    get { return idFactura; }
        //    set { idFactura = value; }
        //}
        //  public int IdDetalleFactura
        //{
        //    get { return idDetalleFactura; }
        //    set { idDetalleFactura = value; }
        //}
               
        //public string Tipo
        //{
        //    get { return tipo; }
        //    set { tipo = value; }
        //}
        //public string Param
        //{
        //    get { return param; }
        //    set { param = value; }
        //}
        //public string NombreTabla
        //{
        //    get { return nombreTabla; }
        //    set { nombreTabla = value; }
        //}
        //public string Id
        //{
        //    get { return id; }
        //    set { id = value; }
        //}
        #endregion


        #region Metodos

         public CD_Facturacion( ) : base( )
        { }

         public void EliminarFactura(string id)
        {
            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = ELIMINAR_FACTURAS;
            resuelva.Parameters.Add(new SqlParameter("@int_IdFactura", id));
            Ejecutar(resuelva);
        }

         public DataSet FiltrarFactura(string tipo, string param)
        {
            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = String.Format("select * from [dbo].[tbl_Factura] where {0} like '{1}%' ", tipo, param);
            return ConsultarFiltros(resuelva, "dbo.tbl_Factura");
        }

         public DataSet FiltrarDetalleFactura(string id)
        {
            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = String.Format("select * from [dbo].[tbl_DetalleFactura] where [int_IdFactura]= {0}", id);
            return ConsultarFiltros(resuelva, "dbo.tbl_DetalleFactura");
        }

        public DataSet ComboBoxNombreColumna(string NombreTabla)
        {
            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = String.Format("SELECT name FROM sys.columns WHERE object_id = OBJECT_ID('{0}')", NombreTabla);
            return ConsultarFiltros(resuelva, NombreTabla);
        }

        public String ObtenerNombreEmpleado(string id)
        {
            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = String.Format("Select vrch_Nombre from [dbo].[tbl_Empleado] where [int_IdEmpleado] = {0}", id);
            return id;
        }

        public String ObtenerNombreCliente(string id)
        {
            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = String.Format("Select vrch_Nombre from [dbo].[tbl_Cliente] where [int_IdCliente] = {0}", id);
            return id;
        }

        public String ObtenerNombreArticulo(string id)
        {
            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = String.Format("Select vrch_Descripion from [dbo].[tbl_Articulo] where [int_IdArticulo] = {0}", id);
            return id;
        }
        public String ObtenerNombreServicio(string id)
        {
            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = String.Format("Select vrch_Descripcion from [dbo].[tbl_Servicio] where [int_IdServicio] = {0}", id);
            return id;
        }
        
        public DataSet ListarFactura()
        {
            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = String.Format("select top 50  * from [dbo].[tbl_Factura] order by [dtm_Fecha] desc");
            return ConsultarFiltros(resuelva, "dbo.tbl_DetalleFactura");
        }
        
        public DataSet ListarDetalleFactura(string id)
        {
            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = String.Format("select * from [dbo].[tbl_DetalleFactura] where [int_IdFactura] = {0}", id);
            return ConsultarFiltros(resuelva, "dbo.tbl_DetalleFactura");
        }



        #endregion

    }
}
