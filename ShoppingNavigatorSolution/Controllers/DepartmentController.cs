using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Text;
using System.Threading.Tasks;
using ShoppingNavigatorSolution.DAL;
using ShoppingNavigatorSolution.Models;

namespace ShoppingNavigatorSolution.Controllers
{
    public class DepartmentController : Controller
    {
        // GET: Department
        public ActionResult Index()
        {
            return View();
        }

        public class Department
        {
            //Properties of a department:
            // Location
            //public string Location { get; set; }

            // Department name
            public string DepartmentName { get; set; }

            // Aisles
            public string Aisles { get; set; }

            public Department(string name)
            {
                DepartmentName = name;
                //            Location = location;
            }

        }
    }
}
