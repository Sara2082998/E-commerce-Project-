using Lab3_Blazer.shared;
using Lab3_Blazer.WebAPI.DTO;
using System.Collections.Generic;
namespace Lab3_Blazer.WebAPI.Repo
{
    public interface IProductRepo
    {
        int Delete(int id);
        int Edit(int id, Product product);
        Product FindById(int id);
        List<Product> GetAll();
        int Insert(ProductDto product);
        int Edit( int id,ProductDto product );
        List<Product> GetproductandCategory();
        List<Product> searchByName(string name);
        List<Product> getProductsBYcategoryId(int catId);
        List<Product> getProductsBYPrice(decimal price);
    }
}
