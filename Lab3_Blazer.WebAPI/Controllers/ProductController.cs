using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Lab3_Blazer.WebAPI.Repo;
using Lab3_Blazer.WebAPI.Models;
using Microsoft.Extensions.Configuration;
using Lab3_Blazer.shared;
using System.Collections.Generic;
using System;
using Lab3_Blazer.WebAPI.DTO;

namespace Lab3_Blazer.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        readonly IProductRepo producteRepository;
        readonly IConfiguration configuration;
        public ProductController(IProductRepo proReso, IConfiguration config)
        {
            producteRepository = proReso;
            configuration = config;


        }
        [HttpGet]
        public IActionResult GetAllProduct()
        {
            List<Product> productlist = producteRepository.GetAll();
            return Ok(productlist);
        }
        [HttpGet("{id:int}", Name = "getProduct")]
        public IActionResult GetByID(int id)
        {
            Product prod = producteRepository.FindById(id);
            return Ok(prod);
        }
		[HttpPost]//
		public IActionResult Postproduct(ProductDto prod)
		{
			if (ModelState.IsValid == true)
			{
				//201 Create ==>location
				var res = producteRepository.Insert(prod);


				string url = Url.Link("getProduct", new { id = prod.Id });
				return Created(url, prod);
			}
		
			return BadRequest(ModelState);
		}
		[HttpPut("{id:int}")]
        public IActionResult Update([FromRoute] int id, [FromBody] ProductDto prod)
        {
            if (ModelState.IsValid == true)
            {
               
                   producteRepository.Edit(id, prod);
                    return Ok(prod);
                

            }
            return BadRequest(ModelState);
        }
        [HttpDelete("{id:int}")]
        public IActionResult Remove(int id)
        {
            Product prod = producteRepository.FindById(id);
            if (prod != null)
            {
                try
                {
                    producteRepository.Delete(id);
                    return StatusCode(204, "Record Remove Success");
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }
            }
            return BadRequest("Id Not Found");


        }
    }
}
