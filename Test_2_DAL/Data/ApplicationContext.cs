using Microsoft.EntityFrameworkCore;
using Test_3_Domain.Entities;

namespace Test_2_DAL.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            //Database.EnsureCreated();
        }

        public DbSet<Movie> Movies { get; set; } = null!;
    }
}
