using System;
using System.Collections.Generic;

#nullable disable

namespace C200_Official.Models
{
    public partial class VideoRating
    {
        public int Id { get; set; }
        public int Ratings { get; set; }
        public int? MemberId { get; set; }
        public int VideoId { get; set; }

        public virtual Member Member { get; set; }
        public virtual Video Video { get; set; }
    }
}
