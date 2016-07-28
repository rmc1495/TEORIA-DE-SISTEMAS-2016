using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Configuration;
using ProyectoProgra3.ProyectoCD;

namespace ProyectoProgra3.Ventas
{
    public class CD_Ventas : ConexionBD
    {
        #region StoredProcedures

        #endregion

        #region Variable
        private DataTable detalleFactura = new System.Data.DataTable();
        private int idDetalleFactura;
        private string metodo_de_Pago;

        #endregion

        #region Propiedades
        public DataTable DetalleFactura
        {
            get { return detalleFactura; }
            set { detalleFactura = value; }
        }
        public int IdDetalleFactura
        {
            get { return idDetalleFactura; }
            set { idDetalleFactura = value; }
        }
        public string Metodo_de_Pago
        {
            get { return metodo_de_Pago; }
            set { metodo_de_Pago = value; }
        }

        #endregion

        #region Metodos

        public CD_Ventas( ) : base( )
        { }

        public DataSet BuscarArticulo(string param)
        {
            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = String.Format("select tbl_Articulo.vrch_Descripion, tbl_Articulo.mny_Precio From tbl_Articulo where tbl_Articulo.int_IdArticulo = {0}", param);
            return ConsultarFiltros(resuelva, "dbo.tbl_Articulo");
        }

        public DataSet BuscarServicio(string param)
        {
            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = String.Format("select tbl_Servicio.vrch_Descripcion, tbl_Servicio.mny_Precio From tbl_Servicio where tbl_Servicio.int_IdServicio = {0}", param);
            return ConsultarFiltros(resuelva, "dbo.tbl_Servicio");
        }
        #endregion
    }
}
