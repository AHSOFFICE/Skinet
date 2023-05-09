using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace API.Dtos
{
    public class CustomerBasketDto
    {
        [Required]
<<<<<<< HEAD
         public string Id { get; set; }
=======
       public string Id { get; set; }
>>>>>>> 647186f6de55babfb6ca38d31d673b920360f367
        public List<BasketItemDto> Items { get; set; }
    }
}