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
    
    public partial class Vendedor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Vendedor()
        {
            this.Venta_Factura = new HashSet<Venta_Factura>();
        }
    
        public int ID_Vendedor { get; set; }
        public Nullable<int> ID_Rol { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public Nullable<int> Edad { get; set; }
        public string Usuario { get; set; }
        public string contra { get; set; }
        public Nullable<int> ID_Sucursal { get; set; }
        public Nullable<int> Estado { get; set; }
    
        public virtual Rol Rol { get; set; }
        public virtual Sucursal Sucursal { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Venta_Factura> Venta_Factura { get; set; }
    }
}
