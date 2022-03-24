using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp.Shared.Models
{
    public class Product
    {
        //public int Productid { get; set; }
        //public string Productname { get; set; } = null!;
        //public string Category { get; set; } = null!;
        //public double Price { get; set; }
        public int ID { set; get; }
        public string Name { set; get; }        // tên
        public string Price { set; get; }       // giá
        public string Category { set; get; }      // phân loại

        //public Product(int id, string name, double price, string category)
        //{
        //    ID = id; Name = name; Price = price; Category = category;
        //}
    }
}