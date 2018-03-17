using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShoppingNavigatorSolution.DAL;
using ShoppingNavigatorSolution.Models;

namespace ShoppingNavigatorSolution.Controllers
{
    public class ShoppingListController : Controller
    {
        // GET: ShoppingList
        public ActionResult ShoppingList()
        {
            return View();
        }
    }
}