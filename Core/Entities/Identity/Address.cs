using System.ComponentModel.DataAnnotations;

namespace Core.Entities.Identity
{
    public class Address
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
<<<<<<< HEAD

=======
    
>>>>>>> 647186f6de55babfb6ca38d31d673b920360f367
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }
<<<<<<< HEAD

=======
    
>>>>>>> 647186f6de55babfb6ca38d31d673b920360f367
    }
}