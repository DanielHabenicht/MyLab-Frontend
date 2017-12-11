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
    [Route("api/[controller]")]
    public class CategoryController : Controller
    {
        private readonly MyLabContext _context;

        public CategoryController(MyLabContext context)
        {
            _context = context;
        }

        // GET: api/category
        [HttpGet]
        public IEnumerable<Category> GetAll()
        {
            return _context.Categories.Include(category => category.Laboratory).ToList();
        }

        // GET: api/category/{id}
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

        // Add a new Category
        // POST: api/category
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

        // Update a category
        // PUT: api/category
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