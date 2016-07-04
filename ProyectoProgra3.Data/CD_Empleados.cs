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

        string INSERTAR_EMPLEADO = "sp_insertar_empleado";
        string ELIMINAR_EMPLEADO = "sp_eliminar_empleado";
        string OBTENER_EMPLEADO = "sp_lista_empleado";
        string ACTUALIZAR_EMPLEADO = "sp_actualizar_empleado";
        string LISTA_EMPLEADO = "sp_listaTodo_empleado";

        #endregion

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
            set { idEmpleado = value;}
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

        public CD_Empleados( ) : base( )
        { }

        public void InsertarEmpleado(CD_Empleados objeto)
        {
            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = INSERTAR_EMPLEADO;
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
        }

        public void EliminarEmpleado(string ID)
        {
            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = ELIMINAR_EMPLEADO;
            resuelva.Parameters.Add(new SqlParameter("@IdEmpleado", ID));
            Ejecutar(resuelva);
        }

        public DataSet ObtenerEmpelado(string ID)
        {
            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = OBTENER_EMPLEADO;
            resuelva.Parameters.Add(new SqlParameter("@IdEmpleado", ID));
            return Consultar(resuelva, "UnicoEmpleado");
        }

        public void ActualizarEmpleado(CD_Empleados objeto)
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
        }

        public DataSet ListarEmpleados()
        {
            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = LISTA_EMPLEADO;
            return Consultar(resuelva, "TblEmpleados");
        }

        public DataSet FiltrarEmpleados(string tipo, string param)
        {
            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = String.Format("select * from T_Empleados where {0} like '{1}%' ", tipo, param);
            return ConsultarFiltros(resuelva, "filtrarEmpleado");
        }

        #endregion

    }
}
