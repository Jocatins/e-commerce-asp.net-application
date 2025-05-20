using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using eTickets.Data.Base;

namespace eTickets.Models
{
    public class Actor: IEntityBase
    {
        [Key]

        public int Id { get; set; }


        [Required]
        public string ProfilePictureURL { get; set; } = "";

        [Required]
      
        public string FullName { get; set; } = "";

        //[DisplayName("Biography")]
        [Required]
        public string Bio { get; set; } = "";

        // Relationship
        public List<Actor_Movie>? Actors_Movies { get; set; }
    }
}
