using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SalesCRM.Models;

namespace SalesCRM.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<SalesLeadEntity> SalesLead { get; set; }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
    }
}
