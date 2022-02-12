using System;
using System.Collections.Generic;

#nullable disable

namespace C200_Official.Models
{
    public partial class ArticleComment
    {
        public int Id { get; set; }
        public int ArticleId { get; set; }
        public string Content { get; set; }
        public int MemberId { get; set; }
        public DateTime DatePublished { get; set; }
        public string Status { get; set; }

        public virtual Article Article { get; set; }
        public virtual Member Member { get; set; }
    }
}
