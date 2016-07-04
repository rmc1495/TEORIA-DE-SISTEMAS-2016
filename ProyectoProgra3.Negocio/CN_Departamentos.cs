using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace ProyectoProgra3.ProyectoCN
{
   public class CN_Departamentos
    {

        #region Variables

        private int idDepartamento;
        private string nombreDepartamento;
        private char idEstado;

        #endregion

        #region Propiedades

        public int IdDepartamento
        {
            get { return idDepartamento; }
            set { idDepartamento = value; }
        }
        public string NombreDepartamento
        {
            get { return nombreDepartamento; }
            set { nombreDepartamento = value; }
        }
        public char IdEstado
        {
            get { return idEstado; }
            set { idEstado = value; }
        }

        #endregion

        #region Metodos

        public void GuardarDepartamento(CN_Departamentos depar)
        {
            ProyectoCD.CD_Departamentos capa = new ProyectoCD.CD_Departamentos();
            capa.NombreDepartamento = depar.NombreDepartamento;
            capa.IdEstado = depar.IdEstado;
            capa.InsertarDepartamento(capa);
        }

        public void ActualizarDepartamento(CN_Departamentos depar)
        {
            ProyectoCD.CD_Departamentos capa = new ProyectoCD.CD_Departamentos();
            capa.IdDepartamento = depar.IdDepartamento;
            capa.NombreDepartamento = depar.NombreDepartamento;
            capa.IdEstado = depar.IdEstado;
            capa.ActualizarDepartamento(capa);
        }

        public DataSet ListarDepartamentos()
        {
            ProyectoCD.CD_Departamentos capa = new ProyectoCD.CD_Departamentos();
            return capa.ListarDepartamentos();
        }

        public DataSet BuscarDepartamentos(ref CN_Departamentos Depar)
        {
            ProyectoCD.CD_Departamentos capa = new ProyectoCD.CD_Departamentos();
            DataSet obtenerDts = capa.ObtenerDepartamento(capa.IdDepartamento);
            return obtenerDts;
        }

        public void EliminarDepartamento(ref CN_Departamentos depar)
        {
            ProyectoCD.CD_Departamentos capa = new ProyectoCD.CD_Departamentos();
            capa.EliminarDepartamento(capa.IdDepartamento = depar.IdDepartamento);
        }
        #endregion


    }
}
