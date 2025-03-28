using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;
using System.Text.RegularExpressions;

namespace NegocioArticulo
{
    public class Negocio
    { 
        //ACCESO A DATOS
        public List<Articulo> listar()


        {
            List<Articulo> lista = new List<Articulo>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;


            try
            {
                //MOTOR DE BASE DE DATOS LOCAL
                conexion.ConnectionString = "server=(local)\\SQLEXPRESS; database=CATALOGO_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "SELECT A.Id, A.Codigo, A.Nombre, A.Descripcion, C.Descripcion AS Tipo, M.Descripcion AS Marcas, A.Precio, A.ImagenUrl, A.IdCategoria, A.IdMarca FROM ARTICULOS A, CATEGORIAS C, MARCAS M WHERE A.IdCategoria = C.Id AND A.IdMarca = M.Id; ";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Articulo aux = new Articulo();

                    aux.Id = (int)lector["Id"];
                    aux.Codigo = (string)lector["Codigo"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    aux.ImagenUrl = (string)lector["ImagenUrl"];
                    aux.Precio = (decimal)lector["Precio"];




                    aux.Marca = new Elemento();
                    aux.Marca.Descripcion= (string)lector["Marcas"];
                    aux.Marca.Id = (int)lector["IdMarca"];


                    aux.Categoria = new Elemento();
                    aux.Categoria.Descripcion = (string)lector["Tipo"];
                    aux.Categoria.Id = (int)lector["IdCategoria"];



                    lista.Add(aux);
                }



                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void agregar(Articulo nuevo)
        {
            AccesoDatos datos  = new AccesoDatos();

            try
            {
               
                datos.setearConsulta("INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, IdCategoria, IdMarca, Precio, ImagenUrl) VALUES (@Codigo, @Nombre, @Descripcion, @IdCategoria, @IdMarca, @Precio,@ImagenUrl)");
                datos.setearParametros("@Codigo", nuevo.Codigo);
                datos.setearParametros("@Nombre", nuevo.Nombre);
                datos.setearParametros("@Descripcion", nuevo.Descripcion);
                datos.setearParametros("@IdCategoria", nuevo.Categoria.Id); 
                datos.setearParametros("@IdMarca", nuevo.Marca.Id);
                datos.setearParametros("@Precio", nuevo.Precio);
                datos.setearParametros("@ImagenUrl", nuevo.ImagenUrl);

                datos.ejecutarAccion();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
        public void modificar(Articulo modificar)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update ARTICULOS set Codigo = @codigo, Nombre =@nombre, Descripcion =@descripcion, IdCategoria = @idCategoria, IdMarca = @idMarca, ImagenUrl = @imagenurl, precio = @precio Where Id = @id ");
                datos.setearParametros("@codigo", modificar.Codigo);
                datos.setearParametros("@nombre", modificar.Nombre);
                datos.setearParametros("@descripcion", modificar.Descripcion);
                datos.setearParametros("@idCategoria", modificar.Categoria.Id);
                datos.setearParametros("@idMarca", modificar.Marca.Id);
                datos.setearParametros("@imagenurl", modificar.ImagenUrl);
                datos.setearParametros("@precio", modificar.Precio);
                datos.setearParametros("@Id",modificar.Id);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void eliminar(int id)            
        {
            
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("delete from ARTICULOS where id =@Id");
                datos.setearParametros("@id",id);
                datos.ejecutarAccion();
            }
            catch (Exception ex )
            {

                throw ex;
            }
        }

        public static List<Articulo> filtrar(string campo, string criterio, string filtro)
        {
            List<Articulo> lista = new List<Articulo> ();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string consulta = "SELECT A.Id, A.Codigo, A.Nombre, A.Descripcion, C.Descripcion AS Tipo, M.Descripcion AS Marcas, A.Precio, A.ImagenUrl, A.IdCategoria, A.IdMarca FROM ARTICULOS A, CATEGORIAS C, MARCAS M WHERE A.IdCategoria = C.Id AND A.IdMarca = M.Id and ";
                //datos.setearConsulta();

                if (campo == "Precio")
                {
                    switch (criterio)
                    {
                        case "Mayor a":
                            consulta += "Precio > " + filtro;
                            break;
                        case "Menor a":
                            consulta += "Precio < " + filtro;
                            break;
                        default:
                            consulta += "Precio = " + filtro;
                            break;

                    }
                }
                else if (campo == "Nombre")
                {
                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += "A.Nombre LIKE '" + filtro + "%'";
                            break;
                        case "Termina con":
                            consulta += "A.Nombre LIKE '%" + filtro + "'";
                            break;
                        default:
                            consulta += "A.Nombre LIKE '%" + filtro + "%'";
                            break;
                    }
                }
                else
                {
                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += "A.Descripcion LIKE '" + filtro + "%'";
                            break;
                        case "Termina con":
                            consulta += "A.Descripcion LIKE '%" + filtro + "'";
                            break;
                        default:
                            consulta += "A.Descripcion LIKE '%" + filtro + "%'";
                            break;
                    }
                }
                datos.setearConsulta(consulta);
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();

                    aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];
                    aux.Precio = (decimal)datos.Lector["Precio"];



                    aux.Marca = new Elemento();
                    aux.Marca.Descripcion = (string)datos.Lector["Marcas"];
                    aux.Marca.Id = (int)datos.Lector["IdMarca"];


                    aux.Categoria = new Elemento();
                    aux.Categoria.Descripcion = (string)datos.Lector["Tipo"];
                    aux.Categoria.Id = (int)datos.Lector["IdCategoria"];



                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }

}




