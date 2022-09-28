using Microsoft.EntityFrameworkCore;

namespace CampProject.Models
{
    [Keyless]
    public class Favorites_quizzes
    {
        public int user_id { get; set; }

        public int QuizId {get; set;}

        public virtual Quiz Quiz { get; set; }  

    }
}
