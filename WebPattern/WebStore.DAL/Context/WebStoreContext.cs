using Microsoft.EntityFrameworkCore;
using WebStore.Domain.Model;

namespace WebStore.DAL.Context
{
    public class WebStoreContext : DbContext
    {
        public WebStoreContext(DbContextOptions options) : base(options)
        { }
        public DbSet<Section> Sections { get; set; }

        public DbSet<Brand> Brand { get; set; }

    }
}
