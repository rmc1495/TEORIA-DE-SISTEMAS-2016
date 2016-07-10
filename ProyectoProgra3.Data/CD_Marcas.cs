using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace ProyectoProgra3.ProyectoCD
{
    public class CD_Marcas : ConexionBD
    {
        #region storeProcedures
        string INSERTAR_MARCAS= "sp_insertar_marcas";
        string ELIMINAR_MARCAS = "sp_eliminar_marcas";
        string OBTENER_MARCAS = "sp_lista_marcas";
        string LISTA_MARCAS = "sp_listaTodo_marcas";
        string ACTUALIZAR_MARCAS = "sp_actualizar_marcas";
        #endregion

        #region Variables
        private string marca;
        private char idEstado;
        private int idMarca;

        #endregion;

        #region Propiedades

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public char IdEstado
        {
            get { return idEstado; }
            set { idEstado = value; }

        }

        public int IdMarca
        {
            get { return idMarca; }
            set { idMarca = value; }

        }

        #endregion

        #region metodos

        public CD_Marcas(): base()
        {  }

        public void InsertarMarca(CD_Marcas objeto)
        {

            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = INSERTAR_MARCAS;
            resuelva.Parameters.Add(new SqlParameter("@IdEstado", objeto.IdEstado));
            resuelva.Parameters.Add(new SqlParameter("@Marca ", objeto.Marca));
            Ejecutar(resuelva);
        }

        public DataSet ListarMarca()
        {
            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = LISTA_MARCAS;
            return Consultar(resuelva, "TblMarcas");

        }
        public void EliminarMarca(int ID)
        {
            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = ELIMINAR_MARCAS;
            resuelva.Parameters.Add(new SqlParameter("IdMarca", ID));
            Ejecutar(resuelva);
        }
        public DataSet ObtenerMarca(int ID)
        {
            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = OBTENER_MARCAS;
            resuelva.Parameters.Add(new SqlParameter("IdMarca", ID));
            return Consultar(resuelva, "UnicaMarca");
        }

        public void ActualizarMarca(CD_Marcas objeto)
        {
            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = ACTUALIZAR_MARCAS;
            resuelva.Parameters.Add(new SqlParameter("@IdMarca", objeto.IdMarca));
            resuelva.Parameters.Add(new SqlParameter("@IdEstado", objeto.IdEstado));
            resuelva.Parameters.Add(new SqlParameter("@Marca ", objeto.Marca));
            Ejecutar(resuelva);
        }

        public List<CD_Estados> ObtenerListaEstados()
        {

            List<CD_Estados> _lista = new List<CD_Estados>();
            ConexionBD con = new ConexionBD();

            SqlConnection conexion = ConexionBD.obtenerconexionListas();

            SqlCommand _comando = new SqlCommand("select IdEstado, Descripcion from T_Estados", conexion);
            SqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                CD_Estados pEstado = new CD_Estados();

                pEstado.IdEstado = Convert.ToChar(_reader.GetString(0));
                pEstado.Descripcion = _reader.GetString(1);

                _lista.Add(pEstado);
            }
            return _lista;
        }

        #endregion

    }
}
