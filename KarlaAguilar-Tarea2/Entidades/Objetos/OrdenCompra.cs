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
   public class OrdenCompra
   {
        #region ATRIBUTOS DE LA CLASE OrdenCompra
        private int idOrden;
        private DateTime fecha;
        private string identificacion;
        #endregion

        #region CONSTRUCTOR CON PARÁMETROS DE LA CLASE OrdenCompra
        public OrdenCompra(int idOrden, DateTime fecha, string identificacion)
        {
            this.idOrden = idOrden;
            this.fecha = fecha;
            this.identificacion = identificacion; 
        }
        #endregion

        #region CONSTRUCTOR VACÍO DE LA CLASE OrdenCompra
        public OrdenCompra()
        {
            this.idOrden = 0;
            this.fecha = default(DateTime);
            this.identificacion = "";
        }
        #endregion

        #region MÉTODOS GET & SET IdOrdenCompra
        public int IdOrdenCompra
        {
            get
            {
                return idOrden;
            }
            set
            {
                idOrden = value;
            }
        }
        #endregion

        #region MÉTODOS GET & SET Fecha
        public DateTime Fecha
        {
            get
            {
                return fecha;
            }
            set
            {
                fecha = DateTime.Now;
            }
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

    }
}
