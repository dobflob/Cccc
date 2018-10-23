using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cccc.Models
{
    [Table("Orders")]
    public class Order
    {
        public Order()
        {

        }

        public Order(Guid orderId, Guid customerId, Guid? employeeId, DateTime? orderDate, DateTime? requiredDate, DateTime? shippedDate, decimal? freight, string shipName, string shipAddress, string shipCity, string shipRegion, string shipPostalCode, string shipCountry)
        {
            OrderID = orderId;
            CustomerID = customerId;
            EmployeeID = employeeId;
            OrderDate = orderDate;
            RequiredDate = requiredDate;
            ShippedDate = shippedDate;
            Freight = freight;
            ShipName = shipName;
            ShipAddress = shipAddress;
            ShipCity = shipCity;
            ShipRegion = shipRegion;
            ShipPostalCode = shipPostalCode;
            ShipCountry = shipCountry;
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid OrderID { get; private set; }

        public Guid CustomerID { get; private set; }

        public Guid? EmployeeID { get; private set; }

        public DateTime? OrderDate { get; private set; }

        public DateTime? RequiredDate { get; private set; }

        public DateTime? ShippedDate { get; private set; }

        public decimal? Freight { get; private set; }

        [StringLength(40)]
        public string ShipName { get; private set; }

        [StringLength(60)]
        public string ShipAddress { get; private set; }

        [StringLength(15)]
        public string ShipCity { get; private set; }

        [StringLength(15)]
        public string ShipRegion { get; private set; }

        [StringLength(10)]
        public string ShipPostalCode { get; private set; }

        [StringLength(15)]
        public string ShipCountry { get; private set; }

        [ForeignKey("CustomerID")]
        public virtual Customer Customer { get; private set; }

        [ForeignKey("EmployeeID")]
        public virtual Employee Employee { get; private set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; private set; }
        //public Shipper Shipper { get; set; }
    }
}