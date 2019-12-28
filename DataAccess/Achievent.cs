using System.ComponentModel.DataAnnotations;

namespace DataAccess
{
    public class Achievent
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
    }
}

