using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace ProyectoProgra3.ProyectoCN
{
    public class CN_Categorias
    {

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

        public void GuardarCategoria(CN_Categorias cate)
        {
            ProyectoCD.CD_Categorias capa = new ProyectoCD.CD_Categorias();
            capa.Categoria = cate.Categoria;
            capa.IdEstado = cate.IdEstado;
            capa.InsertarCategoria(capa);
        }

        public void ActualizarCategorias(CN_Categorias cate)
        {
            ProyectoCD.CD_Categorias capa = new ProyectoCD.CD_Categorias();
            capa.IdCategoria = cate.IdCategoria;
            capa.Categoria = cate.Categoria;
            capa.IdEstado = cate.IdEstado;
            capa.ActualizarCategoria(capa);
        }

        public DataSet ListarCategorias()
        {
            ProyectoCD.CD_Categorias capa = new ProyectoCD.CD_Categorias();
            return capa.ListarCategorias();
        }

        public DataSet BuscarCategorias(ref CN_Categorias categorias)
        {
            ProyectoCD.CD_Categorias capa = new ProyectoCD.CD_Categorias();
            DataSet obtenerDts = capa.ObtenerCategoria(capa.IdCategoria);
            return obtenerDts;
        }

        public void EliminarCategorias(ref CN_Categorias cate)
        {
            ProyectoCD.CD_Categorias capa = new ProyectoCD.CD_Categorias();
            capa.EliminarCategoria(capa.IdCategoria = cate.IdCategoria);
        }

        public List<ProyectoCD.CD_Estados> ListarEnComboBox()
        {
            ProyectoCD.CD_Marcas capa = new ProyectoCD.CD_Marcas();
            return capa.ObtenerListaEstados();
        }
        #endregion

    }
}
