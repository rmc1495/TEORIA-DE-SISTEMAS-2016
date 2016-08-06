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
            Devolucion.CD_Devolucion capa = new Devolucion.CD_Devolucion();
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
        public void AgregarDevolucion(CN_Devolucion CN)
        {
            Devolucion.CD_Devolucion CD = new Devolucion.CD_Devolucion();

            CD.Int_IdDetalleFactura = CN.Int_IdDetalleFactura;
            CD.Int_IdEmpleado = CN.Int_IdEmpleado;
            CD.Int_Cantidad = CN.Int_Cantidad;
            CD.Mny_Total = CN.Mny_Total;
            CD.Vrch_Detalle = CN.Vrch_Detalle;
            CD.AgregarDevolucion(CD);
        }
        public DataSet VerificarDetalleFactura(string param)
        {
            Devolucion.CD_Devolucion capa = new Devolucion.CD_Devolucion();
            DataSet obtenerDts = capa.VerificarDetalleFactura(param);
            return obtenerDts;
        }
        #endregion

    }
}
