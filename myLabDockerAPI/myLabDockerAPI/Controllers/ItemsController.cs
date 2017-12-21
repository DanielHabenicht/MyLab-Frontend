using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using myLabDockerAPI.Data;
using myLabDockerAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;

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
        public async Task<IEnumerable<Item>> GetAll()
        {
            return await _context.Items
                .Include(d => d.Category)
                .Include(d => d.ItemAttributes)
                .Include(d => d.State)
                .ToListAsync();
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
        public async Task<IActionResult> GetById([FromRoute]long id)
        {
            var item = await _context.Items
                .Include(i => i.ItemAttributes)
                .Include(i => i.Category)
                .Include(i => i.State)
                .FirstOrDefaultAsync(t => t.Id == id);
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
        /// POST /items
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
        public async Task<IActionResult> Create([FromBody] Item Item)
        {
            var newItem = new Item();
            newItem.Update(Item);
            if (Item == null)
            {
                return BadRequest("p");
            }

            // Checks if ModelState is Valid
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Checks if Barcode does already exist.
            if(_context.Items.FirstOrDefault(i => i.Barcode == Item.Barcode) != null)
            {
                return BadRequest("Barcode does already exists.");
            }

            //Checks if Category does exist.
            var category = _context.Categories.FirstOrDefault(l => l.Id == Item.CategoryId);
            if(category == null)
            {
                return BadRequest("Category does not exist.");
            }
            Item.Category = category;

            //Checks if State does exist.
            var state = _context.States.FirstOrDefault(s => s.Id == Item.StateId);
            if(state == null)
            {
                return BadRequest("State does not exist.");
            }

            //foreach (object attr in Item.ItemAttributes)
            //{
            //    switch (((ItemAttribute)attr).Type)
            //    {
            //        case AttributeType.Number:
            //            {
            //                var nattr = (NumberAttribute)attr;
            //                newItem.ItemAttributes.Add(new NumberAttribute { Value = nattr.Value });
            //                break;
            //            }
            //        case AttributeType.Range:
            //            {
            //                var rattr = (RangeAttribute)attr;
            //                newItem.ItemAttributes.Add(new RangeAttribute { HigherValue = rattr.HigherValue, LowerValue=rattr.LowerValue });
            //                break;
            //            }
            //        case AttributeType.Text:
            //            {
            //                var tattr = (TextAttribute)attr;
            //                newItem.ItemAttributes.Add(new TextAttribute { Text = tattr.Text });
            //                break;
            //            }
            //        default: return BadRequest("Attrbiute Type not supported.");
            //    }
            //}







            _context.Items.Add(Item);
            //try
            //{
            await _context.SaveChangesAsync();
            //}
            //catch (SqlException ex)
            //{
            //    return StatusCode(500, "Internal Server Error.");
            //}

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
        public async Task<IActionResult> Update([FromRoute] long id, [FromBody] Item Item)
        {
            if (Item == null || Item.Id != id)
            {
                return BadRequest();
            }

            var dbItem = await _context.Items.FirstOrDefaultAsync(d => d.Id == id);
            if(dbItem == null)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (await TryUpdateModelAsync<Item>(Item))
            {
                await _context.SaveChangesAsync();
                return CreatedAtRoute("GetItem", new { id = Item.Id }, Item);
            }

            dbItem.Update(Item);

            _context.Items.Update(dbItem);
            _context.SaveChanges();
            return new NoContentResult();
        }
    }
}
