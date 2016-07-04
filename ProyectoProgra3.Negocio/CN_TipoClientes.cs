using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace ProyectoProgra3.ProyectoCN
{
    public class CN_TipoClientes
    {

        #region Variables

        private int idTipoCliente;
        private string tipoCliente;
        private string descripcion;
        private char idEstado;

        #endregion

        #region Propiedades

        public int IdTipoCliente
        {
            get { return idTipoCliente; }
            set { idTipoCliente = value; }
        }
        public string TipoCliente
        {
            get { return tipoCliente; }
            set { tipoCliente = value; }
        }
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        public char IDEstado
        {
            get { return idEstado; }
            set { idEstado = value; }
        }

        #endregion

        #region Metodos

        public void GuardarTipoClientes(CN_TipoClientes tipoCli)
        {
            ProyectoCD.CD_TipoClientes capa = new ProyectoCD.CD_TipoClientes();
            capa.TipoCliente = tipoCli.TipoCliente;
            capa.Descripcion = tipoCli.Descripcion;
            capa.IDEstado = tipoCli.IDEstado;
            capa.InsertarTipoClientes(capa);
        }

        public void ActualizarTipoClientes(CN_TipoClientes tipoCli)
        {
            ProyectoCD.CD_TipoClientes capa = new ProyectoCD.CD_TipoClientes();
            capa.IdTipoCliente = tipoCli.IdTipoCliente;
            capa.TipoCliente = tipoCli.TipoCliente;
            capa.Descripcion = tipoCli.Descripcion;
            capa.IDEstado = tipoCli.IDEstado;
            capa.ActualizarTipoClientes(capa);
        }

        public DataSet ListarTipoClientes()
        {
            ProyectoCD.CD_TipoClientes capa = new ProyectoCD.CD_TipoClientes();
            return capa.ListarTipoClientes();
        }

        public DataSet BuscarTipoClientes(ref CN_TipoClientes tipoCli)
        {
            ProyectoCD.CD_TipoClientes capa = new ProyectoCD.CD_TipoClientes();
            DataSet obtenerDts = capa.ObtenerTipoClientes(capa.IdTipoCliente);
            return obtenerDts;
        }

        public void EliminarTipoClientes(ref CN_TipoClientes tipoCli)
        {
            ProyectoCD.CD_TipoClientes capa = new ProyectoCD.CD_TipoClientes();
            capa.EliminarTipoClientes(capa.IdTipoCliente = tipoCli.IdTipoCliente);
        }
        #endregion

    }
}
