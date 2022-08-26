using Microsoft.AspNetCore.Mvc;
using Data.Model;
using Data.Repository;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalController : ControllerBase
    {
        [HttpGet]
        public List<Animal> Get()
        {
            AnimalRepository animalRepository = new AnimalRepository();
            return animalRepository.GetAll();
        }

        [HttpPost]
        public string Post(Animal model)
        {
            AnimalRepository repo = new AnimalRepository();

            return repo.Create(model);
        }
    }
}
