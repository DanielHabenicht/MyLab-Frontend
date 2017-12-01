using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using myLabDockerAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace myLabDockerAPI.Controllers
{
    [Route("api/[controller]")]
    public class DeviceController : Controller
    {
        private readonly DeviceContext _context;

        public DeviceController(DeviceContext context)
        {
            _context = context;

            if (_context.DeviceItems.Count() == 0)
            {
                _context.DeviceItems.Add(new DeviceItem { Title = "Item1" });
                _context.SaveChanges();
            }
        }

        // GET: api/device
        [HttpGet]
        public IEnumerable<DeviceItem> GetAll()
        {
            return _context.DeviceItems.ToList();
        }

        // GET: api/device/{id}
        [HttpGet("{id}", Name = "GetDevice")]
        public IActionResult GetById(long id)
        {
            var item = _context.DeviceItems.FirstOrDefault(t => t.Id == id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }
    }
}
