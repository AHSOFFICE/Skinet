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
    public class AddressDto
    {
<<<<<<< HEAD
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Street { get; set; }
        [Required]
        public string City { get; set; }

        [Required]
        public string State { get; set; }

        [Required]
=======

        [Required]  
        public string FirstName { get; set; }
        [Required]  
        public string LastName { get; set; }
        [Required]  
        public string Street { get; set; }
        [Required]  
        public string City { get; set; }
         [Required]  
        public string State { get; set; }
        [Required]  
>>>>>>> 647186f6de55babfb6ca38d31d673b920360f367
        public string ZipCode { get; set; }
    }
}