//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaEntidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class Productos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Productos()
        {
            this.DetalleLote = new HashSet<DetalleLote>();
        }
    
        public string IdProducto { get; set; }
        public string NombreProducto { get; set; }
        public int StockMinimo { get; set; }
        public int IdCategoría { get; set; }
        public int IdMarca { get; set; }
    
        public virtual Categorías Categorías { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetalleLote> DetalleLote { get; set; }
        public virtual Marcas Marcas { get; set; }
    }
}
