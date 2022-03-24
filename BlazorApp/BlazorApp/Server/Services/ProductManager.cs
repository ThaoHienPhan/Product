using BlazorApp.Server.Interfaces;
using BlazorApp.Server.Models;
using BlazorApp.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp.Server.Services
{
    public class ProductManager : IProduct
    {
        List<Product> List1 = new List<Product>();
        public ProductManager()
        {
            Product Product1 = new Product();
            Product1.Category = "HN";
            Product1.ID = 1;
            Product1.Name = "ABC";
            Product1.Price = "1000";
            List1.Add(Product1);
        }
        //To Get all user details   
        public List<Product> GetProductDetails()
        {
            return List1;
        }

        //To Add new user record     
        public void AddProduct(Product product)
        {
            //try
            //{
            //    _dbContext.Users.Add(user);
            //    _dbContext.SaveChanges();
            //}
            //catch
            //{
            //    throw;
            //}
        }

        //To Update the records of a particluar user    
        public void UpdateProductDetails(Product product)
        {
            //try
            //{
            //    _dbContext.Entry(user).State = EntityState.Modified;
            //    _dbContext.SaveChanges();
            //}
            //catch
            //{
            //    throw;
            //}
        }

        //Get the details of a particular user    
        public Product GetProductData(int id)
        {
            //try
            //{
            //    Product? user = _dbContext.Users.Find(id);

            //    if (user != null)
            //    {
            //        return user;
            //    }
            //    else
            //    {
            //        throw new ArgumentNullException();
            //    }
            //}
            //catch
            //{
            //    throw;
            //}
            return null;
        }

        //To Delete the record of a particular user    
        public void DeleteProduct(int id)
        {
            //try
            //{
            //    Product? user = _dbContext.Users.Find(id);

            //    if (user != null)
            //    {
            //        _dbContext.Users.Remove(user);
            //        _dbContext.SaveChanges();
            //    }
            //    else
            //    {
            //        throw new ArgumentNullException();
            //    }
            //}
            //catch
            //{
            //    throw;
            //}
        }

        //public List<Product> GetProductDetails()
        //{
        //    throw new NotImplementedException();

        //}

        //    public void AddProduct(Product product)
        //    {
        //        throw new NotImplementedException();
        //    }

        //    public void UpdateProductDetails(Product product)
        //    {
        //        throw new NotImplementedException();
        //    }

        //    public Product GetProductData(int id)
        //    {
        //        throw new NotImplementedException();
        //    }

        //    public void DeleteProduct(int id)
        //    {
        //        throw new NotImplementedException();
        //    }
        // }
    }
}