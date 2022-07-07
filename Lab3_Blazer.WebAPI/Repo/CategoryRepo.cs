using Lab3_Blazer.shared;
using Lab3_Blazer.WebAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Lab3_Blazer.WebAPI.DTO;
using System.Linq;
using Lab3_Blazer.WebAPI.Repo;
using Lab3_Blazer.WebAPI.DataDTO;
using Lab3_Blazer.WebAPI.DataDTO;
using System;

public class CategoryRepo:ICategoryRepo
    {
        EcomerceEntity db;
        public CategoryRepo(EcomerceEntity db)
        {
            this.db = db;
        }

        public List<Category> GetAll()
        {
            return db.Categories.ToList();
        }

        public Category FindById(int id)
        {
            return db.Categories.Include(p=>p.product).FirstOrDefault(x => x.Id == id);
        }
        public bool FindByName(string name)
        {
            return db.Categories.Any(cat => cat.Name == name);
        }
        public int Insert(CategoryDT category)
        {
        Category CAT = new Category()
        {
            Name = category.name,
            Description = category.descrption,
            img = category.img
        };
        // cat.Id = category.Id;
        try
        {

         db.Categories.Add(CAT);
         int raw = db.SaveChanges();
            return raw;
        }
        catch(Exception ex) {
            return -1;
        }
        }
        public int Edit(int id,CategoryDT category)
        {
            Category cat = FindById(id);
           
            
            if (cat != null)
            {
                cat.Name = category.name;
                cat.Description = category.descrption;
                 cat.img = category.img;
                int raw = db.SaveChanges();
                return raw;
            }
            return 0;
        }
        public int Delete(int id)
        {
            Category cat = FindById(id);
            db.Categories.Remove(cat);
            return db.SaveChanges();
        }

    public int Edit(int id, Category category)
    {
        throw new System.NotImplementedException();
    }
}

