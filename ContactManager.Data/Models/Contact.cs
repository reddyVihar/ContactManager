using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager.Data.Models
{
    public class Contact
    {
        public int Id { get; set; } // Primary key
        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public int? AddressId { get; set; } // Foreign key for the Address table
        public Address? Address { get; set; }
    }

}
