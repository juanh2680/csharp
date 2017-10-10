using Microsoft.EntityFrameworkCore;
              namespace R2HBook.Models
{
	//The database context is the main class that coordinates Entity Framework functionality for a given data model.
    public class StudentContext : DbContext
    {
         public StudentContext(DbContextOptions<StudentContext> options)
              :base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
    }

}
