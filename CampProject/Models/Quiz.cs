namespace CampProject.Models
{
    public class Quiz
    {
        public int QuizId { get; set; } 
        public string? Title { get; set; }    

        public virtual List<Question> Questions { get; set; }


    }
}
