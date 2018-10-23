using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Cccc.Models
{
    [Table("Employees")]
    public class Employee
    {
        public Employee()
        {
            
        }

        public Employee(Guid employeeId, string lastName, string firstName)
        {
            EmployeeId = employeeId;
            LastName = lastName;
            FirstName = firstName;            
        }

        public Employee(Guid employeeId, string lastName, string firstName, string title, string titleOfCourtesy, DateTime? birthDate, DateTime? hireDate, string address, string city, string region, string postalCode, string country, string homePhone, string extension, Guid? reportsTo)
        {
            EmployeeId = employeeId;
            LastName = lastName;
            FirstName = firstName;
            Title = title;
            TitleOfCourtesy = titleOfCourtesy;
            BirthDate = birthDate;
            HireDate = hireDate;
            Address = address;
            City = city;
            Region = region;
            PostalCode = postalCode;
            Country = country;
            HomePhone = homePhone;
            Extension = extension;           
            ReportsTo = reportsTo;            
        }
        
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid EmployeeId { get; private set; }

        [StringLength(25), Required]
        public string LastName { get; private set; }

        [StringLength(10), Required]
        public string FirstName { get; private set; }

        [StringLength(30)]
        public string Title { get; private set; }

        [StringLength(25)]
        public string TitleOfCourtesy { get; private set; }

        public DateTime? BirthDate { get; private set; }

        public DateTime? HireDate { get; private set; }

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

        [StringLength(25)]
        public string HomePhone { get; private set; }

        [StringLength(4)]
        public string Extension { get; private set; }

        public byte[] Photo { get; private set; }

        public string Notes { get; private set; }

        public Guid? ReportsTo { get; private set; }

        [StringLength(255)]
        public string PhotoPath { get; private set; }

        [ForeignKey("ReportsTo")]
        public virtual Employee Manager { get; private set; }

        public virtual ICollection<Order> Orders { get; private set; }
    }
}