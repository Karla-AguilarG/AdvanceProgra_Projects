using Acceso_Datos;
using Entidades;
using LogicaNegocio;
using LogicaNegocio.Funciones;
using System;
using System.Windows.Forms;

/*
     Estudiante: Karla Bricelda Aguilar González
 */

namespace Presentacion.Ventanas
{
    public partial class MenuInicio : Form
    {
        SQL_Query sqlquery = new SQL_Query();
        public MenuInicio()
        {
            InitializeComponent();
            Funcion.AbrirFormHija(new Portada(), PanelContenedor);
        }

        private void btnRegArticulos_Click(object sender, EventArgs e)
        {
            #region REGISTRAR ARTÍCULOS         
            Funcion.AbrirFormHija(new RegistrarArticulos(), PanelContenedor);
            #endregion
        }

        private void btnRegVendedores_Click(object sender, EventArgs e)
        {
            #region REGISTRAR VENDEDORES
            Funcion.AbrirFormHija(new RegistrarVendedores(), PanelContenedor);
            #endregion
        }

        private void btnVentaArticulos_Click(object sender, EventArgs e)
        {
            #region REALIZAR VENTA DE ARTÍCULOS
            if (sqlquery.VerificarDatosExistentes("Vendedor") || sqlquery.VerificarDatosExistentes("Articulo"))
            {
                Funcion.AbrirFormHija(new Portada(), PanelContenedor);
                MessageBox.Show("Error, para realizar una venta de artículos debe haber ingresado al menos un artículo y un vendedor.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Funcion.AbrirFormHija(new RegistrarVentaArticulos(), PanelContenedor);
            }
            #endregion   
        }

        private void btnConsultarVentas_Click(object sender, EventArgs e)
        {
            #region CONSULTAR VENTAS 
            if (sqlquery.VerificarDatosExistentes("OrdenCompra"))
            {
                Funcion.AbrirFormHija(new Portada(), PanelContenedor);
                MessageBox.Show("Error,no hay órdenes de compras registradas para mostrar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Funcion.AbrirFormHija(new ConsultarVentas(), PanelContenedor);
            }
            #endregion
        }

        private void btnActualizarInventario_Click(object sender, EventArgs e)
        {
            #region ACUALIZAR INVENTARIO 
            if (sqlquery.VerificarDatosExistentes("Articulo"))
            {
                Funcion.AbrirFormHija(new Portada(), PanelContenedor);
                MessageBox.Show("Error,no hay artículos disponibles para actualizar el inventario.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Funcion.AbrirFormHija(new ActualizarInventario(), PanelContenedor);
            }
            #endregion
        }
              

        private void btnConsultarInventario_Click(object sender, EventArgs e)
        {

            #region CONSULTAR INVENTARIO    
            if (sqlquery.VerificarDatosExistentes("Articulo"))
            {
                Funcion.AbrirFormHija(new Portada(), PanelContenedor);
                //Funcion.Limpiar_Panel(PanelContenedor);
                MessageBox.Show("Error, no hay artículos registrados para mostrar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Funcion.AbrirFormHija(new ConsultarInventario(), PanelContenedor);
            }
            #endregion
         
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            #region SALIR DEL PROGRAMA
            DialogResult result = MessageBox.Show("¿Está realmente seguro que desea salir del programa? Sí/No", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                Funcion.AbrirFormHija(new Portada(), PanelContenedor);
            }
            #endregion
        }

        private void MenuInicio_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
