using EntityWebApiCRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityWebApiCRUD.Data
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Users> Users { get; set; }

    }
}
