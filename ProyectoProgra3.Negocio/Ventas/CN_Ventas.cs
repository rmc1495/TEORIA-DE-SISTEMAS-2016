﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace ProyectoProgra3.Ventas
{
   public class CN_Ventas
    {
        #region Variable
       private static DataTable detalleFactura = new System.Data.DataTable();
       private static string metodo_de_Pago;

       private static int int_IdEmpleado;
       private static int int_IdCliente;
       private static double mny_Total;
       private DateTime dtm_Fecha;

       private string int_IdFactura;
       private string int_Linea;
       private string int_IdArticulo; 
       private string int_IdServicio;
       private string int_Cantidad;
       private static string mny_Monto;
       private string mny_Impuesto;
       private string mny_Descuento;

       private static string empleadoNombre;
       private static double total;
       
       private static string devolucionempleadoNombre;
       private static int devolucionempleadoID;
       private static bool loginC;

       private static bool limpiar;

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
            public string EmpleadoNombre
            {
                get { return empleadoNombre; }
                set { empleadoNombre = value; }
            }
            public double Total
            {
                get { return total; }
                set { total = value; }
            }
            public bool LoginC
            {
                get { return loginC; }
                set { loginC = value; }
            }
            public string DevolucionempleadoNombre
            {
                get { return devolucionempleadoNombre; }
                set { devolucionempleadoNombre = value; }
            }
            public int DevolucionempleadoID
            {
                get { return devolucionempleadoID; }
                set { devolucionempleadoID = value; }
            }
            public bool Limpiar
            {
                get { return limpiar; }
                set { limpiar = value; }
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
            public DataSet AgregarFacturayDevolverValor(CN_Ventas CN)
            {
                Ventas.CD_Ventas CD = new Ventas.CD_Ventas();
                CD.Int_IdEmpleado = CN.Int_IdEmpleado;
                CD.Int_IdCliente = CN.Int_IdCliente;
                CD.Mny_Total = CN.Mny_Total ;
                CD.Dtm_Fecha = CN.Dtm_Fecha;
                DataSet obtenerDts = CD.InsertarFacturayDevolverValor(CD);
                return obtenerDts;
            }
            public DataSet ConsultarCliente(string param)
            {
                Ventas.CD_Ventas capa = new Ventas.CD_Ventas();
                DataSet obtenerDts = capa.ConsultarCliente(param);
                return obtenerDts;
            }
            public void AgregarDetallesFactura(CN_Ventas CN)
            {
                Ventas.CD_Ventas CD = new Ventas.CD_Ventas();

                CD.Int_IdFactura = CN.Int_IdFactura;
                CD.Int_Linea = CN.Int_Linea;
                CD.Int_IdArticulo = CN.Int_IdArticulo;
                CD.Int_IdServicio = CN.Int_IdServicio;
                CD.Int_Cantidad = CN.Int_Cantidad;
                CD.Mny_Monto = CN.Mny_Monto;
                CD.Mny_Impuesto = CN.Mny_Impuesto;
                CD.Mny_Descuento = CN.Mny_Descuento;
                CD.AgregarDetallesFactura(CD);
            }

        #endregion

    }
}
