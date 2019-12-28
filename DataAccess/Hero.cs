using System.ComponentModel.DataAnnotations;

namespace DataAccess
{
    public class Hero
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Logo { get; set; }
    }
}

