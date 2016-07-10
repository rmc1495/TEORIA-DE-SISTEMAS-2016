using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace ProyectoProgra3.ProyectoCN
{
    public class CN_Proveedores
    {

        #region Variables

        private string idProveedor;
        private string nombre;
        private string direccion;
        private string telefono;
        private char idEstado;

        #endregion;

        #region Propiedades

        public string IdProveedor
        {
            get { return idProveedor; }
            set { idProveedor = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }

        }
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }

        }
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }


        }
        public char IdEstado
        {
            get { return idEstado; }
            set { idEstado = value; }

        }
        #endregion

        #region metodos
       
        public void GuardarProveedores(CN_Proveedores Prove)
        {
           ProyectoCD.CD_Proveedores capa = new ProyectoCD.CD_Proveedores();
            capa.IdProveedor= Prove.IdProveedor;
            capa.Nombre= Prove.Nombre;
            capa.Direccion= Prove.Direccion;
            capa.Telefono = Prove.Telefono;
            capa.IdEstado = Prove.IdEstado;
            capa.InsertarProveedor(capa);
        }
        public DataSet ListarProveedores()
        {
            ProyectoCD.CD_Proveedores capa = new ProyectoCD.CD_Proveedores();
            return capa.ListarProveedores();
        }
        public DataSet BuscarProveedores(ref CN_Proveedores Prove)
        {
            ProyectoCD.CD_Proveedores capa = new ProyectoCD.CD_Proveedores();
            DataSet obtenerDts = capa.ObtenerProveedores(Prove.IdProveedor);
            return obtenerDts;

        }
        public void EliminarProveedores(ref CN_Proveedores Prove)
        {

            ProyectoCD.CD_Proveedores capa = new ProyectoCD.CD_Proveedores();
            capa.EliminarProveedores(capa.IdProveedor = Prove.IdProveedor);

        }
        public void ActualizarProveedores(CN_Proveedores Prove)
        {
            ProyectoCD.CD_Proveedores capa = new ProyectoCD.CD_Proveedores();
            capa.IdProveedor = Prove.IdProveedor;
            capa.Nombre = Prove.Nombre;
            capa.Direccion = Prove.Direccion;
            capa.Telefono = Prove.Telefono;
            capa.IdEstado = Prove.IdEstado;
            capa.ActualizarProveedor(capa);
        }

        public DataSet FiltrarProv(string tipo, string param)
        {
            ProyectoCD.CD_Proveedores capa = new ProyectoCD.CD_Proveedores();
            DataSet obtenerDts = capa.FiltrarProveedor(tipo, param);
            return obtenerDts;
        }
        #endregion
    }
}
