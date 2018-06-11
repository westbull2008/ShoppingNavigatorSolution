using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ShoppingNavigatorSolution.Models;
using System.Data.SqlClient;

namespace ShoppingNavigatorSolution.DAL
{
    public interface IProductSqlDAL
    {
        List<Product> GetAllProducts();
        bool SaveNewProduct(Product product);
    }
}