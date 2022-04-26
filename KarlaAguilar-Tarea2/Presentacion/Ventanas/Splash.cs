using Presentacion.Ventanas;
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

namespace Presentacion
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            #region SE ASIGNA LA DURACION DE LA EJECUCIÓN EN LA VENTANA SPLASH Y SE ABRE LA VENTANA DEL MENUINICIO
            progressBar1.Increment(5);
            MyLabel.Text = progressBar1.Value.ToString() + "%";
            if (progressBar1.Value == progressBar1.Maximum)
            {
                timer1.Stop();
                this.Hide();
                MenuInicio frmInicio = new MenuInicio();
                frmInicio.ShowDialog();
            }
            #endregion
        }
    }
}
