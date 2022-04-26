
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
    public partial class RegistrarVentaArticulos : Form
    {
        SQL_Query sqlquery = new SQL_Query();
        public RegistrarVentaArticulos()
        {
            InitializeComponent();

            #region INICIALIZAR FORM
            Lab_IdAleatorio.Text = "" + Funcion.ID_Aleatorio("OrdenCompra", "IdOrden");
            var lista_idvend = new List<string>(sqlquery.Lista_ID("Vendedor", "Identificacion", " "));
            Funcion.Cargar_Combobox(cbIdVendedor, lista_idvend);
            TablaInventarioArticulos.DataSource = new List<Articulo>(sqlquery.Lista_Articulo());
            TablaInventarioArticulos.Columns[3].DefaultCellStyle.Format = "c";
            TablaInventarioArticulos.Columns[3].DefaultCellStyle.FormatProvider = Funcion.CultureInfo("en-US", "₡");
            TablaInventarioArticulos.Columns[4].DefaultCellStyle.Format = "c";
            TablaInventarioArticulos.Columns[4].DefaultCellStyle.FormatProvider = Funcion.CultureInfo("en-US", "₡");

            txtCantidad.Text = "0";
            Funcion.Deshabilitar_Button(new Button[] { btnAgregar, btnActualizar, btnremover_art });
            Funcion.Deshabilitar_ComboBox(new ComboBox[] { cbIdArticulo, cbActualizar, cbremove });
            Funcion.Deshabilitar_TextBox(new TextBox[] { txtCantidad, txtCantAct });
            #endregion

        }
        private void txtIdArt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloNumeros(e, "para el Id del artículo.");
        }

        private void txtCant_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloNumeros(e, "para la cantidad que desea comprar del artículo.");
        }

        private void cbIdVendedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            MiNombre.Text = " ";
            string MyId = cbIdVendedor.Text;
            string name = sqlquery.NombreCompleto_Vendedor(MyId);
            MiNombre.Text = name;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                #region AGREGAR ARTÍCULO
                if (cbIdArticulo.SelectedIndex == -1)
                {
                    MessageBox.Show("Para agregar un detalle de compra necesita elegir un id del dropdown", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (Validacion.CamposVacios_Form(new TextBox[] { txtCantidad }))
                {
                    MessageBox.Show("El campo de la cantidad no puede quedar vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (!Validacion.Entero(txtCantidad.Text))
                {
                    MessageBox.Show("Solo se permiten números positivos para la cantidad del artículo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCantidad.Text = "0";
                }
                else if (Validacion.CantidadValida(Convert.ToInt32(txtCantidad.Text)))
                {
                    throw new NotFiniteNumberException("La cantidad debe ser mayor a 0, por favor vuelva a digitar un monto válido.");
                }
                else if (Convert.ToInt32(txtCantidad.Text) > sqlquery.ObtenerDato(Convert.ToInt32(cbIdArticulo.Text), "CantidadDisponible", "Articulo",""))
                {
                    throw new NotFiniteNumberException("La cantidad a ingresar debe ser menor o igual a la cantidad existente, por favor vuelva a digitar un monto válido.");
                }
                else
                {
                    int id_articulo = Convert.ToInt32(cbIdArticulo.Text);
                    int cantidad_ingresada = Convert.ToInt32(txtCantidad.Text);
                    decimal precio_V = sqlquery.ObtenerDato_Dec(id_articulo, "PrecioVendedor", "Articulo");
                    decimal precio_F = sqlquery.ObtenerDato_Dec(id_articulo, "PrecioVendedor", "Articulo");
                  
                    #region AGREGAR DATOS PARA REGISTRAR LA ORDEN DE COMPRA
                    //AGREGAR DETALLE A LA ORDEN DE COMPRA
                    OrdenCompraDetalle detalle = new OrdenCompraDetalle(id_articulo, cantidad_ingresada);
                    //INSERTAR DETALLE 
                    sqlquery.Insertar_Detalles(detalle, Convert.ToInt32(Lab_IdAleatorio.Text), precio_V * cantidad_ingresada, precio_F * cantidad_ingresada, Funcion.ID_Aleatorio("OrdenCompraDetalle", "IdDetalle"));
                    sqlquery.Actualizar("Articulo", "CantidadDisponible", "CantidadDisponible-" + cantidad_ingresada, id_articulo, "IdArticulo");
                    #endregion

                    #region CARGAR INFORMACIÓN                    
                    TablaInventarioArticulos.DataSource = new List<Articulo>(sqlquery.Lista_Articulo());
                    TablaOrd.Rows.Clear();

                    sqlquery.Lista_detalle(Lab_IdAleatorio.Text, TablaOrd);
                    TablaOrd.Columns[4].DefaultCellStyle.FormatProvider = Funcion.CultureInfo("en-US", "₡");
                    TablaOrd.Columns[4].DefaultCellStyle.Format = "c";
                    TablaOrd.Columns[3].DefaultCellStyle.FormatProvider = Funcion.CultureInfo("en-US", "₡");
                    TablaOrd.Columns[3].DefaultCellStyle.Format = "c";

                    decimal PV = sqlquery.Total("PrecioVendedor", Convert.ToInt32(Lab_IdAleatorio.Text));
                    decimal PF = sqlquery.Total("PrecioFinal", Convert.ToInt32(Lab_IdAleatorio.Text));
                    PrecioV.Text = "₡" + PV;
                    Precio_F.Text = "₡" + PF;

                    txtCantidad.Clear();
                    Descripcion.Text = string.Empty;

                    var lista_art = new List<string>(sqlquery.Lista_ID("Articulo", "IdArticulo", " Where  CantidadDisponible>0"));
                    Funcion.Cargar_Combobox(cbIdArticulo, lista_art);

                    var lista = new List<string>(sqlquery.Lista_ID("OrdenCompraDetalle", "IdArticulo", " Where [IdOrden] = " + Convert.ToInt32(Lab_IdAleatorio.Text)));
                    Funcion.Cargar_Combobox(cbActualizar, lista);
                    Funcion.Cargar_Combobox(cbremove, lista);
                    #endregion

                    #region HABILITAR CAMPOS,LIMPIAR CAMPOS 
                    Funcion.Habilitar_Button(new Button[] { btnActualizar, btnremover_art });
                    Funcion.Habilitar_ComboBox(new ComboBox[] { cbremove, cbActualizar });
                    Funcion.Habilitar_TextBox(new TextBox[] { txtCantAct });
                    #endregion

                    MessageBox.Show("Articulo agregado con éxito a la orden de compra.");
                }
                #endregion
            }
            catch (NotFiniteNumberException mensaje)
            {
                MessageBox.Show(mensaje.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnDatosOrdCompra_Click(object sender, EventArgs e)
        {
            try
            {
                #region INSERTAR DATOS DE LA ORDEN DE COMPRA EN LA BASE DE DATOS 
                if (cbIdVendedor.SelectedIndex == -1)
                {
                    MessageBox.Show("Para registrar un orden de compra necesita elegir un id del dropdown", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    OrdenCompra orden = new OrdenCompra(int.Parse(Lab_IdAleatorio.Text), CalendarioFechaActual.Value.Date, cbIdVendedor.Text);
                    sqlquery.Insertar_OrdenesCompra(orden);
                    MessageBox.Show("Orden agregada con éxito!");

                    #region HABILITAR CAMPOS PARA AGREGAR DETALLES A LA ORDEN DE COMPRA
                    Funcion.Habilitar_Button(new Button[] { btnAgregar });
                    Funcion.Habilitar_ComboBox(new ComboBox[] { cbIdArticulo });
                    Funcion.Habilitar_TextBox(new TextBox[] { txtCantidad });
                    var lista_art = new List<string>(sqlquery.Lista_ID("Articulo", "IdArticulo", " Where  CantidadDisponible>0"));
                    Funcion.Cargar_Combobox(cbIdArticulo, lista_art);
                    #endregion

                    btnDatosOrdCompra.Enabled = false;
                    cbIdVendedor.Enabled = false;
                }
                #endregion

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }



        private void btnTerminarCompra_Click(object sender, EventArgs e)
        {
            #region ACTUALIZAR CAMPOS PARA REGISTRAR OTRA ORDEN DE COMPRA NUEVA
            Lab_IdAleatorio.Text = "" + Funcion.ID_Aleatorio("OrdenCompra", "IdOrden");
            cbIdVendedor.SelectedIndex = -1;
            txtCantidad.Clear();
            cbActualizar.Items.Clear();
            cbIdArticulo.Items.Clear();
            cbremove.Items.Clear();
            PrecioV.Text = "₡";
            Precio_F.Text = "₡";
            cbActualizar.Enabled = false;
            cbremove.Enabled = false;
            cbIdArticulo.Enabled = false;
            txtCantidad.Enabled = false;
            cbIdVendedor.Enabled = true;
            btnAgregar.Enabled = true;
            Desc_remove.Text = "";
            Desc_Act.Text = "";
            Descripcion.Text = "";
            btnDatosOrdCompra.Enabled = true;
            Funcion.Deshabilitar_Button(new Button[] { btnAgregar, btnActualizar, btnremover_art });
            TablaOrd.Rows.Clear();
            #endregion
        }

        private void btnremover_art_Click(object sender, EventArgs e)
        {
            #region REMOVER ARTÍCULO
            if (cbremove.SelectedIndex == -1)
            {
                MessageBox.Show("Para actualizar la cantidad del artículo, necesita elegir un id del dropdown", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                int cant = 0;
                cant = sqlquery.ObtenerDato(int.Parse(cbremove.Text), "CantidadArticulo", "OrdenCompraDetalle"," And [IdOrden] = "+Lab_IdAleatorio.Text);
                sqlquery.Actualizar("Articulo", "CantidadDisponible", "CantidadDisponible + " + cant, int.Parse(cbremove.Text), "IdArticulo");
                sqlquery.RemoverArticulo(int.Parse(cbremove.Text), int.Parse(Lab_IdAleatorio.Text));
                var lista = new List<string>(sqlquery.Lista_ID("OrdenCompraDetalle", "IdArticulo", " Where [IdOrden] = " + Convert.ToInt32(Lab_IdAleatorio.Text)));
                Funcion.Cargar_Combobox(cbActualizar, lista);
                Funcion.Cargar_Combobox(cbremove, lista);
                Desc_remove.Text = "";
                TablaInventarioArticulos.DataSource = new List<Articulo>(sqlquery.Lista_Articulo());
                TablaOrd.Rows.Clear();
                sqlquery.Lista_detalle(Lab_IdAleatorio.Text, TablaOrd);
                MessageBox.Show("Articulo eliminado con éxito");
            }
            #endregion
        }

        private void cbIdArticulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Descripcion.Text = "";
            string desc = sqlquery.Descripcion_Art(Convert.ToInt32(cbIdArticulo.Text));
            Descripcion.Text = desc;
        }

        private void cbActualizar_SelectedIndexChanged(object sender, EventArgs e)
        {
            Desc_Act.Text = "";
            string desc = sqlquery.Descripcion_Art(Convert.ToInt32(cbActualizar.Text));
            Desc_Act.Text = desc;
        }

        private void cbremove_SelectedIndexChanged(object sender, EventArgs e)
        {
            Desc_remove.Text = "";
            string desc = sqlquery.Descripcion_Art(Convert.ToInt32(cbremove.Text));
            Desc_remove.Text = desc;
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Validacion.SoloNumeros(e, "para la cantidad del artículo."))
            {
                MessageBox.Show("Solo se permiten números para la cantidad del artículo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void txtCantAct_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Validacion.SoloNumeros(e, "para la cantidad del artículo."))
            {
                MessageBox.Show("Solo se permiten números para la cantidad del artículo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
             
                #region ACTUALIZAR ARTÍCULO
                if (cbActualizar.SelectedIndex == -1)
                {
                    MessageBox.Show("Para actualizar la cantidad del artículo, necesita elegir un id del dropdown", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (Validacion.CamposVacios_Form(new TextBox[] { txtCantAct }))
                {
                    MessageBox.Show("El campo de texto para la cantidad de disponibilidad no puede quedar vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (!Validacion.Entero(txtCantAct.Text))
                {
                    MessageBox.Show("Solo se permiten números positivos la cantidad de disponibilidad del artículo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCantidad.Text = "0";
                }
                else if (Validacion.CantidadValida(int.Parse(txtCantAct.Text)))
                {
                    throw new NotFiniteNumberException("La cantidad de disponibilidad debe ser mayor a 0, por favor vuelva a digitar un monto válido.");
                }
                else
                {
                    int cantidad_actualizar = Convert.ToInt32((txtCantAct.Text));
                    int cantidad_articulo = sqlquery.ObtenerDato(Convert.ToInt32(cbActualizar.Text), "CantidadDisponible", "Articulo","");
                    int cantidad_orden = sqlquery.ObtenerDato(Convert.ToInt32(cbActualizar.Text), "CantidadArticulo", "OrdenCompraDetalle"," And [IdOrden] = "+Lab_IdAleatorio.Text);
                    

                    if (cantidad_actualizar > cantidad_orden)
                    {
                        int pedir = cantidad_actualizar - cantidad_orden;

                        if (cantidad_articulo < pedir)
                        {
                            MessageBox.Show("La cantidad disponible del artículo es menor a la cantidad que se desea actualizar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            sqlquery.Actualizar("OrdenCompraDetalle", "CantidadArticulo", "CantidadArticulo+" + pedir, Convert.ToInt32(cbActualizar.Text), "IdArticulo");
                            sqlquery.Actualizar("Articulo", "CantidadDisponible", "CantidadDisponible-" + pedir, Convert.ToInt32(cbActualizar.Text), "IdArticulo");
                        }
                    }
                    else 
                    {
                       int  pedir2 = cantidad_orden - cantidad_actualizar;
                        sqlquery.Actualizar("OrdenCompraDetalle", "CantidadArticulo", "CantidadArticulo-" + pedir2, Convert.ToInt32(cbActualizar.Text), "IdArticulo");
                        sqlquery.Actualizar("Articulo", "CantidadDisponible", "CantidadDisponible+" + pedir2, Convert.ToInt32(cbActualizar.Text), "IdArticulo");
                    }
                    var lista = new List<string>(sqlquery.Lista_ID("OrdenCompraDetalle", "IdArticulo", " Where [IdOrden] = " + Convert.ToInt32(Lab_IdAleatorio.Text)));
                    Funcion.Cargar_Combobox(cbActualizar, lista);
                    Funcion.Cargar_Combobox(cbremove, lista);
                    Desc_Act.Text = "";
                    txtCantAct.Text = "";
                    TablaInventarioArticulos.DataSource = new List<Articulo>(sqlquery.Lista_Articulo());
                    TablaOrd.Rows.Clear();
                    sqlquery.Lista_detalle(Lab_IdAleatorio.Text, TablaOrd);
                    MessageBox.Show("Articulo de la orden de compra actualizado con éxito.");
                }
                #endregion
               
            }
            catch (NotFiniteNumberException mensaje)
            {
                MessageBox.Show(mensaje.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
    }
}

