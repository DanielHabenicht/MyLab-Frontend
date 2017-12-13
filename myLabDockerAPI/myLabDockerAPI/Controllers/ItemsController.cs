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
    /// <summary>
    /// Controller for all API Request to 'api/items'
    /// </summary>
    [Route("api/[controller]")]
    public class ItemsController : Controller
    {
        private readonly MyLabContext _context;

        /// <summary>
        /// Initializes the _context
        /// </summary>
        /// <param name="context"></param>
        public ItemsController(MyLabContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Returns all Items from the Database
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        /// 
        /// </remarks>
        /// <returns>All Items</returns>
        [HttpGet]
        public IEnumerable<Item> GetAll()
        {
            return _context.Items
                .Include(d => d.Category)
                    .ThenInclude(c => c.Laboratory)
                .Include(d => d.ItemAttributes)
                .Include(d => d.State)
                .ToList();
        }

        /// <summary>
        /// Returns a Item with the given id.
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        /// 
        /// </remarks>
        /// <param name="id"></param>
        /// <returns>A Item with the given id</returns>
        /// <response code="201">If the Item was found.</response>
        /// <response code="404">If the Item could not be found.</response>   
        [HttpGet("{id}", Name = "GetItem")]
        public IActionResult GetById([FromRoute]long id)
        {
            var item = _context.Items.FirstOrDefault(t => t.Id == id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }

        /// <summary>
        /// Creates a new Item.
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        /// 
        /// </remarks>
        /// <param name="Item"></param>
        /// <returns>A newly-created Item</returns>
        /// <response code="201">Returns the newly-created Item</response>
        /// <response code="400">If the item is null</response>            
        [HttpPost]
        [ProducesResponseType(typeof(Item), 201)]
        [ProducesResponseType(typeof(Item), 400)]
        public IActionResult Create([FromBody] Item Item)
        {
            ModelState.Remove("Id");
            if (Item == null)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Items.Add(Item);
            _context.SaveChanges();

            return CreatedAtRoute("GetItem", new { id = Item.Id }, Item);
        }

        /// <summary>
        /// Updates an existing Item.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///     PUT /Items/{id}
        /// 
        /// 
        /// </remarks>
        /// <param name="id"></param>
        /// <param name="Item"></param>
        /// <returns>Nothing</returns>
        [HttpPut("{id}")]
        public IActionResult Update([FromRoute] long id, [FromBody] Item Item)
        {
            if (Item == null || Item.Id != id)
            {
                return BadRequest();
            }

            var item = _context.Items.FirstOrDefault(d => d.Id == id);
            if(item == null)
            {
                return NotFound();
            }

            item.Barcode = Item.Barcode;
            item.Location = Item.Location;
            item.State = Item.State;
            item.Title = Item.Title;
            item.Comment = Item.Comment;

            _context.Items.Update(item);
            _context.SaveChanges();
            return new NoContentResult();
        }
    }
}
