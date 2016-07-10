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
    public class CD_Categorias : ConexionBD
    {

        #region StoredProcedures

        string INSERTAR_CATEGORIA = "sp_insertar_categoria";
        string ELIMINAR_CATEGORIA = "sp_eliminar_categoria";
        string OBTENER_CATEGORIA = "sp_lista_categoria";
        string ACTUALIZAR_CATEGORIA = "sp_actualizar_categoria";
        string LISTA_CATEGORIA = "sp_listaTodo_categoria";

        #endregion

        #region Variables

        private int idCategoria;
        private string categoria;
        private char idEstado;

        #endregion

        #region Propiedades

        public int IdCategoria
        {
            get { return idCategoria; }
            set { idCategoria = value; }
        }
        public string Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }
        public char IdEstado
        {
            get { return idEstado; }
            set { idEstado = value; }
        }
        #endregion

         #region Metodos

        public CD_Categorias( ) : base( )
        { }

        public void InsertarCategoria(CD_Categorias objeto)
        {
            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = INSERTAR_CATEGORIA;
            resuelva.Parameters.Add(new SqlParameter("@Categoria", objeto.Categoria));
            resuelva.Parameters.Add(new SqlParameter("@IdEstado", objeto.IdEstado));
            Ejecutar(resuelva);
        }

        public void EliminarCategoria(int ID)
        {
            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = ELIMINAR_CATEGORIA;
            resuelva.Parameters.Add(new SqlParameter("@IdCategoria", ID));
            Ejecutar(resuelva);
        }

        public DataSet ObtenerCategoria(int ID)
        {
            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = OBTENER_CATEGORIA;
            resuelva.Parameters.Add(new SqlParameter("@IdCategoria", ID));
            return Consultar(resuelva, "UnicaCategoria");
        }

        public void ActualizarCategoria(CD_Categorias objeto)
        {
            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = ACTUALIZAR_CATEGORIA;
            resuelva.Parameters.Add(new SqlParameter("@IdCategoria", objeto.IdCategoria));
            resuelva.Parameters.Add(new SqlParameter("@Categoria", objeto.Categoria));
            resuelva.Parameters.Add(new SqlParameter("@IdEstado", objeto.IdEstado));
            Ejecutar(resuelva);
        }

        public DataSet ListarCategorias()
        {
            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = LISTA_CATEGORIA;
            return Consultar(resuelva, "TblCategorias");
        }

     /*   public  List<CD_Estados> ObtenerListaEstadosCategorias()
        { 
       
        List<CD_Estados> _lista = new List<CD_Estados>();
        ConexionBD con = new ConexionBD();

        SqlConnection conexion = ConexionBD.obtenerconexionListas();

        SqlCommand _comando = new SqlCommand("select IdEstado, Descripcion from T_Estados", conexion);
        SqlDataReader _reader = _comando.ExecuteReader();
            while(_reader.Read())
            {
                CD_Estados pEstado = new CD_Estados();

                pEstado.IdEstado = _reader.GetChar(0);
                pEstado.Descripcion = _reader.GetString(1);

                _lista.Add(pEstado);
            }
            return _lista;
        }*/

        #endregion


    }
}
