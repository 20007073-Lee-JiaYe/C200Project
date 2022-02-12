using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace C200_Official.Models
{
    public partial class Video
    {
        public Video()
        {
            VideoComments = new HashSet<VideoComment>();
            VideoRatings = new HashSet<VideoRating>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Status { get; set; }

        [Required(ErrorMessage = "Please enter ONLY YouTube Links!")]
        [Url]
        public string Link { get; set; }
        public string Description { get; set; }
        public DateTime SubmittedOn { get; set; }
        public DateTime? DatePublished { get; set; }
        public int CategoryId { get; set; }
        public int MemberId { get; set; }

        public virtual Category Category { get; set; }
        public virtual Member Member { get; set; }
        public virtual ICollection<VideoComment> VideoComments { get; set; }
        public virtual ICollection<VideoRating> VideoRatings { get; set; }
    }
}
