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

        #endregion

        #region Propiedades

        #endregion

        #region Metodos

        public DataSet ListarDevolucion()
        {
            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = String.Format("select top 50 int_IdDevolucion'ID' int_IdDetalleFactura'DetalleFactura' int_IdEmpleado'Empleado',int_Cantidad'Cantidad',mny_Total'Total',vrch_Detalle'Detalle ' from [dbo].[tbl_Devolucion] order by [int_IdDetalleFactura] desc");
            return ConsultarFiltros(resuelva, "dbo.tbl_Devolucion");
        }
        public DataSet FiltrarDevolucion(string tipo, string param)
        {
            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = String.Format("select int_IdFactura'ID',int_IdEmpleado'Empleado',int_IdCliente'Cliente',mny_Total'Total',dtm_Fecha'Fecha' from [dbo].[tbl_Devolucion] where {0} like '{1}%' ", tipo, param);
            return ConsultarFiltros(resuelva, "dbo.tbl_Devolucion");
        }
        public void EliminarFactura(string id)
        {
            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = String.Format("DELETE FROM [dbo].[tbl_Devolucion] WHERE int_IdDevolucion = {0}", id);
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
            resuelva.CommandText = String.Format("Select vrch_Nombre,vrch_Apellido1,vrch_Apellido2 from [dbo].[tbl_Empleado] where int_IdEmpleado = {0}", id);
            return ConsultarFiltros(resuelva, "dbo.tbl_Empleado");
        }
       
        #endregion
    }
}
