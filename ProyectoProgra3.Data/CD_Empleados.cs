using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Configuration;

namespace ProyectoProgra3.ProyectoCD
{
    public class CD_Empleados : ConexionBD
    {

        #region StoredProcedures

        string INSERTAR_EMPLEADO = "sp_AgregarEmpleado";
        //string ELIMINAR_EMPLEADO = "sp_eliminar_empleado";
        string OBTENER_EMPLEADO = "sp_ConsultarEmpleadoEspecifico";
        //string ACTUALIZAR_EMPLEADO = "sp_actualizar_empleado";
        string LISTA_EMPLEADO = "sp_ConsultarEmpleado";

        #endregion

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

        public CD_Empleados( ) : base( )
        { }

        public void InsertarEmpleado(CD_Empleados objeto)
        {
            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = INSERTAR_EMPLEADO;
            resuelva.Parameters.Add(new SqlParameter("@Nombre", objeto.Nombre));
            resuelva.Parameters.Add(new SqlParameter("@Apellido1", objeto.Apellido1));
            resuelva.Parameters.Add(new SqlParameter("@Apellido2", objeto.Apellido2));
            resuelva.Parameters.Add(new SqlParameter("@Cedula", objeto.Cedula));
            resuelva.Parameters.Add(new SqlParameter("@IdPuesto", objeto.IdPuesto));
            resuelva.Parameters.Add(new SqlParameter("@Direccion", objeto.Direccion));
            resuelva.Parameters.Add(new SqlParameter("@Telefono", objeto.Telefono));
            resuelva.Parameters.Add(new SqlParameter("@Correo", objeto.Correo));
            resuelva.Parameters.Add(new SqlParameter("@Nacimiento", objeto.FechaNacimiento));
            resuelva.Parameters.Add(new SqlParameter("@Ingreso", objeto.FechaIngreso));
            Ejecutar(resuelva);
        }

       /* public void EliminarEmpleado(string ID)
        {
            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = ELIMINAR_EMPLEADO;
            resuelva.Parameters.Add(new SqlParameter("@IdEmpleado", ID));
            Ejecutar(resuelva);
        }*/

        public DataSet FiltrarEmpleados(string consulta)
        {
            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = OBTENER_EMPLEADO;
            resuelva.Parameters.Add(new SqlParameter("@Consulta", consulta));
            return Consultar(resuelva, "UnicoEmpleado");
        }

        /*public void ActualizarEmpleado(CD_Empleados objeto)
        {
            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = ACTUALIZAR_EMPLEADO;
            resuelva.Parameters.Add(new SqlParameter("@IdEmpleado", objeto.IdEmpleado));
            resuelva.Parameters.Add(new SqlParameter("@Cedula", objeto.Cedula));
            resuelva.Parameters.Add(new SqlParameter("@Nombre", objeto.Nombre));
            resuelva.Parameters.Add(new SqlParameter("@Apellidos", objeto.Apellidos));
            resuelva.Parameters.Add(new SqlParameter("@Direccion", objeto.Direccion));
            resuelva.Parameters.Add(new SqlParameter("@Edad", objeto.Edad));
            resuelva.Parameters.Add(new SqlParameter("@Telefono1", objeto.Telefono));
            resuelva.Parameters.Add(new SqlParameter("@IdTipoEmpleado", objeto.IdTipoEmpleado));
            resuelva.Parameters.Add(new SqlParameter("@IdDepartamento", objeto.IdDepartamento));
            resuelva.Parameters.Add(new SqlParameter("@IdEstado", objeto.IdEstado));
            Ejecutar(resuelva);
        }*/

        public DataSet ListarEmpleados()
        {
            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = LISTA_EMPLEADO;
            return Consultar(resuelva, "TblEmpleados");
        }

        /*public DataSet FiltrarEmpleados(string tipo, string param)
        {
            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = String.Format("select * from T_Empleados where {0} like '{1}%' ", tipo, param);
            return ConsultarFiltros(resuelva, "filtrarEmpleado");
        }*/

        #endregion

    }
}
