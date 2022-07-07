using Lab3_Blazer.shared;
using Lab3_Blazer.WebAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Lab3_Blazer.WebAPI.DTO;
using System.Linq;
using System;

namespace Lab3_Blazer.WebAPI.Repo
{
    public class ProductRepo:IProductRepo
    {
        EcomerceEntity db;
        public ProductRepo(EcomerceEntity db)
        {
            this.db = db;
        }

        public List<Product> GetAll()
        {
            return db.products.ToList();
        }
        public List<Product> GetproductandCategory()
        {
            return db.products.Include(N => N.Category).ToList();
        }
        public List<Product> searchByName(string name)
        {
            return db.products.Where(p => p.Name.Contains(name)).ToList();
        }
        public Product FindById(int id)
        {
            return db.products.FirstOrDefault(x => x.Id == id);
        }
        public int Insert(ProductDto product)
        {
            Product prod = new Product()
            {
                Name = product.Name,
                Description = product.Description,
                img = product.img,
                Price = product.Price,
                CategoryId = product.CategoryId
                

            };
             try
            {

                db.products.Add(prod);
                int raw = db.SaveChanges();
                return raw;
            }
            catch (Exception ex)
            {
                
                return -1;
            }

        }
        public int Edit(int id, ProductDto product)
        {
            Product prdct = FindById(id);
           
            if (prdct != null)
            {
                prdct.img = product.img;
                prdct.Name = product.Name;
                prdct.Price = product.Price;
                prdct.Description = product.Description;
                prdct.CategoryId = product.CategoryId;
                int raw = db.SaveChanges();
                return raw;
            }
            return 0;
        }
        public int Delete(int id)
        {
            Product prdct = FindById(id);
            db.products.Remove(prdct);
            return db.SaveChanges();
        }


        public List<Product> getProductsBYcategoryId(int catId)
        {
            return db.products.Where(p => p.CategoryId == catId).ToList();
        }


        public List<Product> getProductsBYPrice(decimal price)
        {
            return db.products.Where(p => p.Price <= price).ToList();
        }

        public int Edit(int id, Product product)
        {
            throw new System.NotImplementedException();
        }

        public int Insert(Product product)
        {
            throw new NotImplementedException();
        }

        public int Edit(ProductDto product)
        {
            throw new NotImplementedException();
        }
    }
}
