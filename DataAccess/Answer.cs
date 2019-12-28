using System.ComponentModel.DataAnnotations;

namespace DataAccess
{
    public class Answer
    {
        [Key]
        public int Id { get; set; }
        public string Text { get; set; }
        public bool IsCorrect { get; set; }
        public double Points { get; set; }
    }
}

