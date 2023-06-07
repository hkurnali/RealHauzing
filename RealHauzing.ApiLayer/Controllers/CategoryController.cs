using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealHauzing.BussinessLayer.Abstract;
using RealHauzing.DtoLayer.CategoryDtos;
using RealHauzing.EntityLayer.Concrete;

namespace RealHauzing.ApiLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
       

        [HttpGet]
        public IActionResult CategoryList()
        {
            var values = _categoryService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult Addcategory(ResultCategoryDto resultCategoryDto)
        {
            Category category = new Category()
            {
                CategoryName = resultCategoryDto.CategoryName
            };
            _categoryService.TInsert(category);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteCategory(int id)
        {
            var values = _categoryService.TGetbyID(id);
            _categoryService.TDelete(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateCategory(UpdateCategoryDto updateCategoryDto)
        {
            Category category = new Category()
            {
                CategoryName = updateCategoryDto.CategoryName,
                CategoryID= updateCategoryDto.CategoryID
            };
            _categoryService.TUpdate(category);
            return Ok();
        }
        [HttpGet("id")]
        public IActionResult Getcategory(int id)
        {
            var values = _categoryService.TGetbyID(id);
            return Ok(values);
        }
    }
}
