using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiMusor.Context;
using WebApiMusor.Entities;

namespace WebApiMusor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReadContorller : ControllerBase
    {
        private readonly MyDbContext _context;

        public ReadContorller(MyDbContext context)
        {
            _context = context;
        }
        
        [HttpGet("GetGuest/{guestId}")]
        public ActionResult<GuestDto> GetGuest(int guestId)
        {
            var searchGuest = _context.Guests.Find(guestId);
            if (searchGuest == null)
                return NotFound("Нету такого");
            return (GuestDto)searchGuest;
        }
    }
}
