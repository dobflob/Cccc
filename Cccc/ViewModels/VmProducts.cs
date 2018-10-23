using System;
using System.ComponentModel.DataAnnotations;

namespace Cccc.ViewModels
{
    public class VmProducts
    {
        public Guid ProductID { get; set; }

        [Display(Name = "Product Name"), Required, StringLength(40)]
        public string ProductName { get; set; }

        [Display(Name = "Quantity Per Unit")]
        public string QuantityPerUnit { get; set; }

        [Display(Name = "Unit Price")]
        public decimal? UnitPrice { get; set; }
    }
}