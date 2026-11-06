//using System;
//using System.Collections.Generic;

//namespace LearningPlatform
//{
//    public enum CourseLevel
//    {
//        Beginner,
//        Intermediate,
//        Advanced
//    }

//    public enum EnrollmentStatus
//    {
//        Active,
//        Completed,
//        Dropped
//    }

//    public class Instructor
//    {
//        public int Id { get; set; }
//        public string FullName { get; set; } = string.Empty;
//        public string Email { get; set; } = string.Empty;
//        public string? Bio { get; set; }
//        public DateTime JoinedAt { get; set; }

//        public ICollection<Course> Courses { get; set; } = new List<Course>();
//    }

//    public class Category
//    {
//        public int Id { get; set; }
//        public string Name { get; set; } = string.Empty;
//        public string? Description { get; set; }

//        public int? ParentCategoryId { get; set; }
//        public Category? ParentCategory { get; set; }

//        public ICollection<Category> SubCategories { get; set; } = new List<Category>();
//        public ICollection<Course> Courses { get; set; } = new List<Course>();
//    }

//    public class Course
//    {
//        public int Id { get; set; }
//        public string Title { get; set; } = string.Empty;
//        public string? Description { get; set; }
//        public decimal Price { get; set; }
//        public CourseLevel Level { get; set; }
//        public bool IsPublished { get; set; }
//        public DateTime? PublishedAt { get; set; }

//        public int InstructorId { get; set; }
//        public Instructor Instructor { get; set; } = null!;

//        public int CategoryId { get; set; }
//        public Category Category { get; set; } = null!;

//        public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
//    }

//    public class Student
//    {
//        public int Id { get; set; }
//        public string FullName { get; set; } = string.Empty;
//        public string Email { get; set; } = string.Empty;
//        public DateTime DateOfBirth { get; set; }

//        public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
//    }

//    public class Enrollment
//    {
//        public int StudentId { get; set; }
//        public Student Student { get; set; } = null!;

//        public int CourseId { get; set; }
//        public Course Course { get; set; } = null!;

//        public DateTime EnrolledAt { get; set; }
//        public decimal ProgressPercentage { get; set; }
//        public EnrollmentStatus Status { get; set; }
//        public decimal? FinalGrade { get; set; }
//    }
//}