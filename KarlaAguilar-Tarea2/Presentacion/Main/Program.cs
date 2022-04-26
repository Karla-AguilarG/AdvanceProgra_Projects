/*
Universidad Estatal a Distancia.
Curso: Programación Avanzada 00830.
Centro Universitario Los Chiles.
Estudiante: Karla Bricelda Aguilar González/cédula 155825898214.
Grupo: 03
Tarea No.1
Tercer Cuatrimestre de 2021.
Tutor encargado: Juan Gabriel Ramírez Valladares.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Splash());
        }
    }
}
