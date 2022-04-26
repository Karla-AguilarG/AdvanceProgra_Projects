using System.Data;
using System.Data.SqlClient;

/*
     Estudiante: Karla Bricelda Aguilar González
*/

namespace Acceso_Datos
{
    public class Conexion_BDSQL
    {

       static string conexion_string = "data source=localhost; initial catalog=Faro; integrated security=True; MultipleActiveResultSets=True;";


        static SqlConnection conexion = new SqlConnection(conexion_string);

        #region MÉTODO SQLCONNECTION PARA ABRIR LA CONEXIÓN A LA BASE DE DATOS EN SQL SERVER
        public SqlConnection Abrir_SQLBD()
        {
            if (conexion.State == ConnectionState.Closed)
            {
                conexion.Open();
            }
            return conexion;
        }
        #endregion

        #region MÉTODO SQLCONNECTION PARA CERRAR LA CONEXIÓN A LA BASE DE DATOS EN SQL SERVER
        public SqlConnection CerrarSQLBD()
        {
            if (conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
            return conexion;
        }
        #endregion
    }
}
