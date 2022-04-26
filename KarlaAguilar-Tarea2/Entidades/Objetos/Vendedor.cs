using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
     Estudiante: Karla Bricelda Aguilar González
 */

namespace Entidades
{
    public class Vendedor
    {
        #region ATRIBUTOS DE LA CLASE Vendedor
        private string identificacion;
        private string nombre;
        private string primerApellido;
        private string segundoApellido;
        private DateTime fechaNacimiento;
        private char genero;
        private DateTime fechaIngreso;
        #endregion

        #region CONSTRUCTOR CON PARÁMETROS DE LA CLASE Vendedor
        public Vendedor(string identificacion, string nombre, string primerApellido, string segundoApellido, DateTime fechaNacimiento, char genero, DateTime fechaIngreso)
        {
            this.identificacion = identificacion;
            this.nombre = nombre;
            this.primerApellido = primerApellido;
            this.segundoApellido = segundoApellido;
            this.fechaNacimiento = fechaNacimiento;
            this.genero = genero;
            this.fechaIngreso = fechaIngreso;
        }
        #endregion

        #region CONSTRUCTOR VACÍO DE LA CLASE Vendedor
        public Vendedor()
        {
            this.identificacion = " ";
            this.nombre = " ";
            this.primerApellido = " ";
            this.segundoApellido = " ";
            this.fechaNacimiento = default(DateTime);
            this.genero = ' ';
            this.fechaIngreso = default(DateTime);
        }
        #endregion

        #region MÉTODOS GET & SET Identificacion
        public string Identificacion
        {
            get
            {
                return identificacion;
            }
            set
            {
                identificacion = value;
            }
        }
        #endregion

        #region MÉTODOS GET & SET Nombre
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }
        #endregion

        #region MÉTODOS GET & SET PrimerApellido
        public string PrimerApellido
        {
            get
            {
                return primerApellido;
            }
            set
            {
                primerApellido = value;
            }
        }
        #endregion

        #region MÉTODOS GET & SET SegundoApellido
        public string SegundoApellido
        {
            get
            {
                return segundoApellido;
            }
            set
            {
                segundoApellido = value;
            }
        }
        #endregion

        #region MÉTODOS GET & SET FechaNacimiento
        public DateTime FechaNacimiento
        {
            get
            {
                return fechaNacimiento;
            }
            set
            {
                fechaNacimiento = value;
            }
        }
        #endregion

        #region MÉTODOS GET & SET Genero
        public char Genero
        {
            get
            {
                return genero;
            }
            set
            {
                genero = value;
            }
        }
        #endregion

        #region MÉTODOS GET & SET FechaIngreso
        public DateTime FechaIngreso
        {
            get
            {
                return fechaIngreso;
            }
            set
            {
                fechaIngreso = value;
            }
        }
        #endregion

    }
}
