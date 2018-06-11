using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingNavigatorSolution.Models
{
    public class ShoppingListItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public int ProductId { get; set; }
        public int ShoppingListId { get; set;}
    }
}