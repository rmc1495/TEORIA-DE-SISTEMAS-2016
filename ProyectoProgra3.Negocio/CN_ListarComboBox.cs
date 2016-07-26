using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace ProyectoProgra3.ProyectoCN
{
    public class CN_ListarComboBox
    {
        public List<ProyectoCD.CD_Estados> Listar_Estados_EnComboBox()
        {
            ProyectoCD.CD_ListarComboBox capa = new ProyectoCD.CD_ListarComboBox();
            return capa.ObtenerListaEstados();
        }

        public List<ProyectoCD.CD_TipoEmpleados> Listar_TipoEmpleados_EnComboBox()
        {
            ProyectoCD.CD_ListarComboBox capa = new ProyectoCD.CD_ListarComboBox();
            return capa.ObtenerListaTipoEmpleados();
        }

        public List<ProyectoCD.CD_Departamentos> Listar_Departamentos_EnComboBox()
        {
            ProyectoCD.CD_ListarComboBox capa = new ProyectoCD.CD_ListarComboBox();
            return capa.ObtenerListaDepartamentos();
        }

        public List<ProyectoCD.CD_TipoClientes> Listar_TipoClientes_EnComboBox()
        {
            ProyectoCD.CD_ListarComboBox capa = new ProyectoCD.CD_ListarComboBox();
            return capa.ObtenerListaTipoClientes();
        }

        //public List<ProyectoCD.CD_Marcas> Listar_Marcas_EnComboBox()
        //{
        //    ProyectoCD.CD_ListarComboBox capa = new ProyectoCD.CD_ListarComboBox();
        //    return capa.ObtenerListaMarcas();
        //}

        public List<ProyectoCD.CD_Categorias> Listar_Categorias_EnComboBox()
        {
            ProyectoCD.CD_ListarComboBox capa = new ProyectoCD.CD_ListarComboBox();
            return capa.ObtenerListaCategorias();
        }

        //public List<ProyectoCD.CD_Proveedores> Listar_Proveedores_EnComboBox()
        //{
        //    ProyectoCD.CD_ListarComboBox capa = new ProyectoCD.CD_ListarComboBox();
        //    return capa.ObtenerListaProveedores();
        //}

        public List<ProyectoCD.CD_Roles> Listar_Roles_EnComboBox()
        {
            ProyectoCD.CD_ListarComboBox capa = new ProyectoCD.CD_ListarComboBox();
            return capa.ObtenerListaRol();
        }


        /*public List<ProyectoCD.CD_Empleados> Listar_IDEmpleados_EnComboBox()
        {
            ProyectoCD.CD_ListarComboBox capa = new ProyectoCD.CD_ListarComboBox();
            return capa.ObtenerListaIDEmpleados();
        }*/



    }
}
