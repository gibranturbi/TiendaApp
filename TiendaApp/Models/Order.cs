//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TiendaApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public int OrderId { get; set; }
        public int AddressId { get; set; }
        public int UserId { get; set; }
        public System.DateTime OrderDate { get; set; }
        public string OrderDescription { get; set; }
    
        public virtual UserAddress UserAddress { get; set; }
        public virtual Users Users { get; set; }
        public virtual OrderDetail OrderDetail { get; set; }
    }
}
