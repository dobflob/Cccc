using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cccc.Models
{
    [Table("Products")]
    public class Product
    {
        public Product()
        {
            
        }

        public Product(Guid productId, string productName, string quantityPerUnit, decimal unitPrice, short? unitsInStock, short? unitsOnOrder, short? reorderLevel, bool discontinued)
        {
            ProductID = productId;
            ProductName = productName;
            QuantityPerUnit = quantityPerUnit;
            UnitPrice = unitPrice;
            UnitsInStock = unitsInStock;
            UnitsOnOrder = unitsOnOrder;
            ReorderLevel = reorderLevel;
            Discontinued = discontinued;
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid ProductID { get; private set; }

        [StringLength(40)]
        public string ProductName { get; private set; }
        public string QuantityPerUnit { get; private set; }
        public decimal? UnitPrice { get; private set; }
        public short? UnitsInStock { get; private set; }
        public short? UnitsOnOrder { get; private set; }
        public short? ReorderLevel { get; private set; }
        public bool Discontinued { get; private set; }
        // public Category Category  { get ;  set;}
        public ICollection<OrderDetail> Order_Detail { get; private set; }
        // public Supplier Suppliers { get ;  set;}

        public void Updatestuff(string productName, string quantityPerUnit, decimal? unitPrice)
        {
            ProductName = productName;
            QuantityPerUnit = quantityPerUnit;
            UnitPrice = unitPrice;
        }
    }
}