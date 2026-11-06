//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;

//namespace LearningPlatform.Configurations
//{
//    public class InstructorConfiguration : IEntityTypeConfiguration<Instructor>
//    {
//        public void Configure(EntityTypeBuilder<Instructor> builder)
//        {
//            builder.HasKey(i => i.Id);

//            builder.Property(i => i.FullName)
//                .IsRequired()
//                .HasMaxLength(150);

//            builder.Property(i => i.Email)
//                .IsRequired()
//                .HasMaxLength(200);

//            builder.Property(i => i.Bio)
//                .HasMaxLength(1000);

//            builder.Property(i => i.JoinedAt)
//                .IsRequired();

//            builder.HasIndex(i => i.Email)
//                .IsUnique();

//            builder.HasData(
//                new Instructor
//                {
//                    Id = 1,
//                    FullName = "Sara Hassan",
//                    Email = "sara@learn.com",
//                    Bio = "Senior .NET developer",
//                    JoinedAt = new DateTime(2023, 1, 10)
//                },
//                new Instructor
//                {
//                    Id = 2,
//                    FullName = "Omar Khaled",
//                    Email = "omar@learn.com",
//                    Bio = "Backend & Python trainer",
//                    JoinedAt = new DateTime(2023, 6, 1)
//                },
//                new Instructor
//                {
//                    Id = 3,
//                    FullName = "Nour Adel",
//                    Email = "nour@learn.com",
//                    Bio = null,
//                    JoinedAt = new DateTime(2024, 2, 15)
//                }
//            );
//        }
//    }
//}