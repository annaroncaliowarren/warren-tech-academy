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
        public Dictionary<string, dynamic> Get()
        {
            return repository.GetAll();
        }

        [HttpGet]
        public Planta GetById(int id)
        {
            return repository.GetById(id);
        }

        [HttpPost]
        public Dictionary<string, dynamic> Post(Planta model)
        {
            return repository.Create(model);
        }

        [HttpDelete]
        public Dictionary<string, dynamic> Delete(int id)
        {
            return repository.Delete(id);
        }

        [HttpPut]
        public Dictionary<string, dynamic> Put(Planta model)
        {
            return repository.Update(model);
        }
    }
}
