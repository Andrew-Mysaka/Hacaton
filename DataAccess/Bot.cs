using System.ComponentModel.DataAnnotations;

namespace DataAccess
{
    public enum BotRole
    {
        possitive,
        negative,
        neutral
    }

    public class Bot
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public BotRole Role { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
    }
}

