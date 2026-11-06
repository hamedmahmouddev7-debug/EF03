//using LearningPlatform.Configurations;
//using Microsoft.EntityFrameworkCore;
//using System.Reflection.Emit;

//namespace LearningPlatform
//{
//    public class LearningContext : DbContext
//    {
//        public DbSet<Instructor> Instructors { get; set; }
//        public DbSet<Category> Categories { get; set; }
//        public DbSet<Course> Courses { get; set; }
//        public DbSet<Student> Students { get; set; }
//        public DbSet<Enrollment> Enrollments { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            optionsBuilder.UseSqlServer(
//                "Server=.;Database=LearningPlatformDb;Trusted_Connection=True;TrustServerCertificate=True"
//            );
//        }

//        protected override void OnModelCreating(ModelBuilder modelBuilder)
//        {
//            modelBuilder.ApplyConfigurationsFromAssembly(
//                typeof(LearningContext).Assembly
//            );
//        }
//    }
//}