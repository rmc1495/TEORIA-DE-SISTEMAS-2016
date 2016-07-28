using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace ProyectoProgra3.ProyectoCD
{
    public class ConexionBD
    {

        //Variables de cadena de conexion a BD

        private string _cadenaConexion;
        private SqlConnection _cnx;

        //Propiedades

        public string CadenaConexion
        {
            get { return _cadenaConexion; }
        }

        //Constructor

        public ConexionBD()
        {
            ObtenerConexion();
        }

        //Metodos

        public string ObtenerConexion()
        {
// Type or member is obsolete
                              // _cadenaConexion = ConfigurationManager.ConnectionStrings["cadenadeconexion"].ConnectionString; //ese llamado una conectionstring no app setting por lo que no funciona si se usa en el app config actual
            _cadenaConexion = ConfigurationSettings.AppSettings["connectionString"];
 // Type or member is obsolete
            return _cadenaConexion;
        }


        public void Ejecutar(SqlCommand comando)
        {
            try
            {
                using (_cnx = new SqlConnection(CadenaConexion))
                {
                    _cnx.Open();
                    comando.Connection = _cnx;
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally 
            {
                if (_cnx != null)
                    _cnx.Dispose();
            }
        }

        public DataSet Consultar(SqlCommand comando, string nombreTabla)
        {
            SqlDataAdapter _adaptador;
            DataSet _resultado = new DataSet();

            try
            {
                using (_cnx = new SqlConnection(_cadenaConexion))
                {
                    _cnx.Open();

                    comando.Connection = _cnx;
                    comando.CommandType = CommandType.StoredProcedure;

                    _adaptador = new SqlDataAdapter(comando);
                    _adaptador.Fill(_resultado, nombreTabla);

                    _cnx.Close();
                }
                return _resultado;
            }
            catch (System.Exception ex)
            {
                throw  ex;
            }
            finally
            {
                if (_cnx != null)
                    _cnx.Dispose();
            }
        }

        public static SqlConnection obtenerconexionListas()
        {
            SqlConnection conexion = new SqlConnection("Data source = localhost; Initial Catalog = DB_TSistemas;"
                + "Integrated Security = True");
            conexion.Open();
            return conexion;
        }

        public DataSet ConsultarFiltros(SqlCommand comando, string nombreTabla)
        {
            SqlDataAdapter _adaptador;
            DataSet _resultado = new DataSet();

            try
            {
                using (_cnx = new SqlConnection(_cadenaConexion))
                {
                    _cnx.Open();

                    comando.Connection = _cnx;
                    comando.CommandType = CommandType.Text;

                    _adaptador = new SqlDataAdapter(comando);
                    _adaptador.Fill(_resultado, nombreTabla);

                    _cnx.Close();
                }
                return _resultado;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (_cnx != null)
                    _cnx.Dispose();
            }
        }

    }
}
