//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ZeroHunter.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Food
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public System.DateTime Time { get; set; }
        public string Status { get; set; }
        public int EmpId { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
