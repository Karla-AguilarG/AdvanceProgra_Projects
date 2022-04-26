using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Acceso_Datos;
using Entidades;
using LogicaNegocio;
using LogicaNegocio.Funciones;

/*
     Estudiante: Karla Bricelda Aguilar González
 */

namespace Presentacion.Ventanas
{
    public partial class RegistrarArticulos : Form
    {
        SQL_Query sqlquery = new SQL_Query();

      
        public RegistrarArticulos()
        {
            InitializeComponent();

            #region TEXTO A MOSTRAR EN CADA UNO DE LOS TOOLTIPS ASIGNADOS PARA LOS TEXTBOX DEL FORM
            toolTip1.SetToolTip(txtIdArticulo, "Ingrese el Identificador del artículo");
            toolTip1.SetToolTip(txtDescripcion, "Ingrese la descripción del artículo");
            toolTip1.SetToolTip(txtPrecioVendedor, "Ingrese el el precio del vendedor");
            toolTip1.SetToolTip(txtPrecioFinal, "Ingrese el precio final ");
            toolTip1.SetToolTip(txtCantidadDis, "Ingrese la cantidad disponible del artículo");
            #endregion

            #region INFO A MOSTRAR CUANDO SE EJECUTE ESE FORM
            rbNo.Checked = true;
            TextBox[] MytextVacio = { txtDescripcion };
            TextBox[] MytextNumerico = { txtIdArticulo, txtPrecioFinal, txtPrecioVendedor, txtCantidadDis };
            Funcion.ActualizarCamposTextoNumerico(MytextNumerico);
            Funcion.ActualizarCamposTextoVacio(MytextVacio);     
            TablaArticulos.DataSource = new List<Articulo>(sqlquery.Lista_Articulo());
            TablaArticulos.Columns[3].DefaultCellStyle.Format = "c";
            TablaArticulos.Columns[3].DefaultCellStyle.FormatProvider = Funcion.CultureInfo("en-US", "₡");
            TablaArticulos.Columns[4].DefaultCellStyle.Format = "c";
            TablaArticulos.Columns[4].DefaultCellStyle.FormatProvider = Funcion.CultureInfo("en-US", "₡");
            #endregion
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                #region REGISTRAR ARTÍCULO
                if (Validacion.CamposVacios_Form(new TextBox[] {txtDescripcion, txtCantidadDis, txtIdArticulo, txtPrecioVendedor, txtPrecioFinal }))
                {
                    MessageBox.Show("Complete todos los campos que se le están solicitando, no puede dejar campos vacíos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }     
                else if (!Validacion.Entero(txtIdArticulo.Text))
                {
                    MessageBox.Show("Solo se permiten números positivos para el id del artículo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtIdArticulo.Text = "0";
                }
                else if (!Validacion.Entero(txtCantidadDis.Text))
                {
                    MessageBox.Show("Solo se permiten números positivos para la cantidad del artículo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCantidadDis.Text = "0";
                }
                else if (!Validacion.Decimal(txtPrecioVendedor.Text))
                {
                    MessageBox.Show("Solo se permite el ingreso de números, punto y 2 digitos decimals para el precio del vendedor.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtPrecioVendedor.Text = "0";
                }
                else if (!Validacion.Decimal(txtPrecioFinal.Text))
                {
                    MessageBox.Show("Solo se permite el ingreso de numeros, punto y 2 digitos decimals para el precio final.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtPrecioFinal.Text = "0";
                }
                else if (sqlquery.Existe_Id_Articulo(Convert.ToInt32(txtIdArticulo.Text), "Articulo", "IdArticulo"))
                {
                    throw new NotFiniteNumberException("El Id ingresado ya existe, por favor ingrese uno diferente.");
                }
                else if (Validacion.CantidadValida(Convert.ToInt32(txtIdArticulo.Text)))
                {
                    throw new NotFiniteNumberException("El id a ingresar debe ser mayor a 0, por favor vuelva a digitar un dato numérico válido.");
                }
                else if (Validacion.CantidadValida(Convert.ToInt32(txtCantidadDis.Text)))
                {
                    throw new NotFiniteNumberException("La cantidad de disponibilidad debe ser mayor a 0, por favor vuelva a digitar un monto válido.");
                }
                else if (Validacion.CantidadValidaDecimal(decimal.Parse(txtPrecioVendedor.Text)))
                {
                    throw new NotFiniteNumberException("La cantidad del precio del vendedor debe ser mayor a 0, por favor vuelva a digitar un monto válido.");
                }
                else if (Validacion.CantidadValidaDecimal(decimal.Parse(txtPrecioFinal.Text)))
                {
                    throw new NotFiniteNumberException("La cantidad del precio final debe ser mayor a 0, por favor vuelva a digitar un monto válido.");
                }                        
                else
                {
                    Articulo datos_articulo = new Articulo(Convert.ToInt32(txtIdArticulo.Text), txtDescripcion.Text, (rbYes.Checked ? true : false),
                                  decimal.Parse(txtPrecioVendedor.Text), decimal.Parse(txtPrecioFinal.Text), Convert.ToInt32(txtCantidadDis.Text));

                    sqlquery.Insertar_Articulo(datos_articulo);
                    MessageBox.Show("Artículo agregado con éxito!");
                    TablaArticulos.DataSource = new List<Articulo>(sqlquery.Lista_Articulo());
                    TablaArticulos.Columns[3].DefaultCellStyle.Format = "c";
                    TablaArticulos.Columns[3].DefaultCellStyle.FormatProvider = Funcion.CultureInfo("en-US", "₡");
                    TablaArticulos.Columns[4].DefaultCellStyle.Format = "c";
                    TablaArticulos.Columns[4].DefaultCellStyle.FormatProvider = Funcion.CultureInfo("en-US", "₡");
                    Funcion.ActualizarCamposTextoNumerico(new TextBox[] { txtDescripcion });
                    Funcion.ActualizarCamposTextoVacio(new TextBox[] { txtIdArticulo, txtPrecioFinal, txtPrecioVendedor, txtCantidadDis });
                }
                #endregion
            }
            catch (NotFiniteNumberException mensaje)
            {
                MessageBox.Show(mensaje.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Ha ocurrido un error al ingresar los registros del artículo."+ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
       
        }

        private void txtIdArticulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Validacion.SoloNumeros(e, "para el Id del artículo."))
            {
                MessageBox.Show("Solo se permiten números para el Id del artículo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }
        

        private void txtPrecioVendedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloDecimales(e, "para el precio del vendedor.");
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloLetras(e, "para la descripción del artículo.");
        }

        private void txtPrecioFinal_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloDecimales(e, "para el precio final del artículo.");
        }

        private void txtCantidadDis_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Validacion.SoloNumeros(e, "para el Id del artículo."))
            {
                MessageBox.Show("Solo se permiten números para la cantidad de disponibilidad del artículo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
           
        }


    }
}
