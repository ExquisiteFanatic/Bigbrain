using System.ComponentModel.DataAnnotations;

namespace BigbrainProject.Models
{
    public class KidModel
    {
        public Guid Id { get; set; }
        [Required]
        public string? Firstname { get; set; }
        [Required]
        public string Lastname { get; set; }
        public DateTime Birthday { get; set; }
    }
}
