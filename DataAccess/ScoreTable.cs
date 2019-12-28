using System;
using System.ComponentModel.DataAnnotations;

namespace DataAccess
{
    public class ScoreTable
    {
        [Key]
        public int Id { get; set; }

        public int AccountId { get; set; }
        public virtual Account Account { get; set; }
        public double Score { get; set; }
        public DateTime Date { get; set; }
    }
}

