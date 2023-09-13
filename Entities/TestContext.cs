using CrochetbookBackend.Models;
using Microsoft.EntityFrameworkCore;

namespace CrochetbookBackend.Entities
{
    public class TestContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }
        protected readonly IConfiguration _configuration;

        public TestContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }


        public string DbPath { get; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_configuration.GetConnectionString("crochetbook"));
        }
    }
}
