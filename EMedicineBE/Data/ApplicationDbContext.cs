using Microsoft.EntityFrameworkCore;

namespace EMedicineBE.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        } 
    }
}
