using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Data.Repository;
using Data.Model;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlantaController : ControllerBase
    {
        private PlantaRepository repository;

        public PlantaController()
        {
            this.repository = new PlantaRepository();
        }

        [HttpGet]
        public List<Planta> Get()
        {
            return repository.GetAll();
        }

        [HttpPost]
        public string Post(Planta model)
        {
            return repository.Create(model);
        }

        [HttpDelete]
        public string Delete(int id)
        {
            return repository.Delete(id);
        }

        [HttpPut]
        public string Update(Planta model)
        {
            return repository.Update(model);
        }
    }
}
