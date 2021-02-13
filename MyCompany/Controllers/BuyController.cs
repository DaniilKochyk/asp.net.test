using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyCompany.Domain;
using MyCompany.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCompany.Controllers
{
    public class BuyController : Controller
    {
        private readonly DataManager dataManager;
        //zamówienia
        OrderContext db;
      
        public BuyController(OrderContext context)
        {
            db = context;
        }
        [Authorize]
        [HttpGet]
        public IActionResult Index(string id)
        {
            if (id == null) return RedirectToAction("View");
            ViewBag.Id = id;
            return View();
        }


        [HttpPost]
        public IActionResult Index(Order order)
        {


            db.Orders.Add(order);
            db.SaveChanges();

           return View("View");
          
        }
    }
}
