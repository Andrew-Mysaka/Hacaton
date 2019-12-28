using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataAccess
{
    public class Test
    {
        [Key]
        public int Id { get; set; }
        public double PassPoints { get; set; } 
        public virtual ICollection<Answer> Answers { get; set; }
    }
}

