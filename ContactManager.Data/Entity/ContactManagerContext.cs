using ContactManager.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager.Data.Entity
{
    public class ContactManagerContext : DbContext
    {
        
        public ContactManagerContext()
    : this(new DbContextOptionsBuilder<ContactManagerContext>().UseInMemoryDatabase("InMemoryDb").Options)
        {
        }

        public ContactManagerContext(DbContextOptions<ContactManagerContext> options)
            : base(options)
        {
        }


        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Address> Addresses { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Here we're seeding one Address and one Contact.
            modelBuilder.Entity<Address>().HasData(new Address
            {
                Id = 1,
                Street = "12720 Club Dr",
                City = "Tampa",
                State = "FL",
                PostalCode = "33209"
            }, 
            new Address
            {
                Id = 2,
                Street = "1720 Lake Dr",
                City = "Tampa",
                State = "FL",
                PostalCode = "76589"
            });

            modelBuilder.Entity<Contact>().HasData(new Contact
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe",
                AddressId = 1 
            },
            new Contact
            {
                Id = 2,
                FirstName = "Jim",
                LastName = "Grude",
                AddressId = 2
            });

            base.OnModelCreating(modelBuilder);
        }


    }

}


