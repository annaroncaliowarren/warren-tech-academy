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
        public Animal GetById(int id)
        {
            return repository.GetById(id);
        }

        [HttpPost]
        public Dictionary<string, dynamic> Post(Animal model)
        {
            return repository.Create(model);
        }

        [HttpDelete]
        public Dictionary<string, dynamic> Delete(int id)
        {
            return repository.Delete(id);
        }

        [HttpPut]
        public Dictionary<string, dynamic> Put(Animal model)
        {
            return repository.Update(model);
        }
    }
}
