//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProductStoreMvc.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class tbl_Unit
    {
        public int UnitId { get; set; }
        [Required(ErrorMessage = "Unit Name is required.")]
        [StringLength(50, MinimumLength = 3)]
        public string UnitName { get; set; }
    }
}
