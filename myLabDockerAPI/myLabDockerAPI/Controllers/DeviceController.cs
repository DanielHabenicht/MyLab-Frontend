using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using myLabDockerAPI.Data;
using myLabDockerAPI.Models;
using Microsoft.EntityFrameworkCore;

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
        }

        // GET: api/device
        [HttpGet]
        public IEnumerable<Device> GetAll()
        {
            return _context.Devices
                .Include(d => d.Category)
                    .ThenInclude(c => c.Laboratory)
                .Include(d => d.DeviceAttributes)
                .Include(d => d.State)
                .ToList();
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

        // Add a new Device
        // POST: api/device
        [HttpPost]
        public IActionResult Create([FromBody] Device device)
        {
            if (device == null)
            {
                return BadRequest();
            }

            _context.Devices.Add(device);
            _context.SaveChanges();

            return CreatedAtRoute("GetDevice", new { id = device.Id }, device);
        }

        // Update a device
        // PUT: api/device
        [HttpPut("{id}")]
        public IActionResult Update(long id, [FromBody] Device device)
        {
            if (device == null || device.Id != id)
            {
                return BadRequest();
            }

            var item = _context.Devices.FirstOrDefault(d => d.Id == id);
            if(item == null)
            {
                return NotFound();
            }

            item.InventoryNumber = device.InventoryNumber;
            item.Location = device.Location;
            item.State = device.State;
            item.Title = device.Title;
            item.Comment = device.Comment;

            _context.Devices.Update(item);
            _context.SaveChanges();
            return new NoContentResult();
        }
    }
}
