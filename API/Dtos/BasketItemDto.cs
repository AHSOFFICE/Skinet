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
    public class BasketItemDto
    {
        [Required]
<<<<<<< HEAD
        public int Id { get; set; }
        

        [Required]
        public string ProductName { get; set; }

        [Required]
        public decimal Price { get; set; }
        
        [Required]
        public int Quantity { get; set; }

        public string PictureUrl { get; set; }

        public string Brand { get; set; }
=======
         public int Id { get; set; }
         [Required]
         public string ProductName{ get; set; }

        [Required]
        [Range(0.1, double.MaxValue, ErrorMessage ="Price must be greater then zero")]
         public decimal Price { get; set; }
        
        [Required]
        [Range(1, double.MaxValue , ErrorMessage ="Quantity must be at least 1")]

         public int Quantity { get; set; }

        [Required]
        public string PictureUrl { get; set; }

        [Required]
        public string Brand { get; set; }
        
        [Required]
>>>>>>> 647186f6de55babfb6ca38d31d673b920360f367
        public string Type { get; set; }
    }
}