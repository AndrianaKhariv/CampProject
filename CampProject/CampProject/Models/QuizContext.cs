using Microsoft.EntityFrameworkCore;

namespace CampProject.Models
{
    public class QuizContext : DbContext
    {
        public DbSet<Quiz> Quizs { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Statistics> Statistics { get; set; }
        public DbSet<Favorites_quizzes> favoritesQuizzes { get; set; }

        public QuizContext(DbContextOptions<QuizContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }


}
