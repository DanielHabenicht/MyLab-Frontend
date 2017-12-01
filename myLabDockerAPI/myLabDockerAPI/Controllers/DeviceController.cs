using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using myLabDockerAPI.Data;
using myLabDockerAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace myLabDockerAPI.Controllers
{
    [Route("api/[controller]")]
    public class DeviceController : Controller
    {
        private readonly MyLabContext _context;

        public DeviceController(MyLabContext context)
        {
            _context = context;

            if (_context.Devices.Count() == 0)
            {
                _context.Devices.Add(new Device { Title = "Item1" });
                _context.SaveChanges();
            }
        }

        // GET: api/device
        [HttpGet]
        public IEnumerable<Device> GetAll()
        {
            return _context.Devices.ToList();
        }

        // GET: api/device/{id}
        [HttpGet("{id}", Name = "GetDevice")]
        public IActionResult GetById(long id)
        {
            var item = _context.Devices.FirstOrDefault(t => t.Id == id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }
    }
}
