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
       
        public ActionResult NewProductSuccess()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NewProductSuccess(Product model)
        {
            bool result = dal.SaveNewProduct(model);
            return RedirectToAction("NewProductSuccess");
        }

    }

}