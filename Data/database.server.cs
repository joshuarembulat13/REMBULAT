using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace database.service
{
    public class Database : IdentityDbContext<Users>
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public Database(DbContextOptions<Database> options) : base(options) { }

    }
}