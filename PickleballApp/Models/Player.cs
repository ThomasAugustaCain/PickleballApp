using System.ComponentModel.DataAnnotations;

namespace PickleballApp.Models
{
    public class Player
    {
        //EF Core will configure the database to generate this value
        public int PlayerId { get; set; }

        [Required(ErrorMessage = "Please enter a name.")]
        public string Name { get; set; } = string.Empty;

        // I will add this at a later date
        //[Required(ErrorMessage = "Please enter a birth date.")]
        ////[Range(DateTime.Today.AddYears(-100), DateTime.Today.AddYears(-5), ErrorMessage = "A Player must be a least 5 years old.")]
        //// I need to create a custom validation type to perform the above code
        //public DateTime BirthDate { get; set; }

        public string? Gender { get; set; }

    }
}
