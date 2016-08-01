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
        private string metodo_de_Pago;

        private int int_IdEmpleado;
        private int int_IdCliente;
        private double mny_Total;
        private DateTime dtm_Fecha;

        private string int_IdFactura;
        private string int_Linea;
        private string int_IdArticulo;
        private string int_IdServicio;
        private string int_Cantidad;
        private string mny_Monto;
        private string mny_Impuesto;
        private string mny_Descuento;

        #endregion

        #region Propiedades
        public DataTable DetalleFactura
        {
            get { return detalleFactura; }
            set { detalleFactura = value; }
        }
        public string Metodo_de_Pago
        {
            get { return metodo_de_Pago; }
            set { metodo_de_Pago = value; }
        }
        public int Int_IdEmpleado
        {
            get { return int_IdEmpleado; }
            set { int_IdEmpleado = value; }
        }
        public int Int_IdCliente
        {
            get { return int_IdCliente; }
            set { int_IdCliente = value; }
        }
        public double Mny_Total
        {
            get { return mny_Total; }
            set { mny_Total = value; }
        }
        public DateTime Dtm_Fecha
        {
            get { return dtm_Fecha; }
            set { dtm_Fecha = value; }
        }
        public string Int_IdFactura
        {
            get { return int_IdFactura; }
            set { int_IdFactura = value; }
        }
        public string Int_Linea
        {
            get { return int_Linea; }
            set { int_Linea = value; }
        }
        public string Int_IdArticulo
        {
            get { return int_IdArticulo; }
            set { int_IdArticulo = value; }
        }
        public string Int_IdServicio
        {
            get { return int_IdServicio; }
            set { int_IdServicio = value; }
        }
        public string Int_Cantidad
        {
            get { return int_Cantidad; }
            set { int_Cantidad = value; }
        }
        public string Mny_Monto
        {
            get { return mny_Monto; }
            set { mny_Monto = value; }
        }
        public string Mny_Impuesto
        {
            get { return mny_Impuesto; }
            set { mny_Impuesto = value; }
        }
        public string Mny_Descuento
        {
            get { return mny_Descuento; }
            set { mny_Descuento = value; }
        }

        #endregion

        #region Metodos

        public CD_Ventas( ) : base( )
        { }

        public DataSet BuscarArticulo(string param)
        {
            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = String.Format("select tbl_Articulo.vrch_Descripion, tbl_Articulo.mny_Precio From tbl_Articulo where tbl_Articulo.Int_IdArticulo = {0}", param);
            return ConsultarFiltros(resuelva, "dbo.tbl_Articulo");
        }

        public DataSet BuscarServicio(string param)
        {
            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = String.Format("select tbl_Servicio.vrch_Descripcion, tbl_Servicio.mny_Precio From tbl_Servicio where tbl_Servicio.Int_IdServicio = {0}", param);
            return ConsultarFiltros(resuelva, "dbo.tbl_Servicio");
        }
        public DataSet InsertarFacturayDevolverValor(CD_Ventas objeto)
        { 
            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = String.Format("INSERT INTO tbl_Factura (int_IdEmpleado,int_IdCliente,mny_Total,dtm_Fecha) VALUES ({0},{1},{2},'{3}') SELECT SCOPE_IDENTITY(tbl_Factura)", objeto.int_IdEmpleado, objeto.int_IdCliente, objeto.mny_Total, objeto.dtm_Fecha);
            //Ejecutar(resuelva);
            return ConsultarFiltros(resuelva, "dbo.tbl_Factura");
        }
        public DataSet ConsultarCliente(string param)
        {
            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = String.Format("Select int_IdCliente,vrch_Nombre From tbl_Cliente where vrch_NumCedula = {0}", param);
            return ConsultarFiltros(resuelva, "dbo.tbl_Cliente");
        }
        public void AgregarDetallesFactura(CD_Ventas objeto)
        {
            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = String.Format("INSERT INTO tbl_DetalleFactura (int_IdDetalleFactura,Int_IdFactura,Int_Linea,Int_IdArticulo,Int_IdServicio,Int_Cantidad,Mny_Monto,Mny_Impuesto,int_Descuento) VALUES ({0},{1},{2},{3},{4},{5},{6},{7},{8})", objeto.int_IdEmpleado, objeto.int_IdCliente, objeto.mny_Total, objeto.dtm_Fecha);        
        }

        #endregion
    }
}
