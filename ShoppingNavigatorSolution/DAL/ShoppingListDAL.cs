using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Transactions;
using ShoppingNavigatorSolution.Models;
using System.Data.SqlClient;


namespace ShoppingNavigatorSolution.DAL
{
    public class ShoppingListDAL : IShoppingListDAL
    {
        private string connectionString;
        public ShoppingListDAL(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public Product GetProduct(int id)
        {
            Product product = new Product();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(@"select * from products where id = @id;", conn);
                    cmd.Parameters.AddWithValue("@id", id);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        product.Id = Convert.ToInt32(reader["id"]);
                        product.Name = Convert.ToString(reader["product"]);
                        product.Department = Convert.ToString(reader["department"]);
                    }
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }

            return product;
        }

        public List<ShoppingList> GetAllLists()
        {
            List<ShoppingList> lists = new List<ShoppingList>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(@"SELECT * FROM shopping_list ORDER BY listDate desc;", conn);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        ShoppingList list = new ShoppingList();
                        list.ListId = Convert.ToInt32(reader["listId"]);
                        list.ListName = Convert.ToString(reader["listName"]);
                        list.ListDate = Convert.ToDateTime(reader["listDate"]);
                        lists.Add(list);
                    }
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            return lists;

        }

        public ShoppingList GetList(int listId)
        {
            ShoppingList output = null;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("select * from shopping_list where shopping_list.listId = @listId; ", conn);
                    cmd.Parameters.AddWithValue("@listId", listId);

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        output = new ShoppingList();

                        output.ListId = Convert.ToInt32(reader["listId"]);
                        output.ListName = Convert.ToString(reader["listName"]);
                        output.ListDate = Convert.ToDateTime(reader["listDate"]);

                    }
                    reader.Close();

                    SqlCommand cmd2 = new SqlCommand("select * from shopping_list join product_shopping_list on shopping_list.listId = product_shopping_list.listId join products on product_shopping_list.productId = products.id where shopping_list.listId = @listId order by department, product asc;", conn);
                    cmd2.Parameters.AddWithValue("@listId", listId);

                    reader = cmd2.ExecuteReader();

                    output.Items = new List<ShoppingListItem>();
                    while (reader.Read())
                    {
                        ShoppingListItem item = new ShoppingListItem();
                        //                item.ShoppingListId = Convert.ToInt32(reader["listId"]);
                        item.Quantity = Convert.ToInt32(reader["quantity"]);
                        item.Product = new Product(Convert.ToString(reader["product"]), Convert.ToString(reader["department"]));
                        item.ProductId = Convert.ToInt32(reader["productId"]);
                        output.Items.Add(item);
                    }
                    reader.Close();

                }
                return output;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int CreateShoppingList(ShoppingList model)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO shopping_list (ListDate, ListName) VALUES (@ListDate, @ListName)", conn);

                    cmd.Parameters.AddWithValue("@ListDate", model.ListDate);
                    cmd.Parameters.AddWithValue("@ListName", model.ListName);
                    cmd.ExecuteNonQuery();

                    cmd = new SqlCommand("SELECT MAX(listId) FROM shopping_list;", conn);
                    int newId = (int)cmd.ExecuteScalar();
                    return newId;

                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("An error occurred reading the database: " + ex.Message);
            }
            return -1;
        }

        public int SaveShoppingList(ShoppingList model)
        {
            int listId = 0;

            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("UPDATE shopping_list SET listDate = @ListDate WHERE listId = @ListId", conn);
                        cmd.Parameters.AddWithValue("@ListId", model.ListId);
                        cmd.Parameters.AddWithValue("@ListDate", model.ListDate);
                        cmd.Parameters.AddWithValue("@ListName", model.ListName);
                        cmd.ExecuteNonQuery();

                        cmd = new SqlCommand("DELETE from product_shopping_list WHERE ListId = @listId", conn);
                        cmd.Parameters.AddWithValue("@listId", model.ListId);

                        cmd.ExecuteNonQuery();

                        foreach (var item in model.Items)
                        {
                            SqlCommand cmd2 = new SqlCommand("INSERT INTO product_shopping_list (listId, productId, quantity) VALUES (@ShoppingListId, @ProductId, @Quantity)", conn);
                            cmd2.Parameters.AddWithValue("@ShoppingListId", model.ListId);
                            cmd2.Parameters.AddWithValue("@ProductId", item.ProductId);
                            cmd2.Parameters.AddWithValue("@Quantity", item.Quantity);

                            cmd2.ExecuteNonQuery();
                        }
                    }
                    scope.Complete();
                }
                return listId;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("An error occurred reading the database: " + ex.Message);
                return 0;
            }
        }

        public ShoppingList FinalList (int id)
        {
            ShoppingList finalList = new ShoppingList();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(@"SELECT * FROM product_shopping_list JOIN products on product_shopping_list.productId = products.id WHERE product_shopping_list.listId = @listId ORDER BY department, product asc;", conn);
                    cmd.Parameters.AddWithValue("@listId", id);

                    SqlDataReader reader = cmd.ExecuteReader();

                    finalList.Items = new List<ShoppingListItem>();
                    while (reader.Read())
                    {
                        ShoppingListItem item = new ShoppingListItem();
                        item.ShoppingListId = id;
                        item.Quantity = Convert.ToInt32(reader["quantity"]);
                        item.Product = new Product(Convert.ToString(reader["product"]), Convert.ToString(reader["department"]));
                        item.ProductId = Convert.ToInt32(reader["productId"]);
                        finalList.Items.Add(item);
                    }
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            return finalList;
        }

    }
}