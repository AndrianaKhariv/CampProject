namespace CampProject.Models
{
    public class Question
    {
        public int QuestionId { get; set; } 

        public string? Name { get; set; }    

        public virtual List<Answer> Answers { get; set; }  

        public int QuizId { get; set; } 

        public Quiz Quiz { get; set; }   
    }
}
