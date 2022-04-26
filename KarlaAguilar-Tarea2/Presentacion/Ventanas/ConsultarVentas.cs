using Acceso_Datos;
using Entidades;
using LogicaNegocio;
using LogicaNegocio.Funciones;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

/*
     Estudiante: Karla Bricelda Aguilar González
 */

namespace Presentacion.Ventanas
{
    public partial class ConsultarVentas : Form
    {
        SQL_Query sqlquery = new SQL_Query();
        public ConsultarVentas()
        {
            InitializeComponent();
            sqlquery.RemoverOrdenes_SinDetalles();
            var list = new List<string>(sqlquery.Lista_ID("OrdenCompra", "IdOrden",""));
            Funcion.Cargar_Combobox(cbIdOrden, list);
            TablaVendedores.DataSource = new List<OrdenCompra>(sqlquery.ListaOrdenCompra());
        }


        private void txtIdOrden_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloNumeros(e, "para el Id de la Orden de compra.");
        }

        private void cbIdOrden_SelectedIndexChanged(object sender, EventArgs e)
        {

            NombreVendedor.Text = "";
            PrecioV.Text = "";
            Precio_F.Text = "";
            string Id = sqlquery.Id_Vendedor(cbIdOrden.Text);
            decimal PV= sqlquery.Total("PrecioVendedor",Convert.ToInt32(cbIdOrden.Text));
            decimal PF = sqlquery.Total("PrecioFinal", Convert.ToInt32(cbIdOrden.Text));
            NombreVendedor.Text = sqlquery.NombreCompleto_Vendedor(Id);
            PrecioV.Text = "" + PV;
            Precio_F.Text = ""+PF;
            TablaInventarioArticulos.Rows.Clear();
            sqlquery.Lista_detalle(cbIdOrden.Text, TablaInventarioArticulos);
        }


    }
}
