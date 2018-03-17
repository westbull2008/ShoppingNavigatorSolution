using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingNavigatorSolution.Models
{
    public class ShoppingList
    {
        public IList<ShoppingListItem> Items { get; } = new List<ShoppingListItem>();

        public void AddToList(Product p, int quantity)
        {
            var shoppingListItem = Items.FirstOrDefault(i => i.product.Id == p.Id);

            if (shoppingListItem == null)
            {
                shoppingListItem = new ShoppingListItem() { product = p, quantity = 0 };
                Items.Add(shoppingListItem);
            }

            shoppingListItem.quantity += quantity;
        }
    }
}