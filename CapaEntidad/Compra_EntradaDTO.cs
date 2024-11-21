using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaEntidad
{
    public class Compra_EntradaDTO
    {

        public int ID_Entrada { get; set; }

        public int? Estado { get; set; }

        public DateTime? Fecha_Compra { get; set; }

        public decimal? Precio_Compra { get; set; }

        public int? CantidadCompra { get; set; }



        /*VARIABLES PARA TABLA PRODUCTOS EN COMPRA_ENTRADA*/
        public int? ID_Producto { get; set; }

        public string Nombre_Producto { get; set; } // Propiedad para el nombre del producto*/

        public string Marca { get; set; }

        public int? Cantidad { get; set; }

        public decimal? Precio_Producto { get; set; }

        public string Detalles { get; set; }

        /* FIN DE LAS VARIABLES DE PRODUCTOS */


        /* INICIO DE LAS VARIABLES DE SUCURSAL */

        public string Nombre_Sucursal { get; set; }
        public int ID_Sucursal { get; set; }

        public string Descripcion_Sucursal { get; set; }

        /* FIN DE LAS VARIABLES DE SUCURSAL */


        /* INICIO DE LAS VARIABLES DE CATEGORIA */

        public string Nombre_Categoria{ get; set; }


        /* FIN DE LAS VARIABLES DE CATEGORIA */





    }
}
