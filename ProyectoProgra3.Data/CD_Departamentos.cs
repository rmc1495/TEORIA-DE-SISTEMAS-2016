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
    public class CD_Departamentos : ConexionBD
    {

        #region StoredProcedures

        string INSERTAR_DEPARTAMENTO = "sp_insertar_departamento";
        string ELIMINAR_DEPARTAMENTO = "sp_eliminar_departamento";
        string OBTENER_DEPARTAMENTO = "sp_lista_departamento";
        string ACTUALIZAR_DEPARTAMENTO = "sp_actualizar_departamentos";
        string LISTA_DEPARTAMENTO = "sp_listaTodo_departamento";

        #endregion

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

        public CD_Departamentos() : base()
        { }

        public void InsertarDepartamento(CD_Departamentos objeto)
        {
            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = INSERTAR_DEPARTAMENTO;
            resuelva.Parameters.Add(new SqlParameter("@NombreDepartamento", objeto.NombreDepartamento));
            resuelva.Parameters.Add(new SqlParameter("@IdEstado", objeto.IdEstado));
            Ejecutar(resuelva);
        }

        public void EliminarDepartamento(int ID)
        {
            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = ELIMINAR_DEPARTAMENTO;
            resuelva.Parameters.Add(new SqlParameter("@IdDepartamento", ID));
            Ejecutar(resuelva);
        }

        public DataSet ObtenerDepartamento(int ID)
        {
            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = OBTENER_DEPARTAMENTO;
            resuelva.Parameters.Add(new SqlParameter("@IdDepartamento", ID));
            return Consultar(resuelva, "UnicoDepartamento");
        }

        public void ActualizarDepartamento(CD_Departamentos objeto)
        {
            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = ACTUALIZAR_DEPARTAMENTO;
            resuelva.Parameters.Add(new SqlParameter("@IdDepartamento", objeto.IdDepartamento));
            resuelva.Parameters.Add(new SqlParameter("@NombreDepartamento", objeto.NombreDepartamento));
            resuelva.Parameters.Add(new SqlParameter("@IdEstado", objeto.IdEstado));
            Ejecutar(resuelva);
        }

        public DataSet ListarDepartamentos()
        {
            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = LISTA_DEPARTAMENTO;
            return Consultar(resuelva, "TblDepartamentos");
        }

        #endregion
    }
}
