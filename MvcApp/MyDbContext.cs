using Microsoft.EntityFrameworkCore;
using MvcApp.Model;

namespace MvcApp
{
    public class MyDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        public MyDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}