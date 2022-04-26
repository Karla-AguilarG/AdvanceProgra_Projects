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
    public class OrdenCompraDetalle
    {
        #region ATRIBUTOS DE LA CLASE OrdenCompraDetalle  
        private int  idArticulo;
        private int cantidad;
        #endregion

        #region CONSTRUCTOR CON PARÁMETROS DE LA CLASE OrdenCompraDetalle
        public OrdenCompraDetalle(int idArticulo, int cantidad)
        {
            this.idArticulo = idArticulo;
            this.cantidad = cantidad;
        }
        public OrdenCompraDetalle()
        {
            this.idArticulo = 0;
            this.cantidad = 0;
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

        #region MÉTODOS GET & SET Cantidad
        public int Cantidad
        {
            get
            {
                return cantidad;
            }
            set
            {
                cantidad = value;
            }
        }
        #endregion
    }
}
