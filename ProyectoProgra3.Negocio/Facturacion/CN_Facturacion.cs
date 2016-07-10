using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;

namespace ProyectoProgra3.Facturacion
{
    public class CN_Facturacion
    {

        #region Variables

        private string v_id;


        #endregion

        #region Propiedades

        public string V_id
        {
            get { return v_id; }
            set { v_id = value; }
        }
        
        #endregion

        #region Metodos

        public void EliminarFactura(ref Facturacion.CN_Facturacion CN)
        {
            Facturacion.CD_Facturacion capa = new Facturacion.CD_Facturacion();
            capa.EliminarFactura(capa.V_id = CN.v_id);
        }

        public DataSet FiltrarFactura(string tipo, string param)
        {
            Facturacion.CD_Facturacion capa = new Facturacion.CD_Facturacion();
            DataSet obtenerDts = capa.FiltrarFactura(tipo, param);
            return obtenerDts;
        }

        public DataSet FiltrarDetalleFactura(string tipo, string param)
        {
            Facturacion.CD_Facturacion capa = new Facturacion.CD_Facturacion();
            DataSet obtenerDts = capa.FiltrarDetalleFactura(tipo, param);
            return obtenerDts;
        }

        public DataSet ComboBoxNombreColumna(string NombreTabla)
        {
            Facturacion.CD_Facturacion capa = new Facturacion.CD_Facturacion();
            DataSet obtenerDts = capa.ComboBoxNombreColumna(NombreTabla);
            return obtenerDts;
        }

        public String ObtenerNombreEmpleado(string id)
        {
           Facturacion.CD_Facturacion capa = new Facturacion.CD_Facturacion();
           return capa.ObtenerNombreEmpleado(id);
        }

        public String ObtenerNombreCliente(string id)
        {
            Facturacion.CD_Facturacion capa = new Facturacion.CD_Facturacion();
            return capa.ObtenerNombreCliente(id);
        }

        public String ObtenerNombreArticulo(string id)
        {
            Facturacion.CD_Facturacion capa = new Facturacion.CD_Facturacion();
            return capa.ObtenerNombreArticulo(id);
        }

        public String ObtenerNombreServicio(string id)
        {
            Facturacion.CD_Facturacion capa = new Facturacion.CD_Facturacion();
            return capa.ObtenerNombreServicio(id);
        }

        public DataSet ListarFactura()
        {
            Facturacion.CD_Facturacion capa = new Facturacion.CD_Facturacion();
            return capa.ListarFactura();
        }

        public DataSet ListarDetalleFactura(string id)
        {
            Facturacion.CD_Facturacion capa = new Facturacion.CD_Facturacion();
            return capa.ListarDetalleFactura(id);
        }

        #endregion


    }
}
