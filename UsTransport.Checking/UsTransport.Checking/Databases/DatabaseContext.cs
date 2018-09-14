using Microsoft.EntityFrameworkCore;
using UsTransport.Checking.Models;
using UsTransport.Checking.Services;
using Xamarin.Forms;

namespace UsTransport.Checking.Databases
{
    public class DatabaseContext: DbContext
    {
        public DbSet<User> Users { get; set; }

        public DatabaseContext()
        {
            this.Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var dbPath = DependencyService.Get<IHelper>().GetDbPath("ustransport.db");
            optionsBuilder.UseSqlite($"Filename={dbPath}");
        }
    }
}