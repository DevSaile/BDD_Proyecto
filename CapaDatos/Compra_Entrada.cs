//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaDatos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Compra_Entrada
    {
        public int ID_Entrada { get; set; }
        public Nullable<int> Estado { get; set; }
        public Nullable<int> ID_Producto { get; set; }
        public Nullable<System.DateTime> Fecha_Compra { get; set; }
        public Nullable<decimal> Precio_Compra { get; set; }
        public Nullable<int> CantidadCompra { get; set; }
    
        public virtual Producto Producto { get; set; }
    }
}
