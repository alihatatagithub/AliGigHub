using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GigHub.Models
{
    public class Gig
    {
        [Key]
        public int Id { get; set; }

        public ApplicationUser Artist { get; set; }

        [Required]
        [ForeignKey("Artist")]
        public string ArtistId { get; set; }

        public DateTime DateTime { get; set; }

        [Required]
        [StringLength(250)]
        public string Venue { get; set; } //Where

        public Genre Genre { get; set; }

        [Required]
        [ForeignKey("Genre")]
        public byte GenreId { get; set; }

        public ICollection<Attendence> Attendences { get; set; }
    }
}