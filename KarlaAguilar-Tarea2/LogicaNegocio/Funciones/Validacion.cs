using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

/*
     Estudiante: Karla Bricelda Aguilar González
 */

namespace LogicaNegocio
{
    public class Validacion
    {
        #region VARIABLES
        public static bool Punto = true;
        public static bool LetraM = true;
        public static DateTime Mayor_FechaNacimiento = DateTime.Now.AddYears(-18);
        public static DateTime Mayor_FechaIngreso = DateTime.Now;
        #endregion

        #region MÉTODO PARA VALIDAR QUE UNA CANTIDAD INGRESADA SEA MAYOR A 0
        public static bool CantidadValida(int MyCantidad)
        {
            if (MyCantidad <= 0)
            {
                return true;
            }
            return false;
        }

        public static bool CantidadValidaDecimal(decimal MyCantidad)
        {
            if (MyCantidad <= 0)
            {
                return true;
            }
            return false;
        }
        #endregion

        #region MÉTODO PARA VALIDAR QUE SOLO SE INGRESEN NÚMEROS 
        public static bool SoloNumeros(KeyPressEventArgs e, String MyTexto)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar) || Char.IsSeparator(e.KeyChar))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        #endregion

        #region MÉTODO PARA VALIDAR QUE SOLO SE INGRESEN LETRAS
        public static bool SoloLetras(KeyPressEventArgs e, String MyTexto)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras ." + MyTexto, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return true;
            }
            else
            {
                e.Handled = false;
                return false;
            }
        }
        #endregion

        #region MÉTODO PARA VALIDAR QUE SOLO SE INGRESE PUNTO Y NÚMEROS(PARA LOS DECIMALES)
        public static void SoloDecimales(KeyPressEventArgs e, String MyTexto)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != 46 && e.KeyChar != (char)Keys.M)
            {
                MessageBox.Show("Solo se permiten decimales (Punto y números), " + MyTexto, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
            else if (e.KeyChar == 46)
            {
                if (Punto)
                {
                    Punto = false;
                }
                else
                {
                    MessageBox.Show("Solo se permiten decimales (punto y números), " + MyTexto, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Handled = true;
                }
            }
        }
        /*
         *  esta función detecta:

    Que no haya un punto al inicio o final del texto.

    Que solo haya un punto decimal, de lo contrario, dará error.

    Valida que solo se ingrese caracteres numéricos.

         */
        public static bool Decimal(TextBox txtprecio)
        {
            int contador = 0, tamanio = txtprecio.Text.Length;
            //Si el punto está en el inicio o final del texto ...
            if (txtprecio.Text[0] == '.' || txtprecio.Text[tamanio - 1] == '.')
            {
                return false;
            }
            for (int i = 0; i != tamanio; ++i)
            {
                //Si es un punto, contamos ...
                if (txtprecio.Text[i] == '.')
                {
                    ++contador;
                }
                //Si no es un caracter númerico ...
                else if (!(txtprecio.Text[i] >= '0' && txtprecio.Text[i] <= 16))
                {
                    return false;
                }
                if (contador > 1)
                { //Si hay más de un punto decimal.
                    return false;
                }
            }
            return true;
        }

        public static bool ContarInt_Decimal(TextBox txtCosto)
        {
            int len = txtCosto.Text.Length;
            int count = 0;
            bool point = false;
            for (int i = 0; i != len; ++i)
            {
                ++count;
                if (txtCosto.Text[i] == '.')
                {
                    count = 0;
                    point = true;
                }
                //Si hay más de 9 enteros o más de dos decimales.
                else if ((point && count > 2) || (!point && count > 16))
                {
                    return false;
                }
            }
            return true;
        }
        #endregion

        #region MÉTODO PARA VALIDAR EL INGRESO DE ENTEROS CON TRY CATCH
        public static bool Entero(string texto)
        {
            try
            {
                int num = Convert.ToInt32(texto);
                return true;
            }
            catch (Exception)//CAPTURA LA EXCEPCION
            {
                return false;
            }
        }
        #endregion

        #region MÉTODO PARA VALIDAR EL INGRESO DE DECIMALES CON TRY CATCH
        public static bool Decimal(string texto)
        {
            try
            {
                decimal num = decimal.Parse(texto);
                return true;
            }
            catch (Exception)//CAPTURA LA EXCEPCION
            {
                return false;
            }
        }
        #endregion

        #region MÉTODO PARA VALIDAR QUE NO QUEDEN CAMPOS VACÍOS EN EL FORM
        public static bool CamposVacios_Form(TextBox []MisCajasTexto)
        {
            foreach (TextBox text in MisCajasTexto)
            {
                if (text.Text == String.Empty)
                {
                    return true;
                }
            }
            return false;
        }
        #endregion

        #region MÉTODO PARA VALIDAR LAS FECHAS QUE SE ELIJAN EN EL DATETIMEPICKER
        public static void Fecha_Correcta(DateTimePicker MyFechaNacimiento, DateTimePicker MyFechaIngreso)
        {
            MyFechaNacimiento.Value = Mayor_FechaNacimiento;
            MyFechaNacimiento.MaxDate = DateTime.Now.AddYears(-18);

            MyFechaIngreso.Value = Mayor_FechaIngreso;
            MyFechaIngreso.MaxDate = DateTime.Now;
        }
        #endregion
    }
}
