//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;

//namespace LearningPlatform.Configurations
//{
//    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
//    {
//        public void Configure(EntityTypeBuilder<Category> builder)
//        {
//            builder.HasKey(c => c.Id);

//            builder.Property(c => c.Name)
//                .IsRequired()
//                .HasMaxLength(100);

//            builder.Property(c => c.Description)
//                .HasMaxLength(500);

//            builder.HasOne(c => c.ParentCategory)
//                .WithMany(c => c.SubCategories)
//                .HasForeignKey(c => c.ParentCategoryId)
//                .OnDelete(DeleteBehavior.Restrict);

//            builder.HasData(
//                new Category
//                {
//                    Id = 1,
//                    Name = "Programming",
//                    Description = "Programming courses",
//                    ParentCategoryId = null
//                },
//                new Category
//                {
//                    Id = 2,
//                    Name = "Backend",
//                    Description = "Backend development",
//                    ParentCategoryId = 1
//                },
//                new Category
//                {
//                    Id = 3,
//                    Name = "ASP.NET",
//                    Description = "ASP.NET development",
//                    ParentCategoryId = 2
//                },
//                new Category
//                {
//                    Id = 4,
//                    Name = "Design",
//                    Description = "Design courses",
//                    ParentCategoryId = null
//                },
//                new Category
//                {
//                    Id = 5,
//                    Name = "UI Design",
//                    Description = "User interface design",
//                    ParentCategoryId = 4
//                }
//            );
//        }
//    }
//}