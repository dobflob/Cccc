using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.WebPages.Deployment;

namespace Cccc.Models
{
    [Table("Order Details")]
    public class OrderDetail : IValidatableObject
    {
        public OrderDetail()
        {
            
        }

        public OrderDetail(Guid orderId, Guid productId, decimal unitPrice, short quantity, float discount)
        {
            OrderID = orderId;
            ProductID = productId;
            UnitPrice = unitPrice;
            Quantity = quantity;
            Discount = discount;
        }

        [Key, Column(Order = 1), DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid OrderID { get; private set; }

        [Key, Column(Order = 2), DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid ProductID { get; private set; }

        public decimal UnitPrice { get; private set; }

        public short Quantity { get; private set; }

        public float Discount { get; private set; }

        public Order Orders { get; private set; }

        [ForeignKey("ProductID")]
        public virtual Product Product { get; private set; }

        // Validate for the Discount property.
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {

            if (Discount < 0 || Discount > 1)
            {
                yield return new ValidationResult
                    ("Discount must be a value between zero and one", new[] { "Discount" });
            }
        }
    }
}