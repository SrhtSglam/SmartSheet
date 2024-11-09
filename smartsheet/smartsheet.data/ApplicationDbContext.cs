using Microsoft.EntityFrameworkCore;
using smartsheet.entities;

namespace smartsheet.data{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options){
            
        }

        DbSet<Products> Products;
    }
}