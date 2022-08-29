using Microsoft.AspNetCore.Mvc;
using Data.Model;
using Data.Repository;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalController : ControllerBase
    {
        private AnimalRepository repository;

        public AnimalController()
        {
            this.repository = new AnimalRepository();
        }

        [HttpGet]
        public Dictionary<string, dynamic> Get()
        {
            return repository.GetAll();
        }

        [HttpGet("{id}")]
        public AnimalModel GetById(int id)
        {
            return repository.GetById(id);
        }

        [HttpPost]
        public Dictionary<string, dynamic> Post(AnimalModel model)
        {
            return repository.Create(model);
        }

        [HttpDelete("{id}")]
        public Dictionary<string, dynamic> Delete(int id)
        {
            return repository.Delete(id);
        }

        [HttpPut]
        public Dictionary<string, dynamic> Put(AnimalModel model)
        {
            return repository.Update(model);
        }
    }
}
