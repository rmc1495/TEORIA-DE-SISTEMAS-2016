using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace ProyectoProgra3.Ventas
{
   public class CN_Ventas
    {
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
            public DataSet BuscarArticulo(string param)
            {
                Ventas.CD_Ventas capa = new Ventas.CD_Ventas();
                DataSet obtenerDts = capa.BuscarArticulo(param);
                return obtenerDts;
            }
            public DataSet BuscarServicio(string param)
            {
                Ventas.CD_Ventas capa = new Ventas.CD_Ventas();
                DataSet obtenerDts = capa.BuscarServicio(param);
                return obtenerDts;
            }
        #endregion

    }
}
