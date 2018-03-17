using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ShoppingNavigatorSolution.DAL;
using ShoppingNavigatorSolution.Models;

namespace ShoppingNavigatorSolution.Controllers
{
    public class ProductController : Controller
    {
        //Create  a private variable to hold DAL
        IProductSqlDAL dal;

        //Create constructor that allows IProductDAL to be passed in
        public ProductController (IProductSqlDAL dal)
        {
            this.dal = dal;
        }
        // GET: Product
        public ActionResult Products()
        {            
            return View();
        }
        public ActionResult NewProductSuccess(bool? saveNewProduct)
        {
            AddProductSuccess done = new AddProductSuccess();
            done.NewProductList = dal.GetAllProducts();
            done.SuccessfulPost = saveNewProduct;
            return View(done);

        }

        [HttpPost]
        public ActionResult Products(List<int> selectedProduct)
        {
            // Loop through each selected product

            // Look for it in the database

            // Add the product to the shopping cart
            return RedirectToAction("ShoppingList");
        }


        public ActionResult ProductList()
        {
            var products = dal.GetAllProducts();

            return PartialView("ProductList", products);
        }

        [HttpPost]
        public ActionResult AddToProducts(string name, string department)
        {

            var product = dal.GetAllProducts();

            ShoppingList list = GetActiveShoppingList();
            ///list.AddToList(product, department);

            return RedirectToAction("Products");

        }
        public ActionResult ProductShoppingList()
        {
            ShoppingList list = GetActiveShoppingList();

            return View(list);
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
    }
}