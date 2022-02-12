using System;
using System.Collections.Generic;

#nullable disable

namespace C200_Official.Models
{
    public partial class Member
    {
        public Member()
        {
            Answers = new HashSet<Answer>();
            ArticleComments = new HashSet<ArticleComment>();
            ArticleRatings = new HashSet<ArticleRating>();
            Articles = new HashSet<Article>();
            QuestionRatings = new HashSet<QuestionRating>();
            Questions = new HashSet<Question>();
            Supplements = new HashSet<Supplement>();
            VideoComments = new HashSet<VideoComment>();
            VideoRatings = new HashSet<VideoRating>();
            Videos = new HashSet<Video>();
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public byte[] Password { get; set; }
        public string Role { get; set; }
        public DateTime? LastLogin { get; set; }

        public virtual ICollection<Answer> Answers { get; set; }
        public virtual ICollection<ArticleComment> ArticleComments { get; set; }
        public virtual ICollection<ArticleRating> ArticleRatings { get; set; }
        public virtual ICollection<Article> Articles { get; set; }
        public virtual ICollection<QuestionRating> QuestionRatings { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
        public virtual ICollection<Supplement> Supplements { get; set; }
        public virtual ICollection<VideoComment> VideoComments { get; set; }
        public virtual ICollection<VideoRating> VideoRatings { get; set; }
        public virtual ICollection<Video> Videos { get; set; }
    }
}
