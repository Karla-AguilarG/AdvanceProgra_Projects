using Acceso_Datos;
using Entidades;
using LogicaNegocio;
using LogicaNegocio.Funciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
     Estudiante: Karla Bricelda Aguilar González
 */

namespace Presentacion.Ventanas
{
    public partial class ConsultarInventario : Form
    {
        SQL_Query sqlquery = new SQL_Query();

        public ConsultarInventario()
        {
            InitializeComponent();
            TablaInventarioArticulos.DataSource = new List<Articulo>(sqlquery.Lista_Articulo());
            TablaInventarioArticulos.Columns[3].DefaultCellStyle.Format = "c";
            TablaInventarioArticulos.Columns[3].DefaultCellStyle.FormatProvider = Funcion.CultureInfo("en-US", "₡");
            TablaInventarioArticulos.Columns[4].DefaultCellStyle.Format = "c";
            TablaInventarioArticulos.Columns[4].DefaultCellStyle.FormatProvider = Funcion.CultureInfo("en-US", "₡");
        }
    }
    
}
