using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace ProyectoProgra3.ProyectoCN
{
     public class CN_Clientes
    {

        #region Variables

        private string idCliente;
        private string cedula;
        private string nombre;
        private string apellidos;
        private string telefono;
        private int idTipoCliente;
        private char idEstado;

        #endregion

        #region Propiedades

        public string IdCliente
        {
            get { return idCliente; }
            set { idCliente = value; }
        }
        public string Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        public int IDTipoCliente
        {
            get { return idTipoCliente; }
            set { idTipoCliente = value; }
        }
        public char IDEstado
        {
            get { return idEstado; }
            set { idEstado = value; }
        }
        #endregion

        #region Metodos

        public void GuardarCliente(CN_Clientes cliente)
        {
            ProyectoCD.CD_Clientes capa = new ProyectoCD.CD_Clientes();
            capa.IdCliente = cliente.IdCliente;
            capa.Cedula = cliente.Cedula;
            capa.Nombre = cliente.Nombre;
            capa.Apellidos = cliente.Apellidos;
            capa.Telefono = cliente.Telefono;
            capa.IDTipoCliente = cliente.IDTipoCliente;
            capa.IDEstado = cliente.IDEstado;
            capa.InsertarCliente(capa);
        }

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

        public DataSet ListarClientes()
        {
            ProyectoCD.CD_Clientes capa = new ProyectoCD.CD_Clientes();
            return capa.ListarClientes();
        }

        public DataSet BuscarClientes( ref CN_Clientes cliente)
        {
            ProyectoCD.CD_Clientes capa = new ProyectoCD.CD_Clientes();
            DataSet obtenerDts = capa.ObtenerCliente(cliente.IdCliente);
            return obtenerDts;
        }

        public void EliminarCliente(ref CN_Clientes cliente)
        {
            ProyectoCD.CD_Clientes capa = new ProyectoCD.CD_Clientes();
            capa.EliminarCliente(capa.IdCliente = cliente.IdCliente);
        }

        public DataSet FiltrarClientes( string tipo, string param)
        {
            ProyectoCD.CD_Clientes capa = new ProyectoCD.CD_Clientes();
            DataSet obtenerDts = capa.FiltrarCliente(tipo,param);
            return obtenerDts;
        }
        #endregion

    }
}
