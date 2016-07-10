using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace ProyectoProgra3.ProyectoCN
{
    public class CN_Estados
    {

        #region Variables

        private char idEstado;
        private string descripcion;

        #endregion

        #region Propiedades

        public char IdEstado
        {
            get { return idEstado; }
            set { idEstado = value; }
        }
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        #endregion

        #region Metodos

        public void InsertarEstado(CN_Estados estado)
        {
            ProyectoCD.CD_Estados capa = new ProyectoCD.CD_Estados();
            capa.IdEstado = estado.IdEstado;
            capa.Descripcion = estado.Descripcion;
            capa.InsertarEstado(capa);
        }

        public void ActualizarEstado(CN_Estados estado)
        {
            ProyectoCD.CD_Estados capa = new ProyectoCD.CD_Estados();
            capa.IdEstado = estado.IdEstado;
            capa.Descripcion = estado.Descripcion;
            capa.ActualizarEstado(capa);
        }

        public DataSet ListarEstados()
        {
            ProyectoCD.CD_Estados capa = new ProyectoCD.CD_Estados();
            return capa.ListarEstados();
        }

        public DataSet BuscarEstados(ref CN_Estados estado)
        {
            ProyectoCD.CD_Estados capa = new ProyectoCD.CD_Estados();
            DataSet obtenerDts = capa.ObtenerEstado(capa.IdEstado);
            return obtenerDts;
        }

        public void EliminarEstado(ref CN_Estados estado)
        {
            ProyectoCD.CD_Estados capa = new ProyectoCD.CD_Estados();
            capa.EliminarEstado(capa.IdEstado = estado.IdEstado);
        }
        #endregion

    }
}
