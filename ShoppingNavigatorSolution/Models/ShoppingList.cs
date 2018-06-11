using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingNavigatorSolution.Models
{
    public class ShoppingList
    {
        public int ListId { get; set; }
        public string ListName { get; set; }
        public DateTime ListDate { get; set; }
        public List<ShoppingListItem> Items { get; set; } = new List<ShoppingListItem>();


        public void AddToList(Product p, int quantity, int productId)
        {
            var shoppingListItem = Items.FirstOrDefault(i => i.Product.Id == p.Id);

            if (shoppingListItem == null)
            {
                shoppingListItem = new ShoppingListItem() { Product = p, Quantity = 0, ProductId = productId };
                Items.Add(shoppingListItem);
            }

            shoppingListItem.Quantity += quantity;
        }
    }
}