using GigHub.Models;
using GigHub.ViewModels;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GigHub.Controllers
{
    public class AttendancesController : ApiController
    {
        private ApplicationDbContext _context;
        public AttendancesController()
        {
            _context = new ApplicationDbContext();
        }
        [HttpPost]
        public IHttpActionResult Attend(AttendanceDto attendanceDto)
        {
            var userId = User.Identity.GetUserId();
            if (_context.Attendences.Any(a => a.GigId == attendanceDto.GigId && a.AttendeeId == userId))
            {
                return BadRequest("The Attendence Already Exists");
            }
            var attendance = new Attendence
            {
                GigId = attendanceDto.GigId,
                AttendeeId = User.Identity.GetUserId()
            };
            _context.Attendences.Add(attendance);
            _context.SaveChanges();
            return Ok();

        }
    }
}
