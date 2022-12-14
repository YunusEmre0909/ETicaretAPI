using ETicaretAPI.Application.Repositories;
using ETicaretAPI.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        readonly private IProductWriteRepository _productWriteRepository;
        readonly private IProductReadRepository _productReadRepository;

        public ProductsController(IProductReadRepository productReadRepository,IProductWriteRepository productWriteRepository)
        {
            _productReadRepository = productReadRepository;
            _productWriteRepository = productWriteRepository;   
        }
        [HttpGet]
        public async Task Get()
        {
            /*
           await _productWriteRepository.AddRangeAsync(new()
            {
                new(){Id=Guid.NewGuid(),Name="Laptop",Price=20000,Stock=20,CreateDate=DateTime.UtcNow},
                new(){Id=Guid.NewGuid(),Name="Mouse",Price=500,Stock=20,CreateDate=DateTime.UtcNow}
            });
           var count= await _productWriteRepository.SaveAsync();*/
           Product p= await _productReadRepository.GetByIdAsync("db635df0-5082-4240-a550-500db70f6312");
            p.Name = "abcs";
            await _productWriteRepository.SaveAsync();
        }
        [HttpGet("id")]
        public async Task<IActionResult> Get(string id)
        {
            Product product=await _productReadRepository.GetByIdAsync(id);
            return Ok(product);
        }
    }
}
