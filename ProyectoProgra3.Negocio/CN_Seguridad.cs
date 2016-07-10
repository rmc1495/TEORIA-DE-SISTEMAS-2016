using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using ProyectoProgra3.ProyectoCD;

namespace ProyectoProgra3.ProyectoCN
{
    public class CN_Seguridad
    {
        //recibe por parámetro el usuario y trae la informacion de los Menu habilitados
        public DataTable SeguridadMenu(int iduser)
        {
            DataTable ListDatos = new DataTable();
            ListDatos = ProyectoCD.CD_Seguridad.SeguridadMenu(iduser);
            return ListDatos;
        }//fin metodo SeguridadMenu

    }
}
