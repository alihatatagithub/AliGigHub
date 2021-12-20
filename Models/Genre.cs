using System.ComponentModel.DataAnnotations;

namespace GigHub.Models
{
    //Type
    public class Genre 
    {
        [Key]
        public byte Id { get; set; }
        [Required]
        [StringLength(250)]
        public string Name { get; set; }
    }
}