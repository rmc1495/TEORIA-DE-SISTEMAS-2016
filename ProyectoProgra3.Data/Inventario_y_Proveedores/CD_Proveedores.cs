using System.Data;
using System.Data.SqlClient;


namespace ProyectoProgra3.ProyectoCD.Inventario_y_Proveedores
{
    public class CD_Proveedores : ConexionBD
    {

        #region stored Procedures
        string INSERTAR_PROVEEDOR = "sp_AgregarProveedor";
        string OBTENER_PROVEEDOR = "sp_ConsultarProveedo";

        //string ACTUALIZAR_PROVEEDOR = "sp_actualizar_proveedores";
        #endregion

        #region Variables 
        private string nombre;
        private string contacto;
        private string email;
        private string telefono;
        private int idEstado;

        #endregion

        #region Propiedades
        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Contacto
        {
            get
            {
                return contacto;
            }

            set
            {
                contacto = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Telefono
        {
            get
            {
                return telefono;
            }

            set
            {
                telefono = value;
            }
        }

        public int IdEstado
        {
            get
            {
                return idEstado;
            }

            set
            {
                idEstado = value;
            }
        }
        #endregion;

        
   #region metodos

        public CD_Proveedores(): base()
        { }

        public void InsertarProveedor(CD_Proveedores objeto)
        {

            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = INSERTAR_PROVEEDOR;
            resuelva.Parameters.Add(new SqlParameter("@Nombre", objeto.Nombre));
            resuelva.Parameters.Add(new SqlParameter("@Contacto", objeto.Contacto));
            resuelva.Parameters.Add(new SqlParameter("@Email", objeto.Email));
            resuelva.Parameters.Add(new SqlParameter("@Telefono", objeto.Telefono));
            resuelva.Parameters.Add(new SqlParameter("@Estado", objeto.IdEstado));
            Ejecutar(resuelva);
        }

        public DataSet ObtenerProveedores(string Id)
        {
            SqlCommand resuelva = new SqlCommand();
            resuelva.CommandText = OBTENER_PROVEEDOR;
            resuelva.Parameters.Add(new SqlParameter("@id", Id));
            return Consultar(resuelva, "Proveedor");
        }

        //public void ActualizarProveedor(CD_Proveedores objeto)
        //{
        //    SqlCommand resuelva = new SqlCommand();
        //    resuelva.CommandText = ACTUALIZAR_PROVEEDOR;
        //    resuelva.Parameters.Add(new SqlParameter("@IdProveedor", objeto.IdProveedor));
        //    resuelva.Parameters.Add(new SqlParameter("@Nombre", objeto.Nombre));
        //    resuelva.Parameters.Add(new SqlParameter("@Direccion", objeto.Direccion));
        //    resuelva.Parameters.Add(new SqlParameter("@Telefono", objeto.Telefono));
        //    resuelva.Parameters.Add(new SqlParameter("@IdEstado", objeto.IdEstado));
        //    Ejecutar(resuelva);
        //}


        #endregion


    }
}
