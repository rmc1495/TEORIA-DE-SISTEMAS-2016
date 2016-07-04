using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace ProyectoProgra3.ProyectoCN
{
   public class CN_Empleados
    {

        #region Variables

        private string idEmpleado;
        private string cedula;
        private string nombre;
        private string apellidos;
        private string direccion;
        private int edad;
        private string telefono;
        private int idTipoEmpleado;
        private int idDepartamento;
        private char idEstado;

        #endregion

        #region Propiedades

        public string IdEmpleado
        {
            get { return idEmpleado; }
            set { idEmpleado = value; }
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
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        public int IdTipoEmpleado
        {
            get { return idTipoEmpleado; }
            set { idTipoEmpleado = value; }
        }
        public int IdDepartamento
        {
            get { return idDepartamento; }
            set { idDepartamento = value; }
        }
        public char IdEstado
        {
            get { return idEstado; }
            set { idEstado = value; }
        }
        #endregion

        #region Metodos

        public void GuardarEmpelado(CN_Empleados emp)
        {
            ProyectoCD.CD_Empleados capa = new ProyectoCD.CD_Empleados();
            capa.IdEmpleado = emp.IdEmpleado;
            capa.Cedula = emp.Cedula;
            capa.Nombre = emp.Nombre;
            capa.Apellidos = emp.Apellidos;
            capa.Direccion = emp.Direccion;
            capa.Edad = emp.Edad;
            capa.Telefono = emp.Telefono;
            capa.IdTipoEmpleado = emp.IdTipoEmpleado;
            capa.IdDepartamento = emp.IdDepartamento;
            capa.IdEstado = emp.IdEstado;
            capa.InsertarEmpleado(capa);
        }

        public void ActualizarEmpleado(CN_Empleados emp)
        {
            ProyectoCD.CD_Empleados capa = new ProyectoCD.CD_Empleados();
            capa.IdEmpleado = emp.IdEmpleado;
            capa.Cedula = emp.Cedula;
            capa.Nombre = emp.Nombre;
            capa.Apellidos = emp.Apellidos;
            capa.Direccion = emp.Direccion;
            capa.Edad = emp.Edad;
            capa.Telefono = emp.Telefono;
            capa.IdTipoEmpleado = emp.IdTipoEmpleado;
            capa.IdDepartamento = emp.IdDepartamento;
            capa.IdEstado = emp.IdEstado;
            capa.ActualizarEmpleado(capa);
        }

        public DataSet ListarEmpleados()
        {
            ProyectoCD.CD_Empleados capa = new ProyectoCD.CD_Empleados();
            return capa.ListarEmpleados();
        }

        public DataSet BuscarEmpelados(ref CN_Empleados emp)
        {
            ProyectoCD.CD_Empleados capa = new ProyectoCD.CD_Empleados();
            DataSet obtenerDts = capa.ObtenerEmpelado(emp.IdEmpleado);
            return obtenerDts;
        }

        public void EliminarEmpleado(ref CN_Empleados emp)
        {
            ProyectoCD.CD_Empleados capa = new ProyectoCD.CD_Empleados();
            capa.EliminarEmpleado(capa.IdEmpleado = emp.IdEmpleado);
        }

        public DataSet FiltEmpleados(string tipo, string param)
        {
            ProyectoCD.CD_Empleados capa = new ProyectoCD.CD_Empleados();
            DataSet obtenerDts = capa.FiltrarEmpleados(tipo, param);
            return obtenerDts;
        }
        #endregion

    }
}
