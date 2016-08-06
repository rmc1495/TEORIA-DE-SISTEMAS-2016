using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Configuration;
using ProyectoProgra3.ProyectoCD;

namespace ProyectoProgra3.Devolucion
{
   public class CD_Devolucion : ConexionBD
    {
        # region Variable

        private int int_IdDetalleFactura;
        private int int_IdEmpleado;   
        private int int_Cantidad;  
        private double mny_Total;  
        private string vrch_Detalle;

        #endregion

        #region Propiedades
        public int Int_IdDetalleFactura
        {
            get { return int_IdDetalleFactura; }
            set { int_IdDetalleFactura = value; }
        }
        public int Int_IdEmpleado
        {
            get { return int_IdEmpleado; }
            set { int_IdEmpleado = value; }
        }
        public int Int_Cantidad
        {
            get { return int_Cantidad; }
            set { int_Cantidad = value; }
        }
        public double Mny_Total
        {
            get { return mny_Total; }
            set { mny_Total = value; }
        }
        public string Vrch_Detalle
        {
            get { return vrch_Detalle; }
            set { vrch_Detalle = value; }
        }
        #endregion

        #region Metodos

        public DataSet ListarDevolucion()
        {
            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = String.Format("select top 50 int_IdDevolucion'ID', Int_IdDetalleFactura'DetalleFactura', Int_IdEmpleado'Empleado',Int_Cantidad'Cantidad',Mny_Total'Total',Vrch_Detalle'Detalle ' from [dbo].[tbl_Devolucion] order by [Int_IdDetalleFactura] desc");
            return ConsultarFiltros(resuelva, "dbo.tbl_Devolucion");
        }
        public DataSet FiltrarDevolucion(string tipo, string param)
        {
            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = String.Format("select int_IdDevolucion'ID', Int_IdDetalleFactura'DetalleFactura', Int_IdEmpleado'Empleado',Int_Cantidad'Cantidad',Mny_Total'Total',Vrch_Detalle'Detalle ' from [dbo].[tbl_Devolucion] where {0} like '{1}%' ", tipo, param);
            return ConsultarFiltros(resuelva, "dbo.tbl_Devolucion");
        }
        public DataSet EliminarFactura(string id)
        {
            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = String.Format("DELETE FROM [dbo].[tbl_Devolucion] WHERE int_IdDevolucion = {0}", id);
            return ConsultarFiltros(resuelva, "dbo.tbl_Devolucion");
        }
        public DataSet ComboBoxNombreColumna()
        {
            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = String.Format("SELECT name FROM sys.columns WHERE object_id = OBJECT_ID('tbl_Devolucion')");
            return ConsultarFiltros(resuelva, "dbo.tbl_Devolucion");
        }
        public DataSet ObtenerNombreEmpleado(string id)
        {
            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = String.Format("Select vrch_Nombre,vrch_Apellido1,vrch_Apellido2 from [dbo].[tbl_Empleado] where Int_IdEmpleado = {0}", id);
            return ConsultarFiltros(resuelva, "dbo.tbl_Empleado");
        }
        public DataSet AgregarDevolucion(CD_Devolucion objeto)
        {
            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = String.Format("INSERT INTO tbl_Devolucion (int_IdDetalleFactura,int_IdEmpleado,int_Cantidad,mny_Total,vrch_Detalle) VALUES ({0},{1},{2},{3},'{4}')", objeto.Int_IdDetalleFactura, objeto.Int_IdEmpleado, objeto.Int_Cantidad, objeto.Mny_Total, objeto.Vrch_Detalle);
            return ConsultarFiltros(resuelva, "dbo.tbl_Devolucion");
        }
        public DataSet VerificarDetalleFactura(string param)
        {
            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = String.Format("select int_IdDetalleFactura From tbl_DetalleFactura where int_IdDetalleFactura = {0}", param);
            return ConsultarFiltros(resuelva, "dbo.tbl_DetalleFactura");
        }
        #endregion
    }
}
