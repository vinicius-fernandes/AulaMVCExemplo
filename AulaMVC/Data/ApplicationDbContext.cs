using AulaMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace AulaMVC.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }

        public DbSet<Cliente>? Clientes { get; set; }
    }
}
