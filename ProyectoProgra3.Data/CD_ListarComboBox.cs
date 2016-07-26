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
    public class CD_ListarComboBox : ConexionBD
    {

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
            conexion.Close();
            return _lista;
        }

        public List<CD_TipoEmpleados> ObtenerListaTipoEmpleados()
        {

            List<CD_TipoEmpleados> _lista = new List<CD_TipoEmpleados>();
            ConexionBD con = new ConexionBD();

            SqlConnection conexion = ConexionBD.obtenerconexionListas();

            SqlCommand _comando = new SqlCommand("select IdTipoEmpleado, Tipo from T_TiposEmpleados", conexion);
            SqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                CD_TipoEmpleados pTipoEmpleados = new CD_TipoEmpleados();

                pTipoEmpleados.IdTipoEmpleado= _reader.GetInt32(0);
                pTipoEmpleados.Tipo = _reader.GetString(1);

                _lista.Add(pTipoEmpleados);
            }
            conexion.Close();
            return _lista;
        }

        public List<CD_Departamentos> ObtenerListaDepartamentos()
        {

            List<CD_Departamentos> _lista = new List<CD_Departamentos>();
            ConexionBD con = new ConexionBD();

            SqlConnection conexion = ConexionBD.obtenerconexionListas();

            SqlCommand _comando = new SqlCommand("select IdDepartamento, NombreDepartamento from T_Departamentos", conexion);
            SqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                CD_Departamentos pDepartamentos = new CD_Departamentos();

                pDepartamentos.IdDepartamento = _reader.GetInt32(0);
                pDepartamentos.NombreDepartamento = _reader.GetString(1);

                _lista.Add(pDepartamentos);
            }
            conexion.Close();
            return _lista;
        }

        public List<CD_TipoClientes> ObtenerListaTipoClientes()
        {

            List<CD_TipoClientes> _lista = new List<CD_TipoClientes>();
            ConexionBD con = new ConexionBD();

            SqlConnection conexion = ConexionBD.obtenerconexionListas();

            SqlCommand _comando = new SqlCommand("select IdTipoCliente, Descripcion from T_TiposClientes", conexion);
            SqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                CD_TipoClientes pTipoClientes = new CD_TipoClientes();

                pTipoClientes.IdTipoCliente = _reader.GetInt32(0);
                pTipoClientes.Descripcion = _reader.GetString(1);

                _lista.Add(pTipoClientes);
            }
            conexion.Close();
            return _lista;
        }

        public List<CD_Categorias> ObtenerListaCategorias()
        {

            List<CD_Categorias> _lista = new List<CD_Categorias>();
            ConexionBD con = new ConexionBD();

            SqlConnection conexion = ConexionBD.obtenerconexionListas();

            SqlCommand _comando = new SqlCommand("select IdCategoria, Categoria from T_Categorias", conexion);
            SqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                CD_Categorias pCategorias= new CD_Categorias();

                pCategorias.IdCategoria = _reader.GetInt32(0);
                pCategorias.Categoria = _reader.GetString(1);

                _lista.Add(pCategorias);
            }
            conexion.Close();
            return _lista;
        }

        //public List<CD_Marcas> ObtenerListaMarcas()
        //{

        //    List<CD_Marcas> _lista = new List<CD_Marcas>();
        //    ConexionBD con = new ConexionBD();

        //    SqlConnection conexion = ConexionBD.obtenerconexionListas();

        //    SqlCommand _comando = new SqlCommand("select IdMarca, Marca from T_Marcas", conexion);
        //    SqlDataReader _reader = _comando.ExecuteReader();
        //    while (_reader.Read())
        //    {
        //        CD_Marcas pmarcas = new CD_Marcas();

        //        pmarcas.IdMarca = _reader.GetInt32(0);
        //        pmarcas.Marca = _reader.GetString(1);

        //        _lista.Add(pmarcas);
        //    }
        //    conexion.Close();
        //    return _lista;
        //}

        //public List<CD_Proveedores> ObtenerListaProveedores()
        //{

        //    List<CD_Proveedores> _lista = new List<CD_Proveedores>();
        //    ConexionBD con = new ConexionBD();

        //    SqlConnection conexion = ConexionBD.obtenerconexionListas();

        //    SqlCommand _comando = new SqlCommand("select IdProveedor, Nombre from T_Proveedores", conexion);
        //    SqlDataReader _reader = _comando.ExecuteReader();
        //    while (_reader.Read())
        //    {
        //        CD_Proveedores pProve = new CD_Proveedores();

        //        pProve.IdProveedor = _reader.GetString(0);
        //        pProve.Nombre= _reader.GetString(1);

        //        _lista.Add(pProve);
        //    }
        //    conexion.Close();
        //    return _lista;
        //}

        /*public List<CD_Empleados> ObtenerListaIDEmpleados()
        {

            List<CD_Empleados> _lista = new List<CD_Empleados>();
            ConexionBD con = new ConexionBD();

            SqlConnection conexion = ConexionBD.obtenerconexionListas();

            SqlCommand _comando = new SqlCommand("select IdEmpleado, IdEmpleado from T_Empleados", conexion);
            SqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                CD_Empleados pIDEmp = new CD_Empleados();

                pIDEmp.IdEmpleado = _reader.GetString(0);
             //   pIDEmp.Nombre = _reader.GetString(1);

                _lista.Add(pIDEmp);
            }
            conexion.Close();
            return _lista;
        }*/

        public List<CD_Roles> ObtenerListaRol()
        {

            List<CD_Roles> _list = new List<CD_Roles>();
            ConexionBD con = new ConexionBD();

            SqlConnection conexion = ConexionBD.obtenerconexionListas();

            SqlCommand _comando = new SqlCommand("select Id_Rol, Nombre from T_Roles", conexion);
            SqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                CD_Roles pRoles = new CD_Roles();

                pRoles.IdRol = _reader.GetInt32(0);
                pRoles.Nombre= _reader.GetString(1);

                _list.Add(pRoles);
            }
            conexion.Close();
            return _list;
        }

        /*public List<cd_> ObtenerListaRol()
        {

            List<CD_Roles> _list = new List<CD_Roles>();
            ConexionBD con = new ConexionBD();

            SqlConnection conexion = ConexionBD.obtenerconexionListas();

            SqlCommand _comando = new SqlCommand("select Id_Rol, Nombre from T_Roles", conexion);
            SqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                CD_Roles pRoles = new CD_Roles();

                pRoles.IdRol = _reader.GetInt32(0);
                pRoles.Nombre = _reader.GetString(1);

                _list.Add(pRoles);
            }
            conexion.Close();
            return _list;
        }*/



    }
}
