using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingNavigatorSolution.Models
{
    public class ShoppingListUpdate
    {
        public IList<ShoppingList> RetrieveShoppingLists { get; set; }

        public bool? SuccessfulPost { get; set; }

    }
}