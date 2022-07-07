using Lab3_Blazer.shared;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Lab3_Blazer.WASM.Services
{
    public class ProductServices : IServices<Product>
    {
        HttpClient httpClient;
             public ProductServices(HttpClient httpClient)//request from service provider
        {
            this.httpClient = httpClient;
        }

        public async Task Delete(int id)
        {
            await httpClient.DeleteAsync("/api/Product/" + id);
        }

        public async Task<List<Product>> GetAll()
        {

            List<Product> prodlist =
                await httpClient.GetFromJsonAsync<List<Product>>("/api/Product");
            return prodlist;
        }

        public async Task<Product> GetByID(int id)
        {
            Product pro = await httpClient.GetFromJsonAsync<Product>("/api/Product/"+id);
            return pro;
        }

        public async Task Insert(Product item)
        {
            await httpClient.PostAsJsonAsync<Product>("/api/Product", item);
        }

        public async Task Update(int id, Product item)
        {
            await httpClient.PutAsJsonAsync<Product>("/api/Product/"+id, item);
        }
    }
}
