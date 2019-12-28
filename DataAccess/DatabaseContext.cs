using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataAccess
{ 
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
        : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CoursePart> CourseParts { get; set; }
        public DbSet<CoursePartElement> CoursePartElements { get; set; }

    }

    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        public string EMail { get; set; }
        [Key]
        public int Id { get; set; }

    }

    public class Course
    {
        public string Name { get; set; }
        public string Description { get; set; }
        
        [Key]
        public int Id { get; set; }
    }

    public class CoursePart
    {
        public CoursePartType Type { get; set; }
        public ICollection<CoursePartElement> Elements { get; set; }
        public virtual CoursePart Parent { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public int? ParentId { get; set; }

        [Key]
        public int Id { get; set; }
    }

    public class CoursePartElement
    {
        public ElementType Type { get; set; }

        [Key]
        public int Id { get; set; }
        public string TextValue { get; set; }
        public string VideoLink { get; set; }
        public int? TestId { get; set; }
    }
       
    public enum CoursePartType
    { 
        Module,
        Lesson
    }

    public enum ElementType
    { 
        Text,
        Video,
        Test
    }

}

