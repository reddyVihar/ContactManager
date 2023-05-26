namespace ContactManager.Data.Models
{
    public class Address
    {
        public int? Id { get; set; } // Primary key
        public string? Street { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? PostalCode { get; set; }

        public  ICollection<Contact>? Contacts { get; set; }
    }

}
