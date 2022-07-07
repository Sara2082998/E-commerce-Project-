using Lab3_Blazer.shared;
using Lab3_Blazer.WebAPI.DataDTO;
using System.Collections.Generic;

namespace Lab3_Blazer.WebAPI.Repo
{
    public interface ICategoryRepo
    {
        int Delete(int id);
        int Edit(int id, CategoryDT category);
        Category FindById(int id);
        List<Category> GetAll();
        int Insert(CategoryDT category);
        public bool FindByName(string name);
    }
}
