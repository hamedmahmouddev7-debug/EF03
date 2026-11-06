//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;

//namespace LearningPlatform.Configurations
//{
//    public class CourseConfiguration : IEntityTypeConfiguration<Course>
//    {
//        public void Configure(EntityTypeBuilder<Course> builder)
//        {
//            builder.HasKey(c => c.Id);

//            builder.Property(c => c.Title)
//                .IsRequired()
//                .HasMaxLength(200);

//            builder.Property(c => c.Description)
//                .HasMaxLength(2000);

//            builder.Property(c => c.Price)
//                .HasPrecision(18, 2);

//            builder.Property(c => c.Level)
//                .IsRequired()
//                .HasConversion<string>()
//                .HasMaxLength(20);

//            builder.Property(c => c.IsPublished)
//                .IsRequired();

//            builder.Property(c => c.PublishedAt);

//            builder.HasOne(c => c.Instructor)
//                .WithMany(i => i.Courses)
//                .HasForeignKey(c => c.InstructorId)
//                .IsRequired()
//                .OnDelete(DeleteBehavior.Restrict);

//            builder.HasOne(c => c.Category)
//                .WithMany(c => c.Courses)
//                .HasForeignKey(c => c.CategoryId)
//                .IsRequired()
//                .OnDelete(DeleteBehavior.Restrict);

//            builder.HasData(
//                new Course
//                {
//                    Id = 1,
//                    Title = "ASP.NET Core Fundamentals",
//                    Description = "Introduction to ASP.NET Core",
//                    Price = 1200m,
//                    Level = CourseLevel.Beginner,
//                    IsPublished = true,
//                    PublishedAt = new DateTime(2024, 1, 1),
//                    InstructorId = 1,
//                    CategoryId = 3
//                },
//                new Course
//                {
//                    Id = 2,
//                    Title = "Advanced EF Core",
//                    Description = "Advanced Entity Framework Core",
//                    Price = 1800m,
//                    Level = CourseLevel.Advanced,
//                    IsPublished = true,
//                    PublishedAt = new DateTime(2024, 2, 1),
//                    InstructorId = 1,
//                    CategoryId = 3
//                },
//                new Course
//                {
//                    Id = 3,
//                    Title = "Python for Beginners",
//                    Description = "Learn Python from scratch",
//                    Price = 800m,
//                    Level = CourseLevel.Beginner,
//                    IsPublished = true,
//                    PublishedAt = new DateTime(2024, 3, 1),
//                    InstructorId = 2,
//                    CategoryId = 1
//                },
//                new Course
//                {
//                    Id = 4,
//                    Title = "Building REST APIs",
//                    Description = "Build RESTful APIs",
//                    Price = 1500m,
//                    Level = CourseLevel.Intermediate,
//                    IsPublished = true,
//                    PublishedAt = new DateTime(2024, 4, 1),
//                    InstructorId = 2,
//                    CategoryId = 2
//                },
//                new Course
//                {
//                    Id = 5,
//                    Title = "UI Design Basics",
//                    Description = "Introduction to UI Design",
//                    Price = 900m,
//                    Level = CourseLevel.Beginner,
//                    IsPublished = false,
//                    PublishedAt = null,
//                    InstructorId = 3,
//                    CategoryId = 5
//                },
//                new Course
//                {
//                    Id = 6,
//                    Title = "Design Systems in Practice",
//                    Description = "Learn design systems",
//                    Price = 1100m,
//                    Level = CourseLevel.Intermediate,
//                    IsPublished = false,
//                    PublishedAt = null,
//                    InstructorId = 3,
//                    CategoryId = 4
//                }
//            );
//        }
//    }
//}