namespace CampProject.Models
{
    public class Answer
    {
        public int id { get; set; } 
        public string? Text { get; set; }    

        public int QuestionId { get; set; } 
        public virtual Question Question { get; set; }  

    }
}
