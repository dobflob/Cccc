using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Cccc.Models
{
    [Table("Customers")]
    public class Customer
    {
        public Customer()
        {
            
        }

        public Customer(Guid customerId, string companyName, string contactName, string contactTitle, string address, string city, string region, string postalCode, string country, string phone, string fax)
        {
            CustomerID = customerId;
            CompanyName = companyName;
            ContactName = contactName;
            ContactTitle = contactTitle;
            Address = address;
            City = city;
            Region = region;
            PostalCode = postalCode;
            Country = country;
            Phone = phone;
            Fax = fax;
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid CustomerID { get; private set; }

        [StringLength(40), Required]
        public string CompanyName { get; private set; }

        [StringLength(30)]
        public string ContactName { get; private set; }

        [StringLength(30)]
        public string ContactTitle { get; private set; }

        [StringLength(60)]
        public string Address { get; private set; }

        [StringLength(15)]
        public string City { get; private set; }

        [StringLength(15)]
        public string Region { get; private set; }

        [StringLength(10)]
        public string PostalCode { get; private set; }

        [StringLength(15)]
        public string Country { get; private set; }

        [StringLength(24)]
        public string Phone { get; private set; }

        [StringLength(24)]
        public string Fax { get; private set; }

        public virtual ICollection<Order> Orders { get; private set; }
    }
}