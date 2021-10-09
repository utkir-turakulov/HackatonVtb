using DAL.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class DataHubContext : IdentityDbContext<User> 
    {
        public DataHubContext(DbContextOptions<DataHubContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Dataset> Datasets { get; set;}

        public DbSet<DataFields> DataFields { get; set; }
    }
}