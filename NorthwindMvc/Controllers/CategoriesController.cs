using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using CoreLibrary;
using CoreLibrary.Models;

namespace MvcClient.Controllers
{
    public class CategoriesController : Controller
    {
        // GET: Categories
        public async Task<ActionResult> Index()
        {
            List<Category> categories = await WebApiBroker.GetCategoriesAsync("api/Categories");

            return View(categories);
        }
    }
}