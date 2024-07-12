using CarOnRentApi.Model.InputModel;
using CarOnRentApi.Model.ViewModel;
using Microsoft.EntityFrameworkCore;

namespace CarOnRentApi.Data
{
    public class DatabaseDbContext : DbContext
    {
        private readonly IConfiguration _config;
        public DatabaseDbContext(IConfiguration config)
        {
            _config = config;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_config.GetConnectionString("default"));
        }

        public DbSet<SubscribeIM> subscribeIMs { get; set; }
        public DbSet<SubscribeVM> subscribeVMs { get; set; }
        public DbSet<UserContactIM> userContactIMs { get; set; }
        public DbSet<UserContactVM> userContactVMs { get; set; }

    }
}
