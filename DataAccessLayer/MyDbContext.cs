using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer
{
    public class MyDbContext : DbContext
    {
        //private readonly string _windowsConnectionString = @"Server=.\SQLExpress;Database=TAPDatabase1;Trusted_Connection=True;TrustServerCertificate=true";
        private readonly string _windowsConnectionString = @"Server=localhost;Database=TAPDatabase1;Trusted_Connection=False;TrustServerCertificate=True;User Id=sa; Password=Rc10@bossu2002";

        public DbSet<TestModel> TestModels { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_windowsConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
