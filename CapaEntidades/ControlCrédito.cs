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
    
    public partial class ControlCrédito
    {
        public int IdControlCrédito { get; set; }
        public int IdCrédito { get; set; }
        public int Cuota { get; set; }
        public decimal Saldo { get; set; }
        public System.DateTime FechaAbono { get; set; }
    
        public virtual Crédito Crédito { get; set; }
    }
}
