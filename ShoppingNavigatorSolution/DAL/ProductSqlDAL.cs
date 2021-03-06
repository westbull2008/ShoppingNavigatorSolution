﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ShoppingNavigatorSolution.Models;
using System.Data.SqlClient;


namespace ShoppingNavigatorSolution.DAL
{
    public class ProductSqlDAL : IProductSqlDAL
    {
        private string connectionString;
        public ProductSqlDAL(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(@"SELECT * FROM products ORDER BY department, product asc;", conn);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Product product = new Product();
                        product.Id = Convert.ToInt32(reader["id"]);
                        product.Name = Convert.ToString(reader["product"]);
                        product.Department = Convert.ToString(reader["department"]);
                        products.Add(product);
                    }
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            return products;
        }

        public bool SaveNewProduct(Product product)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO products (product, department) VALUES (@name, @department);", conn);
                    cmd.Parameters.AddWithValue("@name", product.Name);
                    cmd.Parameters.AddWithValue("@department", product.Department);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }

            return true;
        }

    }
}