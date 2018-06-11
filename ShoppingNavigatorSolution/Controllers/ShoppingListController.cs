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
        IShoppingListDAL dal;
        IProductSqlDAL productDal;

        public ShoppingListController(IShoppingListDAL dal, IProductSqlDAL productDal)
        {
            this.dal = dal;
            this.productDal = productDal;
        }

        private void SetActiveShoppingList(ShoppingList list)
        {
            Session["Shopping_List"] = list;
        }

        private ShoppingList GetActiveShoppingList()
        {
            ShoppingList list = null;

            if (Session["Shopping_List"] == null)
            {
                list = new ShoppingList();
                Session["Shopping_List"] = list;
            }
            else
            {
                list = Session["Shopping_List"] as ShoppingList;
            }
            return list;
        }

        public ActionResult GetShoppingLists(bool? postSuccess)
        {            
            var lists = dal.GetAllLists();            
            return View(lists);
        }

        public ActionResult GetPreviousList(int id)
        {
            ShoppingList previousList = dal.GetList(id);
            SetActiveShoppingList(previousList);
            return RedirectToAction("AddToList");
        }

        /// Displays the active shopping list.
        public ActionResult ViewList()
        {
            ShoppingList activeList = GetActiveShoppingList();
            return View(activeList);
        }

        public ActionResult NewShoppingList()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NewShoppingList(ShoppingList model)
        {
            int listId = dal.CreateShoppingList(model);
            model.ListId = listId;
            SetActiveShoppingList(model);
            return RedirectToAction("AddToList", "ShoppingList");
        }

        /// Allows a user to add products to a list.
        public ActionResult AddToList()
        {
            var products = productDal.GetAllProducts();
            ViewBag.List = GetActiveShoppingList();
            return View(products);
        }

        /// Adds the specified product id to the user's list.
        [HttpPost]
        public ActionResult AddToList(Product p, int quantity, int id)
        {
            var product = dal.GetProduct(id);
            ShoppingList list = GetActiveShoppingList();
            list.AddToList(product, quantity, id);
            return RedirectToAction("AddToList", "ShoppingList");
        }


        public ActionResult SaveList()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SaveList(ShoppingList model)
        {
            ShoppingList list = GetActiveShoppingList();
            int savedListId = dal.SaveShoppingList(list);
            model.ListId = savedListId;
            return View(list);
        }

        public ActionResult ListByDepartment(int id)
        {
            ShoppingList savedList = dal.FinalList(id);
            return View(savedList);
        }

    }
}