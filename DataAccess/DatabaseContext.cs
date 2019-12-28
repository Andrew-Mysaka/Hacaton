using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CoursePart> CourseParts { get; set; }
        public DbSet<CoursePartElement> CoursePartElements { get; set; }
        public DbSet<Bot> Bots { get; set; }
        public DbSet<Hero> Heroes { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<AccountHeroes> AccountHeroes { get; set; }
        public DbSet<BotAction> BotActions { get; set; }
        public DbSet<ScoreTable> ScoreTables { get; set; }
        public DbSet<Answer> Answers { get; set; }
    }
}

