using Microsoft.EntityFrameworkCore;

namespace CampProject.Models
{
    [Keyless]
    public class Statistics
    {
        public int User_id { get; set; }
        public int QuizId { get; set; }
        public virtual Quiz Quiz { get; set; }

    }
}
