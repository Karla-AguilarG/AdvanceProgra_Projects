using Acceso_Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

/*
     Estudiante: Karla Bricelda Aguilar González
 */

namespace LogicaNegocio.Funciones
{
   
    public class Funcion
    {
        static SQL_Query sqlquery = new SQL_Query();

        #region MÉTODO PARA AGREGAR EL SÍMBOLO DE COLONES A LOS DATOS DE TIPO PRECIO EN LOS DATAGRIDVIEW
        /// <paam name="reg"> Ingresar en-US / es-Es </param>
        /// <param name="moneda">Ingresar símbolo de la moneda (₡,$,...) </param>
        /// <returns> Me devuelve un CultureInfo myCIclone para dar formato </returns>
        public static CultureInfo CultureInfo(string reg, string moneda)
        {
            //reg = "en-US"  moneda = "₡"         
            CultureInfo myCI = new CultureInfo(reg, false);
            CultureInfo myCIclone = (CultureInfo)myCI.Clone();
            myCIclone.NumberFormat.CurrencySymbol = moneda;
            return myCIclone;
        }
        #endregion

        #region MÉTODO PARA ABRIR UN FORM DENTRO DE UN PANEL CONTENEDOR DEL FORM PRINCIPAL
        public static void AbrirFormHija(object MyForm, Panel MyPanel)
        {
            if (MyPanel.Controls.Count > 0)
            {
                MyPanel.Controls.RemoveAt(0);
            }

            Form form = MyForm as Form;

            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            MyPanel.Controls.Add(form);
            MyPanel.Tag = form;
            form.Show();
        }
        #endregion

        #region LIMPIAR PANEL DEL FORM PRINCIPAL
        public static void Limpiar_Panel(Panel MyPanel)
        {
            if (MyPanel.Controls.Count > 0)
            {
                MyPanel.Controls.RemoveAt(0);
            }
        }
        #endregion

        #region MÉTODO PARA GENERAR UN ID ALEAORIO CON UN RANGO DE 1000-9999
        public static int ID_Aleatorio(string tabla,string campo)
        {
            int id_aleatorio= new Random().Next(1000000, 9999999);
            if (sqlquery.Existe_Id_Articulo(id_aleatorio, tabla, campo))
            {
                id_aleatorio = new Random().Next(1000000, 9999999);
            }
                return id_aleatorio;                
        }
        #endregion

        #region MÉTODO PARA LABELS EN EL FORM
        public static void Actualizar_Labels(Label[] Text,bool act)
        {
            foreach (Label lab in Text)
            {
                lab.Visible = act;
            }
        }
        #endregion

        #region MÉTODO PARA ACTUALIZAR CAMPOS VACÍOS DE TEXTO EN EL FORM
        public static void ActualizarCamposTextoVacio(TextBox[] Mytextovacio)
        {
            for (int i = 0; i < Mytextovacio.Length; i++)
            {
                Mytextovacio[i].Text = "";
            }
        }
        #endregion

        #region MÉTODO PARA ACTUALIZAR CAMPOS DE TEXTO DE TIPO NUMÉRICO EN EL FORM
        public static void ActualizarCamposTextoNumerico(TextBox[] MytextoNumero)
        {
            for (int i = 0; i < MytextoNumero.Length; i++)
            {
                MytextoNumero[i].Text = "0";
            }
        }
        #endregion

        #region MÉTODO PARA Cargar_Combobox
        public static void Cargar_Combobox(ComboBox MicomboBox,List<string> MiLista)
        {
            MicomboBox.Items.Clear();
            foreach (string lista in MiLista)
            {
                MicomboBox.Items.Add(lista); //Se agrega la lista al combobox.
            }
            MicomboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            MicomboBox.SelectedIndex = -1;
        }
        #endregion

        #region HABILITAR COMPONENTES GRÁFICOS
        public static void Habilitar_Button(Button[] btn)
        {
            foreach (Button botones in btn)
            {
                botones.Enabled = true;
            }
        }

        public static void Habilitar_ComboBox(ComboBox[] cb)
        {
            foreach (ComboBox combos in cb)
            {
                combos.Enabled = true;
            }
        }

        public static void Habilitar_TextBox(TextBox[] txt)
        {
            foreach (TextBox textos in txt)
            {
                textos.Enabled = true;
            }
        }
        #endregion

        #region DESHABILITAR COMPONENTES GRÁFICOS
        public static void Deshabilitar_Button(Button[] btn )
        {
            foreach (Button botones in btn)
            {
                botones.Enabled = false;
            }
        }

        public static void Deshabilitar_ComboBox( ComboBox[] cb)
        {          
            foreach (ComboBox combos in cb)
            {
                combos.Enabled = false;
            }
        }

        public static void Deshabilitar_TextBox( TextBox[] txt)
        {
            foreach (TextBox textos in txt)
            {
                textos.Enabled = false;
            }
        }
        #endregion

    }
}
