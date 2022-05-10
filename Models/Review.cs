using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace reviewProject.Models
{
    public class Review
    {
        

        [Key]
        public int Id { get; set; }

       
        public int RangeResult { get; set; }

        [Required]
        public DateTime Date { get; set; } = DateTime.Now;

        public virtual Question QuestionModel { get; set; }
        [ForeignKey(nameof(QuestionModel))]
        public int QuesId { get; set; }

    }
}
