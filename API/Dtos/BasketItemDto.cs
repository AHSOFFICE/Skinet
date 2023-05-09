using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
    public class BasketItemDto
    {
        [Required]
        public int Id { get; set; }
        

        [Required]
        public string ProductName { get; set; }

        [Required]
        public decimal Price { get; set; }
        
        [Required]
        public int Quantity { get; set; }

        public string PictureUrl { get; set; }

        public string Brand { get; set; }
        public string Type { get; set; }
    }
}