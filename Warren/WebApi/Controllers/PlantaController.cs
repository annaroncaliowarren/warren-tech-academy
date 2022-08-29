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

        [HttpGet("{id}")]
        public PlantaModel GetById(int id)
        {
            return repository.GetById(id);
        }

        [HttpPost]
        public Dictionary<string, dynamic> Post(PlantaModel model)
        {
            return repository.Create(model);
        }

        [HttpDelete("{id}")]
        public Dictionary<string, dynamic> Delete(int id)
        {
            return repository.Delete(id);
        }

        [HttpPut]
        public Dictionary<string, dynamic> Put(PlantaModel model)
        {
            return repository.Update(model);
        }
    }
}
