using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Lab3_Blazer.WebAPI.Repo;
using Microsoft.Extensions.Configuration;
using Lab3_Blazer.shared;
using Lab3_Blazer.WebAPI.DTO;
using System.Collections.Generic;
using System;
using Lab3_Blazer.WebAPI.DataDTO;

namespace Lab3_Blazer.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        readonly ICategoryRepo categoryRepository;
        readonly IConfiguration configuration;
        public CategoryController(ICategoryRepo catReso, IConfiguration config)
        {
            this.categoryRepository = catReso;
            this.configuration = config;


        }
        [HttpGet]
        public IActionResult Index()
        {
            List<Category> cats = categoryRepository.GetAll();
            return Ok(cats);
        }
        [HttpGet("Cat/{id:int}")]//api/Category/1
        public IActionResult GetByIDWithProdctNames(int id)
        {
            Category cat = categoryRepository.FindById(id);
            CategoryDTO CatDto = new CategoryDTO();
         
            CatDto.Name = cat.Name;
            foreach (var item in cat.product)
            {
                CatDto.productsName.Add(item.Name);
            }
            return Ok(CatDto);

        }
        [HttpGet("{id:int}", Name = "GetOneCatRoute")]//api/DEpartment/1
        public IActionResult GetByID(int id)
        {
            Category Cat = categoryRepository.FindById(id);
            //map 
            return Ok(Cat);

        }
        [HttpPost]//
        public IActionResult PostAllCategory(CategoryDT Cat)
        {
            if (ModelState.IsValid == true)
            {
                categoryRepository.Insert(Cat);
                //how to get current domain
                string url = Url.Link("GetOneDeptRoute", new { id = Cat.id });
                return Created(url, Cat);
            }
            // return BadRequest("Category Not Valid");
            return BadRequest(ModelState);

        }
        [HttpPut("{id:int}")]
        public IActionResult Put([FromRoute] int id, [FromBody] CategoryDT Cat)
        {
            if (ModelState.IsValid == true)
            {
               
                    
                    categoryRepository.Edit(id, Cat);
                    return StatusCode(204, Cat);
                
                return BadRequest("Id Not Valid");

            }
            return BadRequest(ModelState);
        }
        [HttpDelete("{id:int}")]
        public IActionResult Remove(int id)
        {
            Category Cat = categoryRepository.FindById(id);
            if (Cat != null)
            {
                try
                {
                    categoryRepository.Delete(id);

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
