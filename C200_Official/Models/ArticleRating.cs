using System;
using System.Collections.Generic;

#nullable disable

namespace C200_Official.Models
{
    public partial class ArticleRating
    {
        public int Id { get; set; }
        public int ArticleId { get; set; }
        public int? MemberId { get; set; }
        public int Ratings { get; set; }

        public virtual Article Article { get; set; }
        public virtual Member Member { get; set; }
    }
}
