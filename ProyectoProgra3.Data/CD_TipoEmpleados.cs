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
    public class CD_TipoEmpleados : ConexionBD
    {

        #region StoredProcedures

        string INSERTAR_TIPO_EMPLEADOS = "sp_insertar_tiposEmpleados";
        string ELIMINAR_TIPO_EMPLEADOS = "sp_eliminar_tiposEmpleados";
        string OBTENER_TIPO_EMPLEADOS = "sp_lista_tiposEmpleados";
        string ACTUALIZAR_TIPO_EMPLEADOS = "sp_actualizar_tiposEmpleados";
        string LISTA_TIPO_EMPLEADOS = "sp_listaTodo_tiposEmpleados";

        #endregion

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

        public CD_TipoEmpleados( ) : base( )
        { }

        public void InsertarTipoEmpleados(CD_TipoEmpleados objeto)
        {
            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = INSERTAR_TIPO_EMPLEADOS;
            resuelva.Parameters.Add(new SqlParameter("@Tipo", objeto.Tipo));
            resuelva.Parameters.Add(new SqlParameter("@IdEstado", objeto.IDEstado));
            Ejecutar(resuelva);
        }

        public void EliminarTipoEmpleados(int ID)
        {
            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = ELIMINAR_TIPO_EMPLEADOS;
            resuelva.Parameters.Add(new SqlParameter("@IdTipoEmpleado", ID));
            Ejecutar(resuelva);
        }

        public DataSet ObtenerTipoEmpleados(int ID)
        {
            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = OBTENER_TIPO_EMPLEADOS;
            resuelva.Parameters.Add(new SqlParameter("@IdTipoEmpleado", ID));
            return Consultar(resuelva, "UnicoTipoEmpleados");
        }

        public void ActualizarTipoEmpleados(CD_TipoEmpleados objeto)
        {
            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = ACTUALIZAR_TIPO_EMPLEADOS;
            resuelva.Parameters.Add(new SqlParameter("@IdTipoEmpleado", objeto.IdTipoEmpleado));
            resuelva.Parameters.Add(new SqlParameter("@Tipo", objeto.Tipo));
            resuelva.Parameters.Add(new SqlParameter("@IdEstado", objeto.IDEstado));
            Ejecutar(resuelva);
        }

        public DataSet ListarTipoEmpleados()
        {
            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = LISTA_TIPO_EMPLEADOS;
            return Consultar(resuelva, "TblTipoEmpleados");
        }

        #endregion


    }
}
