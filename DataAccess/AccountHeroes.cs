using System.ComponentModel.DataAnnotations;

namespace DataAccess
{
    public class AccountHeroes
    {
        [Key]
        public int Id { get; set; }
        public int AccountId { get; set; }
        public int HeroId { get; set; }
        public virtual Hero Hero { get; set; }
    }
}

