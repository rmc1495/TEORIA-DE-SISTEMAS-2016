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
    public class CD_Puesto : ConexionBD
    {
        #region StoredProcedures

        string INSERTAR_PUESTO = "sp_AgregarPuesto";
        //string ELIMINAR_CATEGORIA = "sp_eliminar_categoria";
        string CONSULTAR_PUESTO = "sp_ConsultarPuesto";
        string CONSULTAR_PUESTO_ESPECIFICO = "sp_ConsultarPuestoEspecifico";
        //string ACTUALIZAR_CATEGORIA = "sp_actualizar_categoria";

        #endregion

        #region Variables

        private int idPuesto;
        private string descripcion;

        #endregion

        #region Propiedades

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public int IdPuesto
        {
            get { return idPuesto; }
            set { idPuesto = value; }
        }

        #endregion


        public CD_Puesto() : base()
        { }

       
        public void InsertarPuesto(CD_Puesto objeto)
        {
            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = INSERTAR_PUESTO;
            resuelva.Parameters.Add(new SqlParameter("@Descripcion", objeto.Descripcion));

            Ejecutar(resuelva);
        }
        /*
        public void EliminarCategoria(int ID)
        {
            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = ELIMINAR_CATEGORIA;
            resuelva.Parameters.Add(new SqlParameter("@IdCategoria", ID));
            Ejecutar(resuelva);
        }*/

        public DataSet ObtenerPuesto(int ID)
        {
            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = CONSULTAR_PUESTO_ESPECIFICO;
            resuelva.Parameters.Add(new SqlParameter("@id", ID));
            return Consultar(resuelva, "Tabla_Puesto");
        }
        /*
        public void ActualizarCategoria(CD_Categorias objeto)
        {
            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = ACTUALIZAR_CATEGORIA;
            resuelva.Parameters.Add(new SqlParameter("@IdCategoria", objeto.IdCategoria));
            resuelva.Parameters.Add(new SqlParameter("@Categoria", objeto.Categoria));
            resuelva.Parameters.Add(new SqlParameter("@IdEstado", objeto.IdEstado));
            Ejecutar(resuelva);
        }*/

        public DataSet ListarPuestos()
        {
            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = CONSULTAR_PUESTO;
            return Consultar(resuelva, "TblPuestos");
        }
        

    }
}
