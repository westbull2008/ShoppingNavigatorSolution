using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingNavigatorSolution.Models;
using System.Data.SqlClient;

namespace ShoppingNavigatorSolution.DAL
{
    public interface IShoppingListDAL
    {
        int CreateShoppingList(ShoppingList model);
        Product GetProduct(int id);
        List<ShoppingList> GetAllLists();
        ShoppingList GetList(int listId);
        int SaveShoppingList(ShoppingList model);
        ShoppingList FinalList(int id);

    }
}
