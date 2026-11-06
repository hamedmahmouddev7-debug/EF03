//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;

//namespace LearningPlatform.Configurations
//{
//    public class EnrollmentConfiguration : IEntityTypeConfiguration<Enrollment>
//    {
//        public void Configure(EntityTypeBuilder<Enrollment> builder)
//        {
//            builder.HasKey(e => new { e.StudentId, e.CourseId });

//            builder.Property(e => e.EnrolledAt)
//                .IsRequired();

//            builder.Property(e => e.ProgressPercentage)
//                .IsRequired();

//            builder.Property(e => e.Status)
//                .HasConversion<string>()
//                .HasMaxLength(20)
//                .IsRequired();

//            builder.Property(e => e.FinalGrade)
//                .HasPrecision(5, 2);

//            builder.ToTable(t =>
//                t.HasCheckConstraint(
//                    "CK_Enrollment_Progress",
//                    "[ProgressPercentage] BETWEEN 0 AND 100"
//                )
//            );

//            builder.HasOne(e => e.Student)
//                .WithMany(s => s.Enrollments)
//                .HasForeignKey(e => e.StudentId)
//                .OnDelete(DeleteBehavior.Cascade);

//            builder.HasOne(e => e.Course)
//                .WithMany(c => c.Enrollments)
//                .HasForeignKey(e => e.CourseId)
//                .OnDelete(DeleteBehavior.Cascade);
//        }
//    }
//}