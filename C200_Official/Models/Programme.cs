using System;
using System.Collections.Generic;

#nullable disable

namespace C200_Official.Models
{
    public partial class Programme
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string PicFile { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}
