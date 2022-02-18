using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


#nullable disable

namespace C200_Official.Models
{
    public partial class Programme
    {
        public int Id { get; set; }
    [Required(ErrorMessage ="Please enter title")]
        [StringLength(100, MinimumLength = 10, ErrorMessage = "Title does not meet length(10-80 characters only)")]
        public string Title { get; set; }
        public string PicFile { get; set; }
        public string Status { get; set; }

        [Required(ErrorMessage = "Please enter description")]
        [StringLength(80, MinimumLength = 10, ErrorMessage = "Title does not meet length(10-80 characters only)")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Please enter ONLY YouTube Links!")]
        [Url]

        public string Link { get; set; }
        [Required]
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}
