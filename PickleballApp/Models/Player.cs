using System.ComponentModel.DataAnnotations;

namespace PickleballApp.Models
{
    public class Player
    {
        //EF Core will configure the database to generate this value
        public int PlayerId { get; set; }

        [Required(ErrorMessage = "Please enter a first name.")]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a last name.")]
        public string LastName { get; set; } = string.Empty;
        // I will add this at a later date
        //[Required(ErrorMessage = "Please enter a birth date.")]
        ////[Range(DateTime.Today.AddYears(-100), DateTime.Today.AddYears(-5), ErrorMessage = "A Player must be a least 5 years old.")]
        //// I need to create a custom validation type to perform the above code
        //public DateTime BirthDate { get; set; }
        [Required(ErrorMessage = "Please select a gender")]
        public string? Gender { get; set; }

    }
}
