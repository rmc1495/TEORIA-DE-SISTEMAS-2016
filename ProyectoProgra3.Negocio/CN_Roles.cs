using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace ProyectoProgra3.ProyectoCN
{
    public class CN_Roles
    {

        #region Variables

        private int id_rol;
        private string nombre;
        private string descripcion;
        private char idEstado;

        #endregion

        #region Propiedades

        public int IdRol
        {
            get { return id_rol; }
            set { id_rol = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string DescripcionRol
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

        public void GuardarRoles(CN_Roles roles)
        {
            ProyectoCD.CD_Roles capa = new ProyectoCD.CD_Roles();
            capa.Nombre = roles.Nombre;
            capa.Descripcion = roles.DescripcionRol;
            capa.IDEstado = roles.IDEstado;
            capa.InsertarRoles(capa);
        }

        public void ActualizarRoles(CN_Roles roles)
        {
            ProyectoCD.CD_Roles capa = new ProyectoCD.CD_Roles();
            capa.IdRol = roles.IdRol;
            capa.Nombre = roles.Nombre;
            capa.Descripcion = roles.DescripcionRol;
            capa.IDEstado = roles.IDEstado;
            capa.ActualizarRoles(capa);
        }

        public DataSet ListarRoles()
        {
            ProyectoCD.CD_Roles capa = new ProyectoCD.CD_Roles();
            return capa.ListarRoles();
        }

        public DataSet BuscarRoles(ref CN_Roles roles)
        {
            ProyectoCD.CD_Roles capa = new ProyectoCD.CD_Roles();
            DataSet obtenerDts = capa.ObtenerRoles(capa.IdRol);
            return obtenerDts;
        }

        public void EliminarRoles(ref CN_Roles roles)
        {
            ProyectoCD.CD_Roles capa = new ProyectoCD.CD_Roles();
            capa.EliminarRoles(capa.IdRol = roles.IdRol);
        }
        #endregion
    }
}
