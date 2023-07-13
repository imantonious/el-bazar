using el_bazar.Model;
using Microsoft.EntityFrameworkCore;

namespace el_bazar.Data
{
    public class MyContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "server=localhost;user=root;database=el-bazar";

            var serverVersion = new MySqlServerVersion(new Version(8, 0, 33));

            optionsBuilder.UseMySql(connectionString, serverVersion);
        }
    }
}