using ProyectoProgra3.ProyectoCD;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ProyectoProgra3.ProyectoCN.Mantenimiento.Inventario_y_Proveedor
{
    public class CN_Marca:ConexionBD
    {
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

        public void GuardarMarca(CN_Marca marca)
        {
            ProyectoCD.Mantenimiento.Inventario_y_Proveedores.CD_Marca capa = new ProyectoCD.Mantenimiento.Inventario_y_Proveedores.CD_Marca();
            capa.Marca = marca.Marca;
            capa.InsertarMarca(capa);
        }

        public DataSet BuscarMarca(ref CN_Marca marc)
        {
            ProyectoCD.Mantenimiento.Inventario_y_Proveedores.CD_Marca capa= new ProyectoCD.Mantenimiento.Inventario_y_Proveedores.CD_Marca();
            DataSet obtenerDts = capa.ObtenerMarca(marc.Marca);
            return obtenerDts;

        }

        public DataSet BuscarMarcas(ref CN_Marca marc)
        {
            ProyectoCD.Mantenimiento.Inventario_y_Proveedores.CD_Marca capa = new ProyectoCD.Mantenimiento.Inventario_y_Proveedores.CD_Marca();
            DataSet obtenerDats = capa.ObtenerTodos();
            return obtenerDats;

        }

    }
}
