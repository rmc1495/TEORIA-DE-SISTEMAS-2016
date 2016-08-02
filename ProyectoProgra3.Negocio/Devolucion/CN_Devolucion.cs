using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace ProyectoProgra3.Devolucion
{
    public class CN_Devolucion
    {
        # region Variable

        #endregion

        #region Propiedades

        #endregion

        #region Metodos
        public DataSet ListarDevolucion()
        {
            Devolucion.CD_Devolucion capa = new Devolucion.CD_Devolucion();
            return capa.ListarDevolucion();
        }
        public DataSet FiltrarDevolucion(string tipo, string param)
        {
            Devolucion.CD_Devolucion capa = new Devolucion.CD_Devolucion();
            DataSet obtenerDts = capa.FiltrarDevolucion(tipo, param);
            return obtenerDts;
        }
        public void EliminarDevolucion(string param)
        {
            Facturacion.CD_Facturacion capa = new Facturacion.CD_Facturacion();
            capa.EliminarFactura(param);
        }
        public DataSet ComboBoxNombreColumna()
        {
            Devolucion.CD_Devolucion capa = new Devolucion.CD_Devolucion();
            return capa.ComboBoxNombreColumna();
        }
        public DataSet ObtenerNombreEmpleado(string param)
        {
            Devolucion.CD_Devolucion capa = new Devolucion.CD_Devolucion();
            DataSet obtenerDts = capa.ObtenerNombreEmpleado(param);
            return obtenerDts;
        }
        #endregion

    }
}
