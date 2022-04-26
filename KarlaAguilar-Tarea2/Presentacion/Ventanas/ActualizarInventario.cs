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

    public partial class ActualizarInventario : Form
    {
        SQL_Query sqlquery = new SQL_Query();
        public ActualizarInventario()
        {
            InitializeComponent();
            #region INFORMACIÓN A MOSTRAR EN EL TOOLTIP
            toolTip1.SetToolTip(txtCantidad, "Ingrese el monto de la cantidad que desea actualizar al artículo.");
            toolTip1.SetToolTip(txtPrecioF, "Ingrese el monto del precio final que desea actualizar al artículo.");
            toolTip1.SetToolTip(txtPrecioV, "Ingrese el monto del precio del vendedor que desea actualizar al artículo.");
            #endregion

            #region CARGAR INFORMACIÓN EL LA TABLA DE ARTICULOS Y EN EL COMBOBOX
            TablaArticulos.DataSource = new List<Articulo>(sqlquery.Lista_Articulo());
            TablaArticulos.Columns[3].DefaultCellStyle.Format = "c";
            TablaArticulos.Columns[3].DefaultCellStyle.FormatProvider = Funcion.CultureInfo("en-US", "₡");
            TablaArticulos.Columns[4].DefaultCellStyle.Format = "c";
            TablaArticulos.Columns[4].DefaultCellStyle.FormatProvider = Funcion.CultureInfo("en-US", "₡");
            Funcion.Cargar_Combobox(cbIdArticulo, new List<string>(sqlquery.Lista_ID("Articulo", "IdArticulo", "")));
            #endregion
        }

        private void txtIdArt_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloNumeros(e, "para el Id del artículo que desea actualizar.");
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloNumeros(e, "para la cantidad de disponibilidad del artículo que desea actualizar.");
        }

        private void btnCantidad_Click(object sender, EventArgs e)
        {
            try
            {
                #region ACTUALIZAR CANTIDAD DEL ARTÍCULO
                if (cbIdArticulo.SelectedIndex == -1)
                {
                    MessageBox.Show("Para actualizar la cantidad del artículo, necesita elegir un id del combo box,", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (Validacion.CamposVacios_Form(new TextBox[] { txtCantidad }))
                {
                    MessageBox.Show("El campo de texto para la cantidad de disponibilidad no puede quedar vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (!Validacion.Entero(txtCantidad.Text))
                {
                    MessageBox.Show("Solo se permiten números positivos la cantidad de disponibilidad del artículo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCantidad.Text = "0";
                }
                else if (Validacion.CantidadValida(int.Parse(txtCantidad.Text)))
                {
                    throw new NotFiniteNumberException("La cantidad de disponibilidad debe ser mayor a 0, por favor vuelva a digitar un monto válido.");
                }
                else
                {
                    sqlquery.Actualizar("Articulo","CantidadDisponible", txtCantidad.Text, int.Parse(cbIdArticulo.Text), "IdArticulo");
                    MessageBox.Show("Campo Actualizado con éxito");
                    txtCantidad.Text = "0";
                    TablaArticulos.DataSource = new List<Articulo>(sqlquery.Lista_Articulo());
                }
                #endregion
            }
            catch (NotFiniteNumberException mensaje)
            {
                MessageBox.Show(mensaje.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al actualizar la cantidad del artículo.\nVerifique los datos ingresados.\n" + ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
           
        }

        private void btnPrecioVendedor_Click(object sender, EventArgs e)
        {
            try
            {
                #region ACTUALIZAR PRECIO VENDEDOR DEL ARTÍCULO
                if (cbIdArticulo.SelectedIndex == -1)
                {
                    MessageBox.Show("Para actualizar el precio vendedor del artículo, necesita elegir un id del dropdown", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (Validacion.CamposVacios_Form(new TextBox[] { txtPrecioV }))
                {
                    MessageBox.Show("El campo de texto para el precio del vendedor no puede quedar vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (!Validacion.Decimal(txtPrecioV.Text))
                {
                    MessageBox.Show("Solo se permiten números positivos para el precio del vendedor.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtPrecioV.Text = "0";
                }
                else if (Validacion.CantidadValidaDecimal(decimal.Parse(txtPrecioV.Text)))
                {
                    throw new NotFiniteNumberException("La cantidad para el precio del vendedor debe ser mayor a 0, por favor vuelva a digitar un monto válido.");
                }
                else
                {
                    sqlquery.Actualizar("Articulo", "PrecioVendedor", txtPrecioV.Text, int.Parse(cbIdArticulo.Text), "IdArticulo");
                    MessageBox.Show("Campo Actualizado con éxito");
                    txtPrecioV.Text = "0";
                    TablaArticulos.DataSource = new List<Articulo>(sqlquery.Lista_Articulo());
                }
                #endregion
            }
            catch (NotFiniteNumberException mensaje)
            {
                MessageBox.Show(mensaje.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al actualizar el precio del vendedor.\nVerifique los datos ingresados.\n" + ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }                 
        }

        private void btnPrecioFinal_Click(object sender, EventArgs e)
        {
            try
            {
                #region ACTUALIZAR PRECIO FINAL DEL ARTÍCULO
                if (cbIdArticulo.SelectedIndex == -1)
                {
                    MessageBox.Show("Para actualizar el precio final del artículo, necesita elegir un id del dropdown", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (Validacion.CamposVacios_Form(new TextBox[] { txtPrecioF }))
                {
                    MessageBox.Show("El campo de texto para el precio final no puede quedar vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (!Validacion.Decimal(txtPrecioF.Text))
                {
                    MessageBox.Show("Solo se permiten números positivos para el precio final.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtPrecioV.Text = "0";
                }
                else if (Validacion.CantidadValidaDecimal(decimal.Parse(txtPrecioF.Text)))
                {
                    throw new NotFiniteNumberException("La cantidad para el precio final debe ser mayor a 0, por favor vuelva a digitar un monto válido.");
                }
                else
                {
                    sqlquery.Actualizar("Articulo", "PrecioFinal", txtPrecioF.Text, int.Parse(cbIdArticulo.Text), "IdArticulo");             
                    MessageBox.Show("Campo Actualizado con éxito");
                    txtPrecioF.Text = "0";
                    TablaArticulos.DataSource  = new List<Articulo>(sqlquery.Lista_Articulo());

                }
                #endregion
            }
            catch (NotFiniteNumberException mensaje)
            {
                MessageBox.Show(mensaje.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al actualizar el precio final del artículo.\nVerifique los datos ingresados.\n" + ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnActivo_Click(object sender, EventArgs e)
        {
            #region ACTUALIZAR ACTIVO DEL ARTÍCULO
            if (cbIdArticulo.SelectedIndex == -1)
            {
                MessageBox.Show("Para actualizar el activo del artículo, necesita elegir un id del dropdown", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                string DatoActualizar = "";
                if (rbYes.Checked == true)
                {
                    DatoActualizar = "1";
                }
                else if (rbNo.Checked == true)
                {
                    DatoActualizar = "0";
                }
                else
                {
                    MessageBox.Show("Elija Sí/No");
                }

                if (rbYes.Checked == true || rbNo.Checked == true)
                {
                    sqlquery.Actualizar("Articulo", "Activo", DatoActualizar, int.Parse(cbIdArticulo.Text), "IdArticulo");             
                    MessageBox.Show("Campo Actualizado con éxito");
                    TablaArticulos.DataSource = new List<Articulo>(sqlquery.Lista_Articulo());
                    rbYes.Checked = false;
                    rbNo.Checked = false;
                }
            }
            #endregion               
                 
        }

        private void txtPrecioV_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloDecimales(e, "para el precio del vendedor.");
        }

        private void txtPrecioF_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloDecimales(e, "para el precio final del artículo.");
        }


    }
}
