/*
     Estudiante: Karla Bricelda Aguilar González
*/

namespace Entidades
{
    public class Articulo
    {
        #region ATRIBUTOS DE LA CLASE Articulo
        private int idArticulo;
        private string descripcion;
        private bool activo;
        private decimal precioVendedor;
        private decimal precioFinal;
        private int cantidadDisponible;
        #endregion

        #region CONSTRUCTOR CON PARÁMETROS DE LA CLASE Articulo
        public Articulo(int idArticulo, string descripcion, bool activo, decimal precioVendedor, decimal precioFinal, int cantidadDisponible)
        {
            this.idArticulo = idArticulo;
            this.descripcion = descripcion;
            this.activo = activo;
            this.precioVendedor = precioVendedor;
            this.precioFinal = precioFinal;
            this.cantidadDisponible = cantidadDisponible;
        }
        #endregion

        #region CONSTRUCTOR VACÍO DE LA CLASE Articulo
        public Articulo() {
            this.idArticulo = 0;
            this.descripcion = "";
            this.activo = false;
            this.precioVendedor = 0;
            this.precioFinal = 0;
            this.cantidadDisponible = 0;
        }
        #endregion

        #region MÉTODOS GET & SET IdArticulo
        public int IdArticulo
        {
            get
            {
                return idArticulo;
            }
            set
            {
                idArticulo = value;
            }
        }
        #endregion

        #region MÉTODOS GET & SET Descripcion
        public string Descripcion
        {
            get
            {
                return descripcion;
            }
            set
            {
                descripcion = value;
            }
        }
        #endregion

        #region MÉTODOS GET & SET Activo
        public bool Activo
        {
            get
            {
                return activo;
            }
            set
            {
                activo = value;
            }
        }
        #endregion

        #region MÉTODOS GET & SET PrecioVendedor
        public decimal PrecioVendedor
        {
            get
            {
                return precioVendedor;
            }
            set
            {
                precioVendedor = value;
            }
        }
        #endregion

        #region MÉTODOS GET & SET PrecioFinal
        public decimal PrecioFinal
        {
            get
            {
                return precioFinal;
            }
            set
            {
                precioFinal = value;
            }
        }
        #endregion

        #region MÉTODOS GET & SET CantidadDisponible
        public int CantidadDisponible
        {
            get
            {
                return cantidadDisponible;
            }
            set
            {
                cantidadDisponible = value;
            }
        }
        #endregion

    }
}
