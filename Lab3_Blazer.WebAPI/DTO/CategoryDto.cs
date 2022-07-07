using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Lab3_Blazer.WebAPI.DTO
{
    public class CategoryDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        
        public string Description { get; set; }

        public string img { get; set; }
        [JsonIgnore]
        public List<string> productsName { get; set; } = new List<string>();

    }
}
