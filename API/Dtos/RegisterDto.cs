using System;
using System.Collections.Generic;
<<<<<<< HEAD
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
=======
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
>>>>>>> 647186f6de55babfb6ca38d31d673b920360f367

namespace API.Dtos
{
    public class RegisterDto
    {
<<<<<<< HEAD
        [Required]
        public String DisplayName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [RegularExpression("(?=^.{6,10}$)(?=.*\\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[!@#$%^&amp;*()_+}{&quot;:;'?/&gt;.&lt;,])(?!.*\\s).*$" , ErrorMessage ="Password must have 1 Uppercase, 1 Lowercase, 1 number, 1 non alphanumeric and at least 6 characters")]
=======
        [Required]  
        public String DisplayName { get; set; }
      
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [RegularExpression("(?=^.{6,10}$)(?=.*\\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[!@#$%^&amp;*()_+}{&quot;:;'?/&gt;.&lt;,])(?!.*\\s).*$", ErrorMessage = "Password must have 1 UpperCase , 1 Lowercase, 1 number, 1 non alphanumeric and at least 6 characters")]
>>>>>>> 647186f6de55babfb6ca38d31d673b920360f367
        public string Password { get; set; }
    }
}