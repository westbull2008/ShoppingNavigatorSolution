using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingNavigatorSolution.Models
{
    public class AddProductSuccess
    {
        public IList<Product> NewProductList { get; set; }
        public bool? AddedProduct { get; set; }
    }
}