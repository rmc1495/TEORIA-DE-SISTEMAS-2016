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

        private int idEmpleado;

        public int IdEmpleado
        {
            get { return idEmpleado; }
            set { idEmpleado = value; }
        }
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private string apellido1;

        public string Apellido1
        {
            get { return apellido1; }
            set { apellido1 = value; }
        }
        private string apellido2;

        public string Apellido2
        {
            get { return apellido2; }
            set { apellido2 = value; }
        }
        private string cedula;

        public string Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }
        private int idPuesto;

        public int IdPuesto
        {
            get { return idPuesto; }
            set { idPuesto = value; }
        }
        private string direccion;

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        private string telefono;

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        private string correo;

        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }
        private DateTime fechaNacimiento;

        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }
        private DateTime fechaIngreso;

        public DateTime FechaIngreso
        {
            get { return fechaIngreso; }
            set { fechaIngreso = value; }
        }

        #endregion


        #region Metodos

        public void GuardarEmpelado(CN_Empleados emp)
        {
            ProyectoCD.CD_Empleados capa = new ProyectoCD.CD_Empleados();
            capa.Nombre = emp.Nombre;
            capa.Apellido1= emp.Apellido1;
            capa.Apellido2 = emp.Apellido2;
            capa.Cedula = emp.Cedula;
            capa.IdPuesto = emp.IdPuesto;
            capa.Direccion = emp.Direccion;
            capa.Telefono = emp.Telefono;
            capa.Correo = emp.Correo;
            capa.FechaNacimiento = emp.FechaNacimiento;
            capa.FechaIngreso = emp.FechaIngreso;
            capa.InsertarEmpleado(capa);
        }

       /* public void ActualizarEmpleado(CN_Empleados emp)
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
        }*/

        public DataSet ListarEmpleados()
        {
            ProyectoCD.CD_Empleados capa = new ProyectoCD.CD_Empleados();
            return capa.ListarEmpleados();
        }

        /*public DataSet BuscarEmpelados(ref CN_Empleados emp)
        {
            ProyectoCD.CD_Empleados capa = new ProyectoCD.CD_Empleados();
            DataSet obtenerDts = capa.ObtenerEmpelado(emp.Id);
            return obtenerDts;
        }*/

       /* public void EliminarEmpleado(ref CN_Empleados emp)
        {
            ProyectoCD.CD_Empleados capa = new ProyectoCD.CD_Empleados();
            capa.EliminarEmpleado(capa.IdEmpleado = emp.IdEmpleado);
        }*/

        public DataSet FiltEmpleados(string consulta)
        {
            ProyectoCD.CD_Empleados capa = new ProyectoCD.CD_Empleados();
            DataSet obtenerDts = capa.FiltrarEmpleados(consulta);
            return obtenerDts;
        }
        #endregion

    }
}
