using Bloggo.API.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace Bloggo.API.Data
{
    public class ApplicationDbContext : DbContext
    {
        // Takes in DbContextOptions and passes it to the basse class.
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        // DbSet class represents the collection of entities from BlogPost in relational DB
        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
