using System.ComponentModel.DataAnnotations;
//Required to turn off validation for player properties
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
namespace PickleballApp.Models
{
    public class Team
    {
        //EF Core will configure the database to generate this value
        public int TeamId { get; set; }

        [ValidateNever]
        Player Player1 { get; set; } = null!;
        [ValidateNever]
        Player Player2 { get; set; } = null!;

    }
}
