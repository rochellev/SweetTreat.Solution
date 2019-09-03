using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace SweetTreat.Models
{
    public class SweetTreatContext : IdentityDbContext<ApplicationUser>
    {
        // tables
        public virtual DbSet<Treat> Treats {get; set;}
        public virtual DbSet<Flavor> Flavors {get; set;}
        public virtual DbSet<TreatFlavor> TreatFlavor {get; set;}


        // constructor
        public SweetTreatContext(DbContextOptions options) : base(options) { }
    }
}