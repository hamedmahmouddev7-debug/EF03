//using Microsoft.EntityFrameworkCore;

//namespace LearningPlatform
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            using var context = new LearningContext();

//            context.Database.Migrate();

//            Console.WriteLine("==================================");
//            Console.WriteLine("       LEARNING PLATFORM");
//            Console.WriteLine("==================================");

//            SeedStudentsAndEnrollments(context);

//            Console.WriteLine("\n========== CREATE ==========");
//            AddInstructor(context);
//            AddCourse(context);
//            AddInvalidCourse(context);
//            AddStudents(context);
//            EnrollStudent(context);
//            EnrollStudentAgain(context);
//            EnrollInUnpublishedCourse(context);

//            Console.WriteLine("\n========== READ ==========");
//            ReadCourseById(context, 2);
//            ReadCourseByTitle(context, "Python for Beginners");
//            ReadMissingCourse(context, 999);
//            ReadCoursesByPrice(context);
//            ReadSubCategories(context, 1);
//            ReadTopCategories(context);
//            ReadCourseRoster(context, 1);

//            Console.WriteLine("\n========== UPDATE ==========");
//            ChangeCoursePrice(context, 3, 899m);
//            UpdateStudentProgress(context, 1, 1, 100);
//            UpdateStudentProgress(context, 1, 1, 150);
//            PublishCourse(context, 5);

//            Console.WriteLine("\n========== DELETE ==========");
//            UnenrollStudent(context, 3, 4);
//            DeleteCategoryUnsafe(context, 1);
//            DeleteCategorySafe(context, 1);
//            DeleteCourse(context, 1);

//            Console.WriteLine("\n========== BULK OPERATIONS ==========");
//            BulkPriceRaise(context);
//            BulkDeleteDroppedEnrollments(context);

//            Console.WriteLine("\n==================================");
//            Console.WriteLine("        PROGRAM FINISHED");
//            Console.WriteLine("==================================");

//            Console.ReadKey();
//        }

//        // =========================================
//        // SEED STUDENTS AND ENROLLMENTS
//        // =========================================

//        static void SeedStudentsAndEnrollments(LearningContext context)
//        {
//            if (!context.Students.Any())
//            {
//                var students = new List<Student>
//                {
//                    new Student
//                    {
//                        Id = 1,
//                        FullName = "Ahmed Ali",
//                        Email = "ahmed@student.com",
//                        DateOfBirth = new DateTime(2002, 5, 10)
//                    },
//                    new Student
//                    {
//                        Id = 2,
//                        FullName = "Mona Hassan",
//                        Email = "mona@student.com",
//                        DateOfBirth = new DateTime(2001, 8, 15)
//                    },
//                    new Student
//                    {
//                        Id = 3,
//                        FullName = "Khaled Samir",
//                        Email = "khaled@student.com",
//                        DateOfBirth = new DateTime(2003, 2, 20)
//                    },
//                    new Student
//                    {
//                        Id = 4,
//                        FullName = "Salma Adel",
//                        Email = "salma@student.com",
//                        DateOfBirth = new DateTime(2002, 11, 5)
//                    },
//                    new Student
//                    {
//                        Id = 5,
//                        FullName = "Dina Mohamed",
//                        Email = "dina@student.com",
//                        DateOfBirth = new DateTime(2001, 4, 12)
//                    }
//                };

//                context.Students.AddRange(students);
//                context.SaveChanges();

//                Console.WriteLine("Students seeded successfully.");
//            }

//            if (!context.Enrollments.Any())
//            {
//                var enrollments = new List<Enrollment>
//                {
//                    new Enrollment
//                    {
//                        StudentId = 1,
//                        CourseId = 1,
//                        EnrolledAt = new DateTime(2024, 5, 1),
//                        ProgressPercentage = 40,
//                        Status = EnrollmentStatus.Active
//                    },
//                    new Enrollment
//                    {
//                        StudentId = 1,
//                        CourseId = 2,
//                        EnrolledAt = new DateTime(2024, 5, 2),
//                        ProgressPercentage = 20,
//                        Status = EnrollmentStatus.Active
//                    },
//                    new Enrollment
//                    {
//                        StudentId = 2,
//                        CourseId = 1,
//                        EnrolledAt = new DateTime(2024, 5, 3),
//                        ProgressPercentage = 100,
//                        Status = EnrollmentStatus.Completed,
//                        FinalGrade = 95
//                    },
//                    new Enrollment
//                    {
//                        StudentId = 3,
//                        CourseId = 4,
//                        EnrolledAt = new DateTime(2024, 5, 4),
//                        ProgressPercentage = 10,
//                        Status = EnrollmentStatus.Dropped
//                    },
//                    new Enrollment
//                    {
//                        StudentId = 4,
//                        CourseId = 3,
//                        EnrolledAt = new DateTime(2024, 5, 5),
//                        ProgressPercentage = 60,
//                        Status = EnrollmentStatus.Active
//                    },
//                    new Enrollment
//                    {
//                        StudentId = 5,
//                        CourseId = 3,
//                        EnrolledAt = new DateTime(2024, 5, 6),
//                        ProgressPercentage = 30,
//                        Status = EnrollmentStatus.Active
//                    },
//                    new Enrollment
//                    {
//                        StudentId = 2,
//                        CourseId = 3,
//                        EnrolledAt = new DateTime(2024, 5, 7),
//                        ProgressPercentage = 100,
//                        Status = EnrollmentStatus.Completed,
//                        FinalGrade = 90
//                    },
//                    new Enrollment
//                    {
//                        StudentId = 4,
//                        CourseId = 4,
//                        EnrolledAt = new DateTime(2024, 5, 8),
//                        ProgressPercentage = 0,
//                        Status = EnrollmentStatus.Dropped
//                    }
//                };

//                context.Enrollments.AddRange(enrollments);
//                context.SaveChanges();

//                Console.WriteLine("Enrollments seeded successfully.");
//            }
//        }

//        // =========================================
//        // CREATE OPERATIONS
//        // =========================================

//        static void AddInstructor(LearningContext context)
//        {
//            string email = "hany@learn.com";

//            var existingInstructor = context.Instructors
//                .FirstOrDefault(i => i.Email == email);

//            if (existingInstructor != null)
//            {
//                Console.WriteLine("Instructor already exists.");
//                return;
//            }

//            var instructor = new Instructor
//            {
//                FullName = "Hany Fawzy",
//                Email = email,
//                Bio = "Cloud trainer",
//                JoinedAt = DateTime.Now
//            };

//            context.Instructors.Add(instructor);
//            context.SaveChanges();

//            Console.WriteLine("Instructor added successfully.");
//        }

//        static void AddCourse(LearningContext context)
//        {
//            if (context.Courses.Any(c => c.Title == "Docker Essentials"))
//            {
//                Console.WriteLine("Docker Essentials already exists.");
//                return;
//            }

//            var instructor = context.Instructors
//                .FirstOrDefault(i => i.Email == "hany@learn.com");

//            if (instructor == null)
//            {
//                Console.WriteLine("Instructor not found.");
//                return;
//            }

//            var course = new Course
//            {
//                Title = "Docker Essentials",
//                Description = "Introduction to Docker",
//                Price = 950m,
//                Level = CourseLevel.Beginner,
//                IsPublished = true,
//                PublishedAt = DateTime.Now,
//                InstructorId = instructor.Id,
//                CategoryId = 1
//            };

//            context.Courses.Add(course);
//            context.SaveChanges();

//            Console.WriteLine("Course added successfully.");
//        }

//        static void AddInvalidCourse(LearningContext context)
//        {
//            var course = new Course
//            {
//                Title = "Ghost Course",
//                Description = "This course has an invalid instructor.",
//                Price = 100m,
//                Level = CourseLevel.Beginner,
//                IsPublished = false,
//                InstructorId = 999,
//                CategoryId = 1
//            };

//            context.Courses.Add(course);

//            try
//            {
//                context.SaveChanges();
//                Console.WriteLine("Invalid course was added.");
//            }
//            catch (DbUpdateException)
//            {
//                Console.WriteLine("Course rejected because the instructor does not exist.");

//                context.ChangeTracker.Clear();
//            }
//        }

//        static void AddStudents(LearningContext context)
//        {
//            var students = new List<Student>
//            {
//                new Student
//                {
//                    FullName = "Student One",
//                    Email = $"student1_{Guid.NewGuid()}@student.com",
//                    DateOfBirth = new DateTime(2002, 1, 10)
//                },
//                new Student
//                {
//                    FullName = "Student Two",
//                    Email = $"student2_{Guid.NewGuid()}@student.com",
//                    DateOfBirth = new DateTime(2001, 3, 15)
//                },
//                new Student
//                {
//                    FullName = "Student Three",
//                    Email = $"student3_{Guid.NewGuid()}@student.com",
//                    DateOfBirth = new DateTime(2003, 7, 20)
//                }
//            };

//            context.Students.AddRange(students);
//            context.SaveChanges();

//            Console.WriteLine("Three students added successfully.");
//        }

//        static void EnrollStudent(LearningContext context)
//        {
//            var enrollment = new Enrollment
//            {
//                StudentId = 5,
//                CourseId = 1,
//                EnrolledAt = DateTime.Now,
//                ProgressPercentage = 0,
//                Status = EnrollmentStatus.Active
//            };

//            context.Enrollments.Add(enrollment);

//            try
//            {
//                context.SaveChanges();
//                Console.WriteLine("Student enrolled successfully.");
//            }
//            catch (DbUpdateException)
//            {
//                Console.WriteLine("Enrollment failed.");

//                context.ChangeTracker.Clear();
//            }
//        }

//        static void EnrollStudentAgain(LearningContext context)
//        {
//            var enrollment = new Enrollment
//            {
//                StudentId = 5,
//                CourseId = 1,
//                EnrolledAt = DateTime.Now,
//                ProgressPercentage = 0,
//                Status = EnrollmentStatus.Active
//            };

//            context.Enrollments.Add(enrollment);

//            try
//            {
//                context.SaveChanges();
//                Console.WriteLine("Enrollment added.");
//            }
//            catch (DbUpdateException)
//            {
//                Console.WriteLine("Enrollment rejected: student is already enrolled.");

//                context.ChangeTracker.Clear();
//            }
//        }

//        static void EnrollInUnpublishedCourse(LearningContext context)
//        {
//            var course = context.Courses.Find(5);

//            if (course == null || !course.IsPublished)
//            {
//                Console.WriteLine("Cannot enroll: course is not published.");
//                return;
//            }

//            Console.WriteLine("Course is published and available.");
//        }

//        // =========================================
//        // READ OPERATIONS
//        // =========================================

//        static void ReadCourseById(LearningContext context, int id)
//        {
//            var course = context.Courses
//                .Include(c => c.Instructor)
//                .Include(c => c.Category)
//                .FirstOrDefault(c => c.Id == id);

//            if (course == null)
//            {
//                Console.WriteLine("Course not found.");
//                return;
//            }

//            Console.WriteLine($"Course: {course.Title}");
//            Console.WriteLine($"Instructor: {course.Instructor.FullName}");
//            Console.WriteLine($"Category: {course.Category.Name}");
//            Console.WriteLine($"Price: {course.Price}");
//        }

//        static void ReadCourseByTitle(LearningContext context, string title)
//        {
//            var course = context.Courses
//                .FirstOrDefault(c => c.Title == title);

//            if (course == null)
//            {
//                Console.WriteLine("Course title not found.");
//                return;
//            }

//            Console.WriteLine($"Found course: {course.Title}");
//        }

//        static void ReadMissingCourse(LearningContext context, int id)
//        {
//            var course = context.Courses.Find(id);

//            Console.WriteLine(
//                course == null
//                    ? $"Course with ID {id} does not exist."
//                    : $"Course found: {course.Title}"
//            );
//        }

//        static void ReadCoursesByPrice(LearningContext context)
//        {
//            var courses = context.Courses
//                .Where(c => c.Price >= 800 && c.Price <= 1500)
//                .OrderBy(c => c.Price)
//                .ToList();

//            Console.WriteLine("Courses priced between 800 and 1500:");

//            foreach (var course in courses)
//            {
//                Console.WriteLine($"{course.Title} - {course.Price}");
//            }
//        }

//        static void ReadSubCategories(LearningContext context, int categoryId)
//        {
//            var category = context.Categories
//                .Include(c => c.SubCategories)
//                .FirstOrDefault(c => c.Id == categoryId);

//            if (category == null)
//            {
//                Console.WriteLine("Category not found.");
//                return;
//            }

//            Console.WriteLine($"Subcategories of {category.Name}:");

//            foreach (var subCategory in category.SubCategories)
//            {
//                Console.WriteLine(subCategory.Name);
//            }
//        }

//        static void ReadTopCategories(LearningContext context)
//        {
//            var categories = context.Categories
//                .Where(c => c.ParentCategoryId == null)
//                .ToList();

//            Console.WriteLine("Top-level categories:");

//            foreach (var category in categories)
//            {
//                Console.WriteLine(category.Name);
//            }
//        }

//        static void ReadCourseRoster(LearningContext context, int courseId)
//        {
//            var course = context.Courses
//                .Include(c => c.Enrollments)
//                    .ThenInclude(e => e.Student)
//                .FirstOrDefault(c => c.Id == courseId);

//            if (course == null)
//            {
//                Console.WriteLine("Course not found.");
//                return;
//            }

//            Console.WriteLine($"Students enrolled in {course.Title}:");

//            foreach (var enrollment in course.Enrollments)
//            {
//                Console.WriteLine(
//                    $"{enrollment.Student.FullName} - {enrollment.ProgressPercentage}%"
//                );
//            }
//        }

//        // =========================================
//        // UPDATE OPERATIONS
//        // =========================================

//        static void ChangeCoursePrice(
//            LearningContext context,
//            int courseId,
//            decimal newPrice)
//        {
//            var course = context.Courses.Find(courseId);

//            if (course == null)
//            {
//                Console.WriteLine("Course not found.");
//                return;
//            }

//            course.Price = newPrice;

//            context.SaveChanges();

//            Console.WriteLine($"Course price updated to {newPrice}.");
//        }

//        static void UpdateStudentProgress(
//            LearningContext context,
//            int studentId,
//            int courseId,
//            decimal progress)
//        {
//            if (progress < 0 || progress > 100)
//            {
//                Console.WriteLine("Invalid progress. It must be between 0 and 100.");
//                return;
//            }

//            var enrollment = context.Enrollments
//                .Find(studentId, courseId);

//            if (enrollment == null)
//            {
//                Console.WriteLine("Enrollment not found.");
//                return;
//            }

//            enrollment.ProgressPercentage = progress;

//            if (progress == 100)
//            {
//                enrollment.Status = EnrollmentStatus.Completed;
//            }

//            context.SaveChanges();

//            Console.WriteLine("Progress updated successfully.");
//        }

//        static void PublishCourse(LearningContext context, int courseId)
//        {
//            var course = context.Courses.Find(courseId);

//            if (course == null)
//            {
//                Console.WriteLine("Course not found.");
//                return;
//            }

//            course.IsPublished = true;
//            course.PublishedAt = DateTime.Now;

//            context.SaveChanges();

//            Console.WriteLine("Course published successfully.");
//        }

//        // =========================================
//        // DELETE OPERATIONS
//        // =========================================

//        static void UnenrollStudent(
//            LearningContext context,
//            int studentId,
//            int courseId)
//        {
//            var enrollment = context.Enrollments
//                .Find(studentId, courseId);

//            if (enrollment == null)
//            {
//                Console.WriteLine("Enrollment not found.");
//                return;
//            }

//            context.Enrollments.Remove(enrollment);
//            context.SaveChanges();

//            Console.WriteLine("Student unenrolled successfully.");
//        }

//        static void DeleteCategoryUnsafe(
//            LearningContext context,
//            int categoryId)
//        {
//            var category = context.Categories.Find(categoryId);

//            if (category == null)
//            {
//                Console.WriteLine("Category not found.");
//                return;
//            }

//            context.Categories.Remove(category);

//            try
//            {
//                context.SaveChanges();
//                Console.WriteLine("Category deleted.");
//            }
//            catch (DbUpdateException)
//            {
//                Console.WriteLine("Delete rejected because related records exist.");

//                context.ChangeTracker.Clear();
//            }
//        }

//        static void DeleteCategorySafe(
//            LearningContext context,
//            int categoryId)
//        {
//            var category = context.Categories
//                .Include(c => c.SubCategories)
//                .Include(c => c.Courses)
//                .FirstOrDefault(c => c.Id == categoryId);

//            if (category == null)
//            {
//                Console.WriteLine("Category not found.");
//                return;
//            }

//            if (category.SubCategories.Any() || category.Courses.Any())
//            {
//                Console.WriteLine(
//                    "Cannot delete category: it has subcategories or courses."
//                );
//                return;
//            }

//            context.Categories.Remove(category);
//            context.SaveChanges();

//            Console.WriteLine("Category deleted safely.");
//        }

//        static void DeleteCourse(LearningContext context, int courseId)
//        {
//            var course = context.Courses.Find(courseId);

//            if (course == null)
//            {
//                Console.WriteLine("Course not found.");
//                return;
//            }

//            context.Courses.Remove(course);
//            context.SaveChanges();

//            Console.WriteLine("Course deleted successfully.");
//            Console.WriteLine("Related enrollments are deleted through Cascade.");
//        }

//        // =========================================
//        // BULK OPERATIONS
//        // =========================================

//        static void BulkPriceRaise(LearningContext context)
//        {
//            int affectedRows = context.Courses
//                .Where(c =>
//                    c.Level == CourseLevel.Beginner &&
//                    c.IsPublished)
//                .ExecuteUpdate(setters =>
//                    setters.SetProperty(
//                        c => c.Price,
//                        c => c.Price * 1.10m
//                    )
//                );

//            Console.WriteLine(
//                $"Prices increased by 10% for {affectedRows} courses."
//            );
//        }

//        static void BulkDeleteDroppedEnrollments(LearningContext context)
//        {
//            int deletedRows = context.Enrollments
//                .Where(e => e.Status == EnrollmentStatus.Dropped)
//                .ExecuteDelete();

//            Console.WriteLine(
//                $"{deletedRows} dropped enrollments deleted."
//            );
//        }
//    }
//}