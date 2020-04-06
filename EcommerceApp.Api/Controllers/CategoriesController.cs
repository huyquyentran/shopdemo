using System.Collections.Generic;
using System.Threading.Tasks;
using EcommerceApp.Api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EcommerceApp.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoriesController : ControllerBase
    {
        private readonly EcommerceContext context;

        public CategoriesController(EcommerceContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Category>>> GetAll()
        {
            var categories = await context.Categories.Include(c => c.Products).ToListAsync();
            return Ok(categories);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Category>> GetById(int id)
        {
            var category = await context.Categories.FindAsync(id);
            if (category == null)
            {
                return NotFound();
            }

            return Ok(category);
        }


        [HttpPost]
        public async Task<ActionResult<Category>> Create(Category category)
        {
            await context.Categories.AddAsync(category);
            await context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetById), new { id = category.Id }, category);
        }


    }
}
