using System.ComponentModel.DataAnnotations;

namespace Lab2.Models
{
    public class Rating
    {
     
        public int RatingId { get; set; }
      
        [Range(1, 10)]
        public int Level { get; set; }

       
        [Required(ErrorMessage = "Name must have more than 10 characters."), MinLength(10, ErrorMessage = "Min length is 10")]
        public string Comment { get; set; }
    
         public int RatedId { get; set; }
         public int Type { get; set; } //0:movie 1:actor

         public User? User{get;set;}

        [Required(ErrorMessage = "Name must have more than one character."), MinLength(2, ErrorMessage = "Min length is 2")]
        public string  UserName { get; set; }

    }
    
}
