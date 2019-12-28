using System.ComponentModel.DataAnnotations;

namespace DataAccess
{
    public class Course
    {
        public string Name { get; set; }
        public string Description { get; set; }

        [Key]
        public int Id { get; set; }
    }
}

