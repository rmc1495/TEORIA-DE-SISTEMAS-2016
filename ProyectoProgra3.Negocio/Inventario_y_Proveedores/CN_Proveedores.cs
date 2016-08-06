using System.Data;
 
namespace ProyectoProgra3.ProyectoCN.Inventario_y_Proveedores
{
    public class CN_Proveedores
    {

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

        public void GuardarProveedores(CN_Proveedores Prove)
        {
           ProyectoCD.Inventario_y_Proveedores.CD_Proveedores capa = new ProyectoCD.Inventario_y_Proveedores.CD_Proveedores();
            capa.Nombre= Prove. Nombre;
            capa.Contacto= Prove.Contacto;
            capa.Email= Prove.Email;
            capa.Telefono = Prove.Telefono;
            capa.IdEstado = Prove.IdEstado;
            capa.InsertarProveedor(capa);
        }

        public DataSet BuscarProveedores(string param)
        {
            ProyectoCD.Inventario_y_Proveedores.CD_Proveedores capa = new ProyectoCD.Inventario_y_Proveedores.CD_Proveedores();
            DataSet obtenerDts = capa.ObtenerProveedores(param);
            return obtenerDts;

        }

        

        //public void ActualizarProveedores(CN_Proveedores Prove)
        //{
        //    ProyectoCD.CD_Proveedores capa = new ProyectoCD.CD_Proveedores();
        //    capa.IdProveedor = Prove.IdProveedor;
        //    capa.Nombre = Prove.Nombre;
        //    capa.Direccion = Prove.Direccion;
        //    capa.Telefono = Prove.Telefono;
        //    capa.IdEstado = Prove.IdEstado;
        //    capa.ActualizarProveedor(capa);
        //}



        #endregion
    }
}
