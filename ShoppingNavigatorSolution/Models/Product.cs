using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingNavigatorSolution.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public Product()
        {

        }
        public Product(string name, string department)
        {
            Name = name;
            Department = department;
        }
    }
}