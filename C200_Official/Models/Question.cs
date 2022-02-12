using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace C200_Official.Models
{
    public partial class Question
    {
        public Question()
        {
            Answers = new HashSet<Answer>();
            QuestionRatings = new HashSet<QuestionRating>();
        }

        public int Id { get; set; }
        public int MemberId { get; set; }
        public DateTime DateCreated { get; set; }
        [Required(ErrorMessage ="Please enter a question")]
        public string Content { get; set; }
        [Required(ErrorMessage = "Please select a category")]
        public int CategoryId { get; set; }
        public string Status { get; set; }

        public virtual Category Category { get; set; }
        public virtual Member Member { get; set; }
        public virtual ICollection<Answer> Answers { get; set; }
        public virtual ICollection<QuestionRating> QuestionRatings { get; set; }
    }
}
