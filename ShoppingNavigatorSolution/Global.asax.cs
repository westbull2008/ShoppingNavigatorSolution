using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Ninject;
using Ninject.Web.Common.WebHost;
using ShoppingNavigatorSolution.DAL;
using System.Configuration;

namespace ShoppingNavigatorSolution
{
    public class MvcApplication : NinjectHttpApplication
    {
        protected override void OnApplicationStarted()
        {
            base.OnApplicationStarted();

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        
        protected override IKernel CreateKernel()
        {
            var kernel = new StandardKernel();

            // Set up the bindings
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
//            string connectionString = @"Server=.\SQLExpress;Database=ShoppingList;Trusted_Connection=True;";

            kernel.Bind<IProductSqlDAL>().To<ProductSqlDAL>().WithConstructorArgument("connectionString", connectionString);
            kernel.Bind<IShoppingListDAL>().To<ShoppingListDAL>().WithConstructorArgument("connectionString", connectionString);
            return kernel;
        }
    }
}

