using System;
using System.Collections.Generic;

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
        public string Title { get; set; }
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
