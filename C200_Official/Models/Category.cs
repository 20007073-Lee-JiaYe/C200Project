using System;
using System.Collections.Generic;

#nullable disable

namespace C200_Official.Models
{
    public partial class Category
    {
        public Category()
        {
            Articles = new HashSet<Article>();
            Programmes = new HashSet<Programme>();
            Questions = new HashSet<Question>();
            Videos = new HashSet<Video>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Article> Articles { get; set; }
        public virtual ICollection<Programme> Programmes { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
        public virtual ICollection<Video> Videos { get; set; }
    }
}
