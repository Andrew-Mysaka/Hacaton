using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataAccess
{
    public class Account
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public int? AccountHeroesId { get; set; }
        public virtual ICollection<AccountHeroes> AccountHeroes { get; set; }
    }
}

