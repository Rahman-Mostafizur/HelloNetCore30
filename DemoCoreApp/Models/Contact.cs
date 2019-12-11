using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoCoreApp.Models
{
    public class Contact
    {
        private int id;
        [Key]
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        [StringLength(50)]
        [Required]
        public string Name { get; set; }
        [Phone]
        [Required]
        public string Phone { get; set; }
        [EmailAddress]
        public string Email { get; set; }



    }

    public class ContactContext:DbContext
    {
        public DbSet<Contact> Contacts { get; set; }

        public ContactContext(DbContextOptions<ContactContext> opt):base(opt)
        {

        }
    }

}
