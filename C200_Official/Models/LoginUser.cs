using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace C200_Official.Models
{
    public class LoginUser
    {
        [Required(ErrorMessage = "Username cannot be empty!")]
        //[DataType(DataType.EmailAddress,
        //          ErrorMessage = "Use your registered username to login!")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Empty password not allowed!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public int Id { get; set; }
        public string UserName { get; set; }

        public bool RememberMe { get; set; }
}
}
