using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyCompany.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCompany.Controllers
{
    public class SearchController : Controller
    {
        private readonly AppDbContext context;
        public SearchController(AppDbContext context)
        {
            this.context = context;
        }

        public async Task<IActionResult> Index(string postTitle)
        {
            if (postTitle != null)
            {
                var postdata = context.ServiceItems.Where(p => p.Title.Contains(postTitle)).ToList();
                return View(postdata);
            }
            else
            {
                return View(await context.ServiceItems.ToListAsync());
            }
        }
    }
}
