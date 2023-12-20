using Microsoft.EntityFrameworkCore;
using MVC_project.Models;

namespace MVC_project.Models
{
    public class Context : DbContext
    {
        public Context( DbContextOptions<Context> options) :base(options)
        { 
        }

        public DbSet<User> Users { get; set; }

        
        public DbSet<Card> Cards { get; set; }

    }
}
