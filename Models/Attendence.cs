using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GigHub.Models
{
    //The Res of M To M Between Gis and User
    public class Attendence
    {
        public Gig Gig { get; set; }
        public ApplicationUser Attendee { get; set; }
        [Key]
        [Column(Order =1)]
        [ForeignKey("Gig")]
        public int GigId { get; set; }
        [Key]
        [Column(Order = 2)]
        [ForeignKey("Attendee")]
        public string AttendeeId { get; set; }
    }
}