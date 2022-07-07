using Lab3_Blazer.shared;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Lab3_Blazer.WASM.Services
{
	public class CategoryServices : IServices<Category>
	{
		HttpClient httpClient;
		public CategoryServices(HttpClient httpClient)//request from service provider
		{
			this.httpClient = httpClient;
		}
		public async Task Delete(int id)
		{
			await httpClient.DeleteAsync("/api/Category/" + id);
		}

		public async Task<List<Category>> GetAll()
		{
			List<Category> catlist =
			   await httpClient.GetFromJsonAsync<List<Category>>("/api/Category");
			return catlist;
		}

		public async Task<Category> GetByID(int id)
		{
			Category cat = await httpClient.GetFromJsonAsync<Category>("/api/Category/Cat/" + id);
			return cat;
		}

		public async Task Insert(Category item)
		{
			await httpClient.PostAsJsonAsync<Category>("/api/Product", item);
		}

		public async Task Update(int id, Category item)
		{
			await httpClient.PutAsJsonAsync<Category>("/api/Category/" + id, item);
		}
	}
}
