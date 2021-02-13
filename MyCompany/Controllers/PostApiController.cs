using Microsoft.AspNetCore.Mvc;
using MyCompany.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCompany.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostApiController : Controller
    {
        private readonly AppDbContext db;

        public PostApiController(AppDbContext _db)
        {
            db = _db;
        }

        [Produces("application/json")]
        [HttpGet("search")]
        public async Task<IActionResult> Search()
        {
            try
            {
                string term = HttpContext.Request.Query["term"].ToString();
                var postTitle = db.ServiceItems.Where(p => p.Title.Contains(term))
                                               .Select(p => p.Title).ToList();

                return Ok(postTitle);
            }
            catch
            {
                return BadRequest();
            }
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
