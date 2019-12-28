using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataAccess
{
    public enum CoursePartType
    {
        Module,
        Lesson
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
}

