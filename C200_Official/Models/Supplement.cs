using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace C200_Official.Models
{
    public partial class Supplement
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter username")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please include a picture")]
        public string Picture { get; set; }
        [Required(ErrorMessage = "Please enter description")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Please enter suggested usage")]
        public string SuggestedUse { get; set; }
        [Required(ErrorMessage = "Please enter warning")]
        public string Warnings { get; set; }
        public int SupplementTypeId { get; set; }
        public int MemberId { get; set; }
        public string Status { get; set; }

        public virtual Member Member { get; set; }
        public virtual SupplementType SupplementType { get; set; }
    }
}
