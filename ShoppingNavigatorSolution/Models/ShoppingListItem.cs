using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingNavigatorSolution.Models
{
    public class ShoppingListItem
    {
        public Product product { get; set; }
        public int quantity { get; set; }
    }
}