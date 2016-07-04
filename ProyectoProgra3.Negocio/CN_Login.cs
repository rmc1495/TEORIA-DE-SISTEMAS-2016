using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProyectoProgra3.ProyectoCD;
using System.Data;

namespace ProyectoProgra3.ProyectoCN
{
    public class CN_Login
    {

        
            /// Metodo inicio de sesion capa BU
            /// recibe por parametros el strNombre y el strPass
            /// y los envia a ser verificados en la capa DA para ver
            /// si se encuentran en la BD
            /// si lo encuentra devuelve una lista tipo Usuario
            /// para cargarla en el inicio de sesion

            public DataTable BUselectUsario(string strNombre_, string strPass_)
            {
                DataTable ListUser2 = new DataTable();
                ListUser2 = ProyectoCD.CD_Login.InicioSecion(strNombre_, strPass_);
                return ListUser2;
            }
            //____________________________________________

            //este metodo aumeta los intentos fallidos de login
            public int AumentaIntentos(string strNombre_)
            {
                int retorno = ProyectoCD.CD_Login.AumentaIntentos(strNombre_);
                return retorno;
            }//fin del metodo AumentaIntentos

            //Este metodo se utiliza para traer los datos de recuperacion de contraseña
            //recibe por parámetro el usuario
            public DataTable RecuperarContraseña(string strNombre)
            {
                DataTable ListDatos = new DataTable();
                ListDatos = ProyectoCD.CD_Login.RecuperarContraseña(strNombre);
                return ListDatos;
            }

            public DataTable CargarId(string strNombre)
            {
                DataTable ListDatos = new DataTable();
                ListDatos = ProyectoCD.CD_Login.CargarId(strNombre);
                return ListDatos;
            }

            //este metodo borra los intentos fallidos de login
            public int BorraIntentos(string strNombre_)
            {
                int retorno = ProyectoCD.CD_Login.BorraIntentos(strNombre_);
                return retorno;
            }//fin del metodo BorraIntentos

            //este metodo trae los datos del usuario por un id
            public DataTable InfoUser(int Id)
            {
                DataTable ListDatos = new DataTable();
                ListDatos = ProyectoCD.CD_Login.InfoUser(Id);
                return ListDatos;
            }

        
    }
}
