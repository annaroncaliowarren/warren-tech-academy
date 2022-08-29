using Data.Model;
using Data.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SalesApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        ProductRepository productRepository;

        public ProductController()
        {
            productRepository = new ProductRepository();
        }

        [HttpGet]
        public Dictionary<string, dynamic> Get()
        {
            return productRepository.GetAll();
        }

        [HttpPost]
        public Dictionary<string, dynamic> Post(ProductModel model)
        {
            return productRepository.Create(model);
        }

        [HttpDelete]
        public Dictionary<string, dynamic> Delete(int id)
        {
            return productRepository.Delete(id);
        }

        [HttpPut]
        public Dictionary<string, dynamic> Put(ProductModel model)
        {
            return productRepository.Update(model);
        }
    }
}
