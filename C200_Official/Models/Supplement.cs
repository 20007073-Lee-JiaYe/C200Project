using System;
using System.Collections.Generic;

#nullable disable

namespace C200_Official.Models
{
    public partial class Supplement
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Picture { get; set; }
        public string Description { get; set; }
        public string SuggestedUse { get; set; }
        public string Warnings { get; set; }
        public int SupplementTypeId { get; set; }
        public int MemberId { get; set; }
        public string Status { get; set; }

        public virtual Member Member { get; set; }
        public virtual SupplementType SupplementType { get; set; }
    }
}
