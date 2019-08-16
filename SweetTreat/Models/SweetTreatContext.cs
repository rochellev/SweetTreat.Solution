using Microsoft.EntityFrameworkCore;

namespace SweetTreat.Models
{
    public class SweetTreatContext : DbContext
    {
        // tables
        public virtual DbSet<Treat> Treats {get; set;}


        // constructor
        public SweetTreatContext(DbContextOptions options) : base(options) { }
    }
}