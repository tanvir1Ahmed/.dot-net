using Microsoft.EntityFrameworkCore;

namespace ExcelOperation.Model
{
    public class StudentDbContext:DbContext    {
        public DbSet<Student> Students { get; set; }
        public StudentDbContext(DbContextOptions options):base(options)
        {
            
        }
    }
}
