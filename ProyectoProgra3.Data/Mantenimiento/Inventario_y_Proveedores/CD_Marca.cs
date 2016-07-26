using System.Data;
using System.Data.SqlClient;

namespace ProyectoProgra3.ProyectoCD.Mantenimiento.Inventario_y_Proveedores
{
    public class CD_Marca : ConexionBD

    {
        #region storedProcedures
        string INSERTAR_MARCA = "sp_AgregarMarca";
        string OBTENER_MARCA = "sp_ConsultarMarcaEspecifica";


        #endregion


        #region Variables y propiedades

        private string marca;

        public string Marca
        {
            get
            {
                return marca;
            }

            set
            {
                marca = value;
            }
        }
        #endregion

        #region Metodos 

        public CD_Marca() : base() { }

        public void InsertarMarca(CD_Marca objeto)
        {

            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = INSERTAR_MARCA;
            resuelva.Parameters.Add(new SqlParameter("@Marca", objeto.Marca));
            Ejecutar(resuelva);
        }

        public DataSet ObtenerMarca(string Id)
        {
            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = OBTENER_MARCA;
            resuelva.Parameters.Add(new SqlParameter("@id", Id));
            return Consultar(resuelva, "Marca");
        }
        public DataSet ObtenerTodos()
        {
            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = "select * from tbl_Marca";
            return Consultar(resuelva, "Marca");
        }

        #endregion


    }

}
