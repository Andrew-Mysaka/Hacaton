using System.ComponentModel.DataAnnotations;

namespace DataAccess
{
    public enum ElementType
    {
        Text,
        Video,
        Test
    }

    public class CoursePartElement
    {
        public ElementType Type { get; set; }

        [Key]
        public int Id { get; set; }
        public string TextValue { get; set; }
        public string VideoLink { get; set; }
        public int? TestId { get; set; }

        public virtual Test Test { get; set; }
    }
}

