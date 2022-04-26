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
    public partial class RegistrarVendedores : Form
    {
        SQL_Query sqlquery = new SQL_Query();

        public RegistrarVendedores()
        {
            InitializeComponent();
            #region INFO A MOSTRAR AL ABRIR EL FORM
            toolTip1.SetToolTip(txtIdentificacion, "Ingrese la identificación");
            toolTip1.SetToolTip(txtNombre, "Ingrese el nombre ");
            toolTip1.SetToolTip(txtApellido1, "Ingrese el Primer Apellido");
            toolTip1.SetToolTip(txtApellido2, "Ingrese el Segundo Apellido");
            rbMasculino.Checked = true;
            Validacion.Fecha_Correcta(CalendarNacimiento, CalendarIngreso);
            TablaIVendedores.DataSource = new List<Vendedor>(sqlquery.Lista_Vendedores());
            #endregion
        }


        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                #region REGISTRAR VENDEDOR
                TextBox[] cajas_texto = {txtNombre,txtApellido1,txtApellido2,txtIdentificacion };      
                if (Validacion.CamposVacios_Form(cajas_texto))
                {         
                    MessageBox.Show("Favor completar todos los campos que se le están solicitando.\nNo puede quedar ningún campo vacío.");
                }
                else if (sqlquery.Existe_Id(txtIdentificacion.Text, "Vendedor", "Identificacion"))
                {
                    MessageBox.Show("El Id ingresado ya existe, por favor ingrese uno diferente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtIdentificacion.Text = "";
                }
                else
                {
                    Vendedor datos_vendedor = new Vendedor(txtIdentificacion.Text, txtNombre.Text, txtApellido1.Text, txtApellido2.Text, CalendarNacimiento.Value.Date, (rbFemenino.Checked ? 'F' : 'M'), CalendarIngreso.Value.Date);
                    sqlquery.Insertar_Vendedor(datos_vendedor);
                    MessageBox.Show("Vendedor registrado con éxito!");
                    TablaIVendedores.DataSource = new List<Vendedor>(sqlquery.Lista_Vendedores());
                    rbMasculino.Checked = true;
                    Validacion.Fecha_Correcta(CalendarNacimiento, CalendarIngreso);
                    TextBox[] MytextVacio = { txtIdentificacion, txtNombre, txtApellido2, txtApellido1 };
                    Funcion.ActualizarCamposTextoVacio(MytextVacio);
                }
                #endregion
            }
            catch (Exception ed)
            {
                MessageBox.Show(ed.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

        }    


        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloLetras(e, "para el nombre del vendedor/a.");
        }

        private void txtApellido1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloLetras(e, "para el primer apellido del vendedor/a.");
        }

        private void txtApellido2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.SoloLetras(e, "para el segundo apellido del vendedor/a.");
        }    
    }
}
