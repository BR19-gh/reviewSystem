using System.ComponentModel.DataAnnotations;


namespace reviewProject.Models
{
    public class Question
    {
        [Key]
        public int Id { get; set; }
        
        [Required] 
        [Display(Name = "الأسئلة")]
        public string Questions { get; set; }
        
    }
}
