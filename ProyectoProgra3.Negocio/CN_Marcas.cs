using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace ProyectoProgra3.ProyectoCN
{
    public class CN_Marcas
    {

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


        public void GuardarMarcas(CN_Marcas marca)
        {
            ProyectoCD.CD_Marcas capa = new ProyectoCD.CD_Marcas();
            capa.IdMarca = marca.IdMarca;
            capa.IdEstado = marca.IdEstado;
            capa.Marca = marca.Marca;
            capa.InsertarMarca(capa);
        }

        public DataSet ListarMarcas()
        {
            ProyectoCD.CD_Marcas capa = new ProyectoCD.CD_Marcas();
            return capa.ListarMarca();
        }

        public DataSet BuscarMarcas(ref CN_Marcas marca)
        {
            ProyectoCD.CD_Marcas capa = new ProyectoCD.CD_Marcas();
            DataSet obtenerDts = capa.ObtenerMarca(marca.IdMarca);
            return obtenerDts;


        }
        public void EliminarMarca(ref CN_Marcas marca)
        {

            ProyectoCD.CD_Marcas capa = new ProyectoCD.CD_Marcas();
            capa.EliminarMarca(capa.IdMarca = marca.IdMarca);
        }
        
        public void ActualizarMarca(CN_Marcas marca)
        {
            ProyectoCD.CD_Marcas capa = new ProyectoCD.CD_Marcas();
            capa.IdMarca = marca.IdMarca;
            capa.IdEstado = marca.IdEstado;
            capa.Marca = marca.Marca;
            capa.ActualizarMarca(capa);
        }

        public List<ProyectoCD.CD_Estados> ListarEnComboBox()
        {
            ProyectoCD.CD_Marcas capa = new ProyectoCD.CD_Marcas();
            return capa.ObtenerListaEstados();
        }

        #endregion

    }
}
