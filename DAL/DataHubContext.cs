using System.Data.Entity;
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
    }
}