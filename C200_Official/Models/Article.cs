using System;
using System.Collections.Generic;

using System.ComponentModel.DataAnnotations;

#nullable disable

namespace C200_Official.Models
{
    public partial class Article
    {
        public Article()
        {
            ArticleComments = new HashSet<ArticleComment>();
            ArticleRatings = new HashSet<ArticleRating>();
        }

        public int Id { get; set; }
        [Required(ErrorMessage = "Please Enter Title.")]
        [StringLength(80, MinimumLength = 10, ErrorMessage = "Title does not meet length(10-80 characters only)")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please Enter Content.")]
        [StringLength(80, MinimumLength = 10, ErrorMessage = "Content does not meet length(10-80 characters only)")]
        public string Content { get; set; }
        public string Status { get; set; }
        public DateTime SubmittedOn { get; set; }
        public DateTime? PublishedOn { get; set; }
        public string AiFlag { get; set; }
        public int CategoryId { get; set; }
        public int MemberId { get; set; }
        public string Picture { get; set; }

        public virtual Category Category { get; set; }
        public virtual Member Member { get; set; }
        public virtual ICollection<ArticleComment> ArticleComments { get; set; }
        public virtual ICollection<ArticleRating> ArticleRatings { get; set; }
    }
}
