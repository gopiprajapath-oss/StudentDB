using Microsoft.EntityFrameworkCore;

namespace StudentDb
{
    public class StudentContext : DbContext
    {
        public StudentContext()
        {
            
        }
        public StudentContext(DbContextOptions<StudentContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.\sqlexpress;Initial Catalog=Student;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        }

        public virtual DbSet<Student> Students { get; set; }

        public virtual DbSet<Teachers> Teachers { get; set; }
    }
}
