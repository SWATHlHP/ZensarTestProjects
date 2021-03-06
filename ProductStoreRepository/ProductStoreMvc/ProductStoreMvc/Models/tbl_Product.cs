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

    public partial class tbl_Product
    {
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Product Name is required.")]
        [StringLength(50, MinimumLength = 3)]
        public string ProductName { get; set; }
        public Nullable<int> CategoryID { get; set; }
        public Nullable<int> UnitID { get; set; }

        [Required(ErrorMessage = "Price is required.")]
       // [RegularExpression("^[0-9]*$", ErrorMessage = "Price must be numeric, no characters allowed in number data")]
        [RegularExpression(@"^[0-9]+(\.[0-9]{1,2})$", ErrorMessage = "Price must be numeric, no characters allowed in number data, " +
            "and fractions are allowed upto 2 decimal places.")]
        public Nullable<decimal> Price { get; set; }

        [Required(ErrorMessage = "Quantity is required.")]
        [RegularExpression("^[0-9]*$", ErrorMessage = "Quantity must be numeric, no characters allowed in number data")]
        public Nullable<int> Quantity { get; set; }
        public virtual tbl_Category CategoryTbl { get; set; }
        public virtual tbl_Unit UnitTbl { get; set; }

    }
}
