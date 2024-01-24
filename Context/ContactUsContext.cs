using Contact_us_form.Models;
using Microsoft.EntityFrameworkCore;

namespace Contact_us_form.Context
{
    public class ContactUsContext : DbContext
    {
        public ContactUsContext(DbContextOptions<ContactUsContext> options) :base(options) { }
        public DbSet<Message> messages { get; set; }
    }
}
