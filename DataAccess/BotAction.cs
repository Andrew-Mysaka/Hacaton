using System.ComponentModel.DataAnnotations;

namespace DataAccess
{
    public class BotAction
    {
        [Key]
        public int Id { get; set; }
        public int? HeroId { get; set; }
        public virtual Hero Hero { get; set; }
        public int BotId { get; set; }
        public virtual Bot Bot { get; set; }
        public string Action { get; set; }


    }

}

