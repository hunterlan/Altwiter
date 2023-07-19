using System.ComponentModel.DataAnnotations;

namespace Login.Pages.Models
{
    public class EngagmentForm
    {
        [Required]
        public string Altweet { get; set; } = null!;
    }
}
