//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Vidly.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Eshop
    {
        public long EshopId { get; set; }
        public string EshopName { get; set; }
        public int EshopTypeId { get; set; }
        public System.DateTime CreatedDate { get; set; }
    
        public virtual EshopType EshopType { get; set; }
    }
}