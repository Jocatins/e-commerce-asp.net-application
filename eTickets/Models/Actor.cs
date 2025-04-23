using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Actor
    {
        [Key]

        public int Id { get; set; }

        [DisplayName("Profile Picture")]
        [Required(ErrorMessage ="Profile Picture is Required")]
        public string ProfilePictureURL { get; set; }

        [DisplayName("Full Name")]
        [Required(ErrorMessage = "Full Name is Required")]
        [StringLength(40, MinimumLength = 6, ErrorMessage ="The characters should be between 6 and 40")]
        public string FullName { get; set; }

        [DisplayName("Biography")]
        [Required(ErrorMessage = "Bio is Required")]
        public string Bio { get; set; }

        // Relationship
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
