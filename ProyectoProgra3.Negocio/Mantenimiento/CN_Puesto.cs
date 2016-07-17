using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace ProyectoProgra3.ProyectoCN
{
    public class CN_Puesto
    {
        #region Variables

        private int idPuesto;
        private string descripcion;

        #endregion

        #region Propiedades

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public int IdPuesto
        {
            get { return idPuesto; }
            set { idPuesto = value; }
        }

        #endregion

        #region Metodos

        public void GuardarPuesto(CN_Puesto pues)
        {
            ProyectoCD.CD_Puesto capa = new ProyectoCD.CD_Puesto();
            capa.Descripcion = pues.Descripcion;
            capa.InsertarPuesto(capa);
        }
        /*
        public void ActualizarCliente(CN_Clientes cliente)
        {
            ProyectoCD.CD_Clientes capa = new ProyectoCD.CD_Clientes();
            capa.IdCliente = cliente.IdCliente;
            capa.Cedula = cliente.Cedula;
            capa.Nombre = cliente.Nombre;
            capa.Apellidos = cliente.Apellidos;
            capa.Telefono = cliente.Telefono;
            capa.IDTipoCliente = cliente.IDTipoCliente;
            capa.IDEstado = cliente.IDEstado;
            capa.ActualizarCliente(capa);
        }
        */
        public DataSet ListarPuestos()
        {
            ProyectoCD.CD_Puesto capa = new ProyectoCD.CD_Puesto();
            return capa.ListarPuestos();
        }

        public DataSet BuscarPuesto(ref CN_Puesto pues)
        {
            ProyectoCD.CD_Puesto capa = new ProyectoCD.CD_Puesto();
            DataSet obtenerDts = capa.ObtenerPuesto(pues.IdPuesto);
            return obtenerDts;
        }
        

        //Listo
        /*public void EliminarCliente(ref CN_Puesto cliente)
        {
            ProyectoCD.CD_Puesto capa = new ProyectoCD.CD_Puesto();
            capa.EliminarPuesto(capa.IdPuesto = cliente.IdPuesto);
        }*/


        /*
        public DataSet FiltrarClientes(string tipo, string param)
        {
            ProyectoCD.CD_Clientes capa = new ProyectoCD.CD_Clientes();
            DataSet obtenerDts = capa.FiltrarCliente(tipo, param);
            return obtenerDts;
        }*/

        #endregion

    }
}
