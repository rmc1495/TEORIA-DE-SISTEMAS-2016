using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace ProyectoProgra3.ProyectoCN
{
   public class CN_TipoEmpleados
    {

        #region Variables

        private int idTipoEmpleado;
        private string tipo;
        private char idEstado;

        #endregion

        #region Propiedades

        public int IdTipoEmpleado
        {
            get { return idTipoEmpleado; }
            set { idTipoEmpleado = value; }
        }
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        public char IDEstado
        {
            get { return idEstado; }
            set { idEstado = value; }
        }

        #endregion

        #region Metodos

        public void GuardarTipoEmpleados(CN_TipoEmpleados tipoEmp)
        {
            ProyectoCD.CD_TipoEmpleados capa = new ProyectoCD.CD_TipoEmpleados();
            capa.Tipo = tipoEmp.Tipo;
            capa.IDEstado = tipoEmp.IDEstado;
            capa.InsertarTipoEmpleados(capa);
        }

        public void ActualizarTipoEmpleados(CN_TipoEmpleados tipoEmp)
        {
            ProyectoCD.CD_TipoEmpleados capa = new ProyectoCD.CD_TipoEmpleados();
            capa.IdTipoEmpleado = tipoEmp.IdTipoEmpleado;
            capa.Tipo = tipoEmp.Tipo;
            capa.IDEstado = tipoEmp.IDEstado;
            capa.ActualizarTipoEmpleados(capa);
        }

        public DataSet ListarTipoEmpleados()
        {
            ProyectoCD.CD_TipoEmpleados capa = new ProyectoCD.CD_TipoEmpleados();
            return capa.ListarTipoEmpleados();
        }

        public DataSet BuscarTipoEmpleados(ref CN_TipoEmpleados tipoEmp)
        {
            ProyectoCD.CD_TipoEmpleados capa = new ProyectoCD.CD_TipoEmpleados();
            DataSet obtenerDts = capa.ObtenerTipoEmpleados(capa.IdTipoEmpleado);
            return obtenerDts;
        }

        public void EliminarTipoEmpleados(ref CN_TipoEmpleados tipoEmp)
        {
            ProyectoCD.CD_TipoEmpleados capa = new ProyectoCD.CD_TipoEmpleados();
            capa.EliminarTipoEmpleados(capa.IdTipoEmpleado = tipoEmp.IdTipoEmpleado);
        }
        #endregion

    }
}
