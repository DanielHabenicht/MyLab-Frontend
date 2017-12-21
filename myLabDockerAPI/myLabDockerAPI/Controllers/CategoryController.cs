using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using myLabDockerAPI.Data;
using myLabDockerAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace myLabDockerAPI.Controllers
{
    /// <summary>
    /// Controller for all API Request to 'api/categories'
    /// </summary>
    [Route("api/[controller]")]
    public class CategoriesController : Controller
    {
        private readonly MyLabContext _context;

        /// <summary>
        /// Initializes _context
        /// </summary>
        /// <param name="context"></param>
        public CategoriesController(MyLabContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Returns all Categories from the Database
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///     GET /categories
        /// </remarks>
        /// <returns>All Categories</returns>
        [HttpGet]
        public IEnumerable<Category> GetAll()
        {
            return _context.Categories.Include(category => category.Laboratory).ToList();
        }

        /// <summary>
        /// Returns a Category with the given id.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///     GET /categories/{id}
        /// 
        /// 
        /// </remarks>
        /// <param name="id"></param>
        /// <returns>A Category with the given id</returns>
        /// <response code="201">If the Category was found.</response>
        /// <response code="404">If the Category could not be found.</response>   
        [HttpGet("{id}", Name = "GetCategory")]
        public IActionResult GetById(long id)
        {
            var item = _context.Categories.Include(category => category.Laboratory).FirstOrDefault(t => t.Id == id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }

        /// <summary>
        /// Creates a new category.
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        /// 
        /// </remarks>
        /// <param name="category"></param>
        /// <returns>A newly-created Category</returns>
        /// <response code="201">Returns the newly-created category</response>
        /// <response code="400">If the category is null</response>   
        [HttpPost]
        public IActionResult Create([FromBody] Category category)
        {
            if (category == null)
            {
                return BadRequest();
            }
            var laboratory = _context.Laboratories.FirstOrDefault(lab => lab.Id == category.Laboratory.Id);
            if (laboratory == null)
            {
                return BadRequest("The Laboratory does not exist.");
            }

            category.Laboratory = laboratory;
            _context.Categories.Add(category);
            _context.SaveChanges();

            return CreatedAtRoute("GetCategory", new { id = category.Id }, category);
        }

        /// <summary>
        /// Updates an existing Item.
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///     PUT /categories/{id}
        /// 
        /// 
        /// </remarks>
        /// <param name="id"></param>
        /// <param name="category"></param>
        /// <returns>Nothing</returns>
        /// <response code="400">If the item is null</response>   
        [HttpPut("{id}")]
        public IActionResult Update(long id, [FromBody] Category category)
        {
            if (category == null || category.Id != id)
            {
                return BadRequest();
            }

            var item = _context.Categories.FirstOrDefault(d => d.Id == id);
            if (item == null)
            {
                return NotFound();
            }

            item.Comment = category.Comment;
            item.IsTemplate = category.IsTemplate;
            item.Laboratory = category.Laboratory;
            item.Title = item.Title;

            _context.Categories.Update(item);
            _context.SaveChanges();
            return new NoContentResult();
        }
    }
}