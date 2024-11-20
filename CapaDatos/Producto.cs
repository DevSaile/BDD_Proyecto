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
    
    public partial class Producto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Producto()
        {
            this.Compra_Entrada = new HashSet<Compra_Entrada>();
            this.Venta_Factura = new HashSet<Venta_Factura>();
        }
    
        public int ID_Producto { get; set; }
        public Nullable<int> ID_Categoria { get; set; }
        public string Nombre { get; set; }
        public string Marca { get; set; }
        public Nullable<int> Cantidad { get; set; }
        public Nullable<decimal> Precio_Compra { get; set; }
        public Nullable<decimal> Precio_Producto { get; set; }
        public Nullable<int> ID_Sucursal { get; set; }
        public string DetalleS { get; set; }
        public Nullable<int> Estado { get; set; }
    
        public virtual Categoria Categoria { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Compra_Entrada> Compra_Entrada { get; set; }
        public virtual Sucursal Sucursal { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Venta_Factura> Venta_Factura { get; set; }
    }
}