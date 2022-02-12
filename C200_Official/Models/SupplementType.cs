using System;
using System.Collections.Generic;

#nullable disable

namespace C200_Official.Models
{
    public partial class SupplementType
    {
        public SupplementType()
        {
            Supplements = new HashSet<Supplement>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Benefits { get; set; }

        public virtual ICollection<Supplement> Supplements { get; set; }
    }
}
