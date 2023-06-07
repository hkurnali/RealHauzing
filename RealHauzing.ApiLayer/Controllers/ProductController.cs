using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealHauzing.BussinessLayer.Abstract;
using RealHauzing.DtoLayer.ProductDtos;
using RealHauzing.EntityLayer.Concrete;

namespace RealHauzing.ApiLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet]
        public IActionResult ProductList()
        {
            var values =_productService.TGetList();
            return Ok(values);
        }
        [HttpGet("ProductWithCategory")]

        public IActionResult ProductWithCategory()
        {
            var values=_productService.TGetProductWithCategories();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddProduct(AddProductDto addProductDto) 
        {
            Product product = new Product()
            {
                ProductTitle = addProductDto.ProductTitle,
                ProductPrice = addProductDto.ProductPrice,
                ProductType = addProductDto.ProductType,
                ProductAddress = addProductDto.ProductAddress,

                BedRoomCount = addProductDto.BedRoomCount,

                BathCount = addProductDto.BathCount,

                Square = addProductDto.Square,
                CoverImageUrl = addProductDto.CoverImageUrl,

                CategoryID = addProductDto.CategoryID


            };
        _productService.TInsert(product);
            return Ok();
        
        }
        [HttpDelete]
        public IActionResult DeleteProduct(int id)
        {
            var values = _productService.TGetbyID(id);
            _productService.TDelete(values);
            return Ok();
        }
        [HttpGet("id")]
        public IActionResult GetProduct(int id)
        {
            var values = _productService.TGetbyID(id);
            return Ok(values);
        }
        [HttpPut]
        public IActionResult UpdateProduct(UpdateProductDto updateProductDto) 
        {
            Product product = new Product()

            {
                ProductTitle = updateProductDto.ProductTitle,
                ProductPrice = updateProductDto.ProductPrice,
                ProductType = updateProductDto.ProductType,
                ProductAddress = updateProductDto.ProductAddress,

                BedRoomCount = updateProductDto.BedRoomCount,

                BathCount = updateProductDto.BathCount,

                Square = updateProductDto.Square,
                CoverImageUrl = updateProductDto.CoverImageUrl,

                CategoryID = updateProductDto.CategoryID
            };
        _productService.TUpdate(product);
            return Ok();
        
        }
    }
}
