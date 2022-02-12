using System;
using System.Collections.Generic;

#nullable disable

namespace C200_Official.Models
{
    public partial class Answer
    {
        public int Id { get; set; }
        public int MemberId { get; set; }
        public DateTime AnsweredDate { get; set; }
        public string Description { get; set; }
        public int QuestionId { get; set; }
        public string Status { get; set; }

        public virtual Member Member { get; set; }
        public virtual Question Question { get; set; }
    }
}
