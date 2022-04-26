using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

/*
     Estudiante: Karla Bricelda Aguilar González
*/

namespace Acceso_Datos
{
    public class SQL_Query
    {

        Conexion_BDSQL conexion_SQL = new Conexion_BDSQL();
        SqlCommand sql_command = new SqlCommand();

        #region MÉTODO PARA INSERTAR ARTÍCULOS A LA BASE DE DATOS EN SQL SERVER
        public void Insertar_Articulo(Articulo articulo)
        {
            try
            {
                sql_command.Connection = conexion_SQL.CerrarSQLBD();
                sql_command.Connection = conexion_SQL.Abrir_SQLBD();
                sql_command.CommandType = CommandType.Text;
                sql_command.Parameters.Clear();
                sql_command.CommandText = "INSERT into dbo.Articulo (IdArticulo,Descripcion,Activo,PrecioVendedor,PrecioFinal,CantidadDisponible) " +
                    "Values (@IdArticulo, @Descripcion, @Activo, @PrecioVendedor, @PrecioFinal, @CantidadDisponible)";
                sql_command.Parameters.AddWithValue("@IdArticulo", articulo.IdArticulo);
                sql_command.Parameters.AddWithValue("@Descripcion", articulo.Descripcion);
                sql_command.Parameters.AddWithValue("@Activo", articulo.Activo);
                sql_command.Parameters.AddWithValue("@PrecioVendedor", articulo.PrecioVendedor);
                sql_command.Parameters.AddWithValue("@PrecioFinal", articulo.PrecioFinal);
                sql_command.Parameters.AddWithValue("@CantidadDisponible", articulo.CantidadDisponible);
                sql_command.ExecuteNonQuery();
            }
            catch (SqlException m) //Captura cualquier error al tratar de escribir en la base de datos.
            {
                MessageBox.Show(m.Message, "Error al insertar los datos del artículo.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sql_command.Connection = conexion_SQL.CerrarSQLBD();
            }
        }

        #endregion

        #region MÉTODO PARA INSERTAR VENDEDORES A LA BASE DE DATOS EN SQL SERVER
        public void Insertar_Vendedor(Vendedor vendedor)
        {
            try
            {
                sql_command.Connection = conexion_SQL.CerrarSQLBD();
                sql_command.Connection = conexion_SQL.Abrir_SQLBD();
                sql_command.CommandType = CommandType.Text;
                sql_command.Parameters.Clear();
                sql_command.CommandText = "INSERT into dbo.Vendedor(Identificacion,Nombre,PrimerApellido,SegundoApellido,FechaNacimiento,Genero,FechaIngreso) " +
                    "Values (@Identificacion,@Nombre,@PrimerApellido,@SegundoApellido,@FechaNacimiento,@Genero,@FechaIngreso)";
                sql_command.Parameters.AddWithValue("@Identificacion", vendedor.Identificacion);
                sql_command.Parameters.AddWithValue("@Nombre", vendedor.Nombre);
                sql_command.Parameters.AddWithValue("@PrimerApellido", vendedor.PrimerApellido);
                sql_command.Parameters.AddWithValue("@SegundoApellido", vendedor.SegundoApellido);
                sql_command.Parameters.AddWithValue("@FechaNacimiento", vendedor.FechaNacimiento);
                sql_command.Parameters.AddWithValue("@Genero", vendedor.Genero);
                sql_command.Parameters.AddWithValue("@FechaIngreso", vendedor.FechaIngreso);
                sql_command.ExecuteNonQuery();
            }
            catch (SqlException sq)
            {
                MessageBox.Show(sq.Message, "Error al insertar datos del vendedor.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sql_command.Connection = conexion_SQL.CerrarSQLBD();
            }

        }
        #endregion

        #region MÉTODO PARA INSERTAR ÓRDENES DE COMPRA EN LA BASE DE DATOS
        public void Insertar_OrdenesCompra(OrdenCompra orden)
        {
            try
            {
                sql_command.Connection = conexion_SQL.CerrarSQLBD();
                sql_command.Connection = conexion_SQL.Abrir_SQLBD();
                sql_command.CommandType = CommandType.Text;
                sql_command.Parameters.Clear();
                sql_command.CommandText = "INSERT into dbo.OrdenCompra(IdOrden,Identificacion,Fecha) " +
                    "Values (@IdOrden,@Identificacion,@Fecha)";
                sql_command.Parameters.AddWithValue("@IdOrden", orden.IdOrdenCompra);
                sql_command.Parameters.AddWithValue("@Identificacion", orden.Identificacion);
                sql_command.Parameters.AddWithValue("@Fecha", orden.Fecha);
                sql_command.ExecuteNonQuery();
            }
            catch (SqlException sq) //Captura cualquier error al tratar de escribir en la base de datos.
            {
                MessageBox.Show(sq.Message, "Error l insertar los datos en la orden de compra.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sql_command.Connection = conexion_SQL.CerrarSQLBD();
            }
        }
        #endregion

        #region MÉTODO PARA INSERTAR ORDEN DE COMPRA DETALLE EN LA BASE DE DATOS
        public void Insertar_Detalles(OrdenCompraDetalle detalle, int IdOrden, decimal PrecioVendedor, decimal PrecioFinal, int IdDetalle)
        {
            try
            {
                sql_command.Connection = conexion_SQL.CerrarSQLBD();
                sql_command.Connection = conexion_SQL.Abrir_SQLBD();
                sql_command.CommandType = CommandType.Text;
                sql_command.Parameters.Clear();
                sql_command.CommandText = "INSERT into dbo.OrdenCompraDetalle(IdDetalle,IdOrden,IdArticulo,CantidadArticulo,PrecioVendedor,PrecioFinal) " +
                    "Values (@IdDetalle,@IdOrden,@IdArticulo,@CantidadArticulo,@PrecioVendedor,@PrecioFinal)";
                sql_command.Parameters.AddWithValue("@IdDetalle", IdDetalle);
                sql_command.Parameters.AddWithValue("@IdOrden", IdOrden);
                sql_command.Parameters.AddWithValue("@IdArticulo", detalle.IdArticulo);
                sql_command.Parameters.AddWithValue("@CantidadArticulo", detalle.Cantidad);
                sql_command.Parameters.AddWithValue("@PrecioVendedor", PrecioVendedor);
                sql_command.Parameters.AddWithValue("@PrecioFinal", PrecioFinal);
                sql_command.ExecuteNonQuery();
            }
            catch (SqlException sq) //Captura cualquier error al tratar de escribir en la base de datos.
            {
                MessageBox.Show(sq.Message, "Error al insertar detalle en Orden Compra.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sql_command.Connection = conexion_SQL.CerrarSQLBD();
            }
        }
        #endregion

        #region MÉTODO PARA REVISAR SI UN ID EXISTE EN UNA TABLA DE LA BASE DE DATOS
        public bool Existe_Id(string MiId, string Mitabla, string miCampo)
        {
            int cantidad = 0;
            try
            {
                sql_command.Connection = conexion_SQL.Abrir_SQLBD();
                sql_command.CommandType = CommandType.Text;
                sql_command.Parameters.Clear();
                sql_command.CommandText = "SELECT COUNT(*) FROM dbo." + Mitabla + " WHERE " + miCampo + " = @" + miCampo;
                sql_command.Parameters.AddWithValue("@" + miCampo, MiId);
                cantidad = (int)sql_command.ExecuteScalar();
            }
            catch (SqlException m) //Captura cualquier error al tratar de escribir en la base de datos.
            {
                MessageBox.Show(m.Message, "Error al buscar el id.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sql_command.Connection = conexion_SQL.CerrarSQLBD();

            }
            return (cantidad == 0 ? false : true);
        }
        #endregion

        #region MÉTODO PARA REVISAR SI UN ID DE TIPO INT EXISTE EN UNA TABLA DE LA BASE DE DATOS
        public bool Existe_Id_Articulo(int MiId, string Mitabla, string miCampo)
        {
            int cantidad = 0;
            try
            {
                sql_command.Connection = conexion_SQL.CerrarSQLBD();
                sql_command.Connection = conexion_SQL.Abrir_SQLBD();
                sql_command.CommandType = CommandType.Text;
                sql_command.Parameters.Clear();
                sql_command.CommandText = "SELECT COUNT(*) FROM dbo." + Mitabla + " WHERE " + miCampo + "  = @" + miCampo;
                sql_command.Parameters.AddWithValue("@" + miCampo, MiId);
                cantidad = (int)sql_command.ExecuteScalar();
            }
            catch (SqlException m) //Captura cualquier error al tratar de escribir en la base de datos.
            {
                MessageBox.Show(m.Message, "Error al buscar incidencias con el id.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sql_command.Connection = conexion_SQL.CerrarSQLBD();
            }
            return (cantidad == 0 ? false : true);
        }
        #endregion

        #region MÉTODO PARA MOSTRAR LA LISTA DE ARTÍCULOS REGISTRADOS
        public List<Articulo> Lista_Articulo()
        {
            var Lista_Articulos = new List<Articulo>();
            try
            {
                sql_command.Connection = conexion_SQL.CerrarSQLBD();
                sql_command.Connection = conexion_SQL.Abrir_SQLBD();
                sql_command.CommandType = CommandType.Text;
                sql_command.Parameters.Clear();
                sql_command.CommandText = "SELECT * FROM dbo.Articulo";
                SqlDataReader registro = sql_command.ExecuteReader();
                if (registro.HasRows)
                {
                    while (registro.Read())
                    {
                        Lista_Articulos.Add(new Articulo
                        {
                            IdArticulo = int.Parse(registro.GetValue(0).ToString()),
                            Descripcion = registro.GetValue(1).ToString(),
                            Activo = bool.Parse(registro.GetValue(2).ToString()),
                            PrecioVendedor = decimal.Parse(registro.GetValue(3).ToString()),
                            PrecioFinal = decimal.Parse(registro.GetValue(4).ToString()),
                            CantidadDisponible = int.Parse(registro.GetValue(5).ToString()),
                        });
                    }
                }
                registro.Close();
            }
            catch (SqlException m) //Captura cualquier error al tratar de escribir en la base de datos.
            {
                MessageBox.Show(m.Message, "Error al extraer los datos del artículo.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error al mostrar datos de Artículos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sql_command.Connection = conexion_SQL.CerrarSQLBD();
            }
            return Lista_Articulos;
        }
        #endregion

        #region MÉTODO PARA MOSTRAR LA LISTA DE VENDEDORES REGISTRADOS
        public List<Vendedor> Lista_Vendedores()
        {
            var List_vendedor = new List<Vendedor>();
            try
            {
                sql_command.Connection = conexion_SQL.CerrarSQLBD();
                sql_command.Connection = conexion_SQL.Abrir_SQLBD();
                sql_command.CommandType = CommandType.Text;
                sql_command.CommandText = "SELECT * FROM dbo.Vendedor";
                SqlDataReader registro = sql_command.ExecuteReader();
                if (registro.HasRows)
                {
                    while (registro.Read())
                    {
                        List_vendedor.Add(new Vendedor
                        {
                            Identificacion = registro.GetValue(0).ToString(),
                            Nombre = registro.GetValue(1).ToString(),
                            PrimerApellido = registro.GetValue(2).ToString(),
                            SegundoApellido = registro.GetValue(3).ToString(),
                            FechaNacimiento = DateTime.Parse(registro.GetValue(4).ToString()),
                            Genero = Char.Parse(registro.GetValue(5).ToString()),
                            FechaIngreso = DateTime.Parse(registro.GetValue(6).ToString())
                        });

                    }
                }
                registro.Close();
            }
            catch (SqlException m) //Captura cualquier error al tratar de escribir en la base de datos.
            {
                MessageBox.Show(m.Message, "Error al extraer los datos del vendedor.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error al mostrar datos del vendedor.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sql_command.Connection = conexion_SQL.CerrarSQLBD();
            }
            return List_vendedor;
        }
        #endregion

        #region MÉTODO PARA MOSTRAR LA LISTA DE ORDEN DE COMPRA REGISTRADA
        public List<OrdenCompra> ListaOrdenCompra()
        {
            var Lista_OrdenCompra = new List<OrdenCompra>();
            try
            {
                sql_command.Connection = conexion_SQL.CerrarSQLBD();
                sql_command.Connection = conexion_SQL.Abrir_SQLBD();
                sql_command.CommandType = CommandType.Text;
                sql_command.Parameters.Clear();
                sql_command.CommandText = "SELECT * from dbo.OrdenCompra";
                SqlDataReader registro = sql_command.ExecuteReader();
                if (registro.HasRows)
                {
                    while (registro.Read())
                    {
                        Lista_OrdenCompra.Add(new OrdenCompra
                        {
                            IdOrdenCompra = int.Parse(registro.GetValue(0).ToString()),
                            Identificacion = registro.GetValue(1).ToString(),
                            Fecha = DateTime.Parse(registro.GetValue(2).ToString()),
                        });
                    }
                }
                registro.Close();
            }
            catch (SqlException m)
            {
                MessageBox.Show(m.Message, "Error al extraer los datos la orden de compra.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error al mostrar datos de Orden de compra.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sql_command.Connection = conexion_SQL.CerrarSQLBD();
            }
            return Lista_OrdenCompra;
        }
        #endregion

        #region MÉTODO PARA VERIFICAR SI UNA TABLA DE LA BASE DE DATOS ESTÁ VACÍA
        public bool VerificarDatosExistentes(string NombreTabla)
        {
            sql_command.Connection = conexion_SQL.CerrarSQLBD();
            sql_command.Connection = conexion_SQL.Abrir_SQLBD();
            sql_command.CommandText = "Select * from dbo." + NombreTabla;
            sql_command.CommandType = CommandType.Text;
            sql_command.Parameters.Clear();
            SqlDataReader tablas = sql_command.ExecuteReader();
            if (!tablas.HasRows)
            {
                tablas.Close();
                sql_command.Connection = conexion_SQL.CerrarSQLBD();
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region  MÉTODO PARA ACTUALIZAR UN CAMPO EN LA BASE DE DATOS SEGÚN EL ID SELECCIONADO 
        public void Actualizar(string tabla, string campo_act, string dato_actualizar, int id, string nombre_id)
        {
            try
            {
                sql_command.Connection = conexion_SQL.CerrarSQLBD();
                sql_command.Connection = conexion_SQL.Abrir_SQLBD();
                sql_command.CommandType = CommandType.Text;
                sql_command.Parameters.Clear();
                sql_command.CommandText = "UPDATE " + tabla + " SET " + campo_act + " = " + dato_actualizar + " WHERE [" + nombre_id + "]" + " = " + id;
                sql_command.ExecuteNonQuery();
            }
            catch (SqlException m) //Captura cualquier error al tratar de escribir en la base de datos.
            {
                MessageBox.Show(m.Message, "Error al actualizar los datos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sql_command.Connection = conexion_SQL.CerrarSQLBD();
            }
        }

        public void Actualizar_Orden(string campo, string actualizar, int id_art, int id_orden)
        {
            try
            {
                sql_command.Connection = conexion_SQL.CerrarSQLBD();
                sql_command.Connection = conexion_SQL.Abrir_SQLBD();
                sql_command.CommandType = CommandType.Text;
                sql_command.Parameters.Clear();
                sql_command.CommandText = "UPDATE OrdenCompraDetalle SET " + campo + " = " + actualizar + " WHERE [IdArticulo]=" + id_art + " And[IdOrden] = " + id_orden;
                sql_command.ExecuteNonQuery();
            }
            catch (SqlException m) //Captura cualquier error al tratar de escribir en la base de datos.
            {
                MessageBox.Show(m.Message, "Error al actualizar los datos de la orden de compra detalle.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sql_command.Connection = conexion_SQL.CerrarSQLBD();
            }
        }
        #endregion

        #region MÉTODO PARA OBTENER UNA LISTA DE LOS ID SEGÚN LA TABLA Y CAMPO QUE SE INDIQUE
        public List<string> Lista_ID(string MiTabla, string MiCampoBuscar, string extra)
        {
            var lista_Id = new List<string>();
            try
            {
                sql_command.Connection = conexion_SQL.CerrarSQLBD();
                sql_command.CommandType = CommandType.Text;
                sql_command.Parameters.Clear();
                sql_command.CommandText = "SELECT " + MiCampoBuscar + " FROM dbo." + MiTabla + extra;
                sql_command.Connection = conexion_SQL.Abrir_SQLBD();
                SqlDataReader tabla = sql_command.ExecuteReader();
                while (tabla.Read())
                {
                    lista_Id.Add(tabla[MiCampoBuscar].ToString());
                }
                tabla.Close();
            }
            catch (SqlException m) //Captura cualquier error al tratar de escribir en la base de datos.
            {
                MessageBox.Show(m.Message, "Error al buscar lista de id en la base de datos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sql_command.Connection = conexion_SQL.CerrarSQLBD();

            }
            return lista_Id;
        }
        #endregion

        #region MÉTODO PARA OBTENER LA LISTA DE DETALLES DE LA ORDEN DE COMPRA
        public void Lista_detalle(string MiId, DataGridView MiDat)
        {
            try
            {
                sql_command.Connection = conexion_SQL.CerrarSQLBD();
                sql_command.Connection = conexion_SQL.Abrir_SQLBD();
                sql_command.CommandType = CommandType.Text;
                sql_command.CommandText = "Select  Articulo.Descripcion,OrdenCompraDetalle.IdArticulo,OrdenCompraDetalle.CantidadArticulo," +
               "OrdenCompraDetalle.PrecioVendedor,OrdenCompraDetalle.PrecioFinal from  dbo.OrdenCompraDetalle " +
               " INNER JOIN dbo.Articulo  On OrdenCompraDetalle.IdOrden =  " + MiId + "  And Articulo.IdArticulo = OrdenCompraDetalle.IdArticulo";

                SqlDataReader tabla = sql_command.ExecuteReader();
                if (tabla.HasRows)
                {
                    while (tabla.Read())
                    {
                        MiDat.Rows.Add(tabla["IdArticulo"], tabla["Descripcion"],
                        tabla["CantidadArticulo"], tabla["PrecioVendedor"], tabla["PrecioFinal"]);
                    }
                }
                tabla.Close();
            }
            catch (SqlException m)
            {
                MessageBox.Show(m.Message, "Error al extraer datos de los detalles de la orden de compra.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sql_command.Connection = conexion_SQL.CerrarSQLBD();
            }
        }

        #endregion

        #region MÉTODO PARA OBTENER EL NOMBRE COMPLETO DE UN VENDEDOR A PARTIR DE LA IDENTIFICACIÓN
        public string NombreCompleto_Vendedor(string Mi_Id)
        {
            string MiNombreCompleto = "";
            try
            {
                sql_command.Connection = conexion_SQL.CerrarSQLBD();
                sql_command.Connection = conexion_SQL.Abrir_SQLBD();
                sql_command.CommandType = CommandType.Text;
                sql_command.Parameters.Clear();
                sql_command.CommandText = "SELECT CONCAT(Nombre , ' ' , PrimerApellido , ' ' , SegundoApellido) AS NombreCompleto FROM dbo.Vendedor WHERE [Identificacion] = " + "'" + Mi_Id + "'";
                SqlDataReader registro = sql_command.ExecuteReader();
                if (registro.HasRows)
                {
                    while (registro.Read())
                    {
                        MiNombreCompleto = registro["NombreCompleto"].ToString();
                    }
                }
                registro.Close();
                sql_command.ExecuteNonQuery();
            }
            catch (SqlException m)
            {
                MessageBox.Show(m.Message, "Error al buscar el nombre completo del vendedor en la base de datos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sql_command.Connection = conexion_SQL.CerrarSQLBD();
            }
            return MiNombreCompleto;
        }
        #endregion

        #region MÉTODO PARA OBTENER UN DATO DE TIPO ENTERO EN ESPECIFICO DE UNA TABLA
        public int ObtenerDato(int id, string campo, string tabla,string extra)
        {
            int num = 0;
            try
            {
                sql_command.Connection = conexion_SQL.CerrarSQLBD();
                sql_command.Connection = conexion_SQL.Abrir_SQLBD();
                sql_command.CommandType = CommandType.Text;
                sql_command.Parameters.Clear();
                sql_command.CommandText = "select " + campo + " from dbo." + tabla + " Where [IdArticulo] = " + id +extra;
                SqlDataReader registro = sql_command.ExecuteReader();
                while (registro.Read())
                {
                    num = int.Parse(registro[campo].ToString());
                }
                registro.Close();
            }
            catch (SqlException m)
            {
                MessageBox.Show(m.Message, "Error al buscar dato de tipo entero.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sql_command.Connection = conexion_SQL.CerrarSQLBD();
            }
            return num;
        }
        #endregion

        #region  MÉTODO PARA OBTENER UN DATO DE TIPO DECIMAL EN ESPECIFICO DE UNA TABLA
        public decimal ObtenerDato_Dec(int id, string campo, string tabla)
        {
            decimal num = 0;
            try
            {
                sql_command.Connection = conexion_SQL.Abrir_SQLBD();
                sql_command.CommandType = CommandType.Text;
                sql_command.Parameters.Clear();
                sql_command.CommandText = "Select " + campo + " from dbo." + tabla + " Where [IdArticulo] = " + id;
                SqlDataReader registro = sql_command.ExecuteReader();
                while (registro.Read())
                {
                    num = decimal.Parse(registro[campo].ToString());
                }
                registro.Close();
            }
            catch (SqlException m)
            {
                MessageBox.Show(m.Message, "Error  al obtener dato decimal.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sql_command.Connection = conexion_SQL.CerrarSQLBD();
            }
            return num;
        }
        #endregion

        #region MÉTODO PARA OBTENER LA DESCIPCIÓN DE UN ARTÍCULO A PARTIR DEL ID
        public string Descripcion_Art(int Mi_Id)
        {
            string Desc = "";
            try
            {
                sql_command.Connection = conexion_SQL.CerrarSQLBD();
                sql_command.Connection = conexion_SQL.Abrir_SQLBD();
                sql_command.CommandType = CommandType.Text;
                sql_command.Parameters.Clear();
                sql_command.CommandText = "Select Descripcion from dbo.Articulo  WHERE [IdArticulo] = " + Mi_Id;

                SqlDataReader registro = sql_command.ExecuteReader();

                while (registro.Read())
                {
                    Desc = registro["Descripcion"].ToString();
                }
                registro.Close();
                sql_command.ExecuteNonQuery();
            }
            catch (SqlException m)
            {
                MessageBox.Show(m.Message, "Error al obtener la descripción del artículo.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sql_command.Connection = conexion_SQL.CerrarSQLBD();
            }
            return Desc;
        }
        #endregion

        #region MÉTODO PARA OBTENER LA IDENTIFICACIÓN DEL VENDEDOR A PARTIR DEL ID
        public string Id_Vendedor(string Mi_Id)
        {
            string Id = "";
            try
            {
                sql_command.Connection = conexion_SQL.CerrarSQLBD();
                sql_command.Connection = conexion_SQL.Abrir_SQLBD();
                sql_command.CommandType = CommandType.Text;
                sql_command.Parameters.Clear();
                sql_command.CommandText = "SELECT Identificacion from OrdenCompra Where [IdOrden] =" + Mi_Id;
                SqlDataReader registro = sql_command.ExecuteReader();

                while (registro.Read())
                {
                    Id = registro["Identificacion"].ToString();
                }
                registro.Close();
                sql_command.ExecuteNonQuery();
            }
            catch (SqlException m)
            {
                MessageBox.Show(m.Message, "Error al obtener la identificación del vendedor.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sql_command.Connection = conexion_SQL.CerrarSQLBD();
            }
            return Id;
        }
        #endregion

        #region MÉTODO PARA REMOVER UN ARTICULO DE LA ORDEN DE COMPRA 
        public void RemoverArticulo(int id,int id_orden)
        {
            try
            {
                sql_command.Connection = conexion_SQL.CerrarSQLBD();
                sql_command.Connection = conexion_SQL.Abrir_SQLBD();
                sql_command.CommandType = CommandType.Text;
                sql_command.Parameters.Clear();
                sql_command.CommandText = "DELETE OrdenCompraDetalle  WHERE [IdArticulo] = " + id +" And [IdOrden] = "+id_orden;
                sql_command.ExecuteNonQuery();
            }
            catch (System.Data.SqlClient.SqlException m) //Captura cualquier error al tratar de escribir en la base de datos.
            {
                MessageBox.Show(m.Message, "Error al remover el artículo.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sql_command.Connection = conexion_SQL.CerrarSQLBD();
            }
        }
        #endregion

        #region MÉTODO PARA MOSTRAR TOTALES
        public decimal Total(string campo, int MiId)
        {
            decimal num = 0;
            try
            {
                sql_command.Connection = conexion_SQL.CerrarSQLBD();
                sql_command.Connection = conexion_SQL.Abrir_SQLBD();
                sql_command.CommandType = CommandType.Text;
                sql_command.Parameters.Clear();
                sql_command.CommandText = "SELECT SUM (" + campo + ") Total FROM OrdenCompraDetalle WHERE IdOrden=" + MiId;
                SqlDataReader registro = sql_command.ExecuteReader();
                if (registro.HasRows)
                {
                    while (registro.Read())
                    {
                        num = decimal.Parse(registro["Total"].ToString());
                    }
                }


                registro.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("No hay detalles agregados en esa orden de compra.", "Error  al obtener el total.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SqlException m)
            {
                MessageBox.Show(m.Message, "Error al obtener el total.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sql_command.Connection = conexion_SQL.CerrarSQLBD();
            }
            return num;
        }
        #endregion

        #region MÉTODO PARA REMOVER UN ARTICULO DE LA ORDEN DE COMPRA 
        public void RemoverOrdenes_SinDetalles()
        {
            try
            {
                sql_command.Connection = conexion_SQL.CerrarSQLBD();
                sql_command.Connection = conexion_SQL.Abrir_SQLBD();
                sql_command.CommandType = CommandType.Text;
                sql_command.Parameters.Clear();
                sql_command.CommandText = "DELETE OrdenCompra FROM OrdenCompra LEFT JOIN OrdenCompraDetalle " +
                 "ON OrdenCompra.IdOrden= OrdenCompraDetalle.IdOrden WHERE OrdenCompraDetalle.IdOrden IS NULL";
                sql_command.ExecuteNonQuery();
            }
            catch (SqlException m) 
            {
                MessageBox.Show(m.Message, "Error al limpiar registros de las órdenes de compra.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sql_command.Connection = conexion_SQL.CerrarSQLBD();
            }
        }
        #endregion


    }
}
