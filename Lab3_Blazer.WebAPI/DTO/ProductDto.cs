﻿namespace Lab3_Blazer.WebAPI.DTO
{
    public class ProductDto
    {
        public int Id { get; set; }

       
        public string Name { get; set; }
      
        public decimal Price { get; set; }
       
        public string Description { get; set; }

        
        public string img { get; set; }

       
        public int  CategoryId { get; set; }
        
    }
}
