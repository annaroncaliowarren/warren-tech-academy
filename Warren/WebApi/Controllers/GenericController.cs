using Data.Model;
using Data.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenericController<T> : ControllerBase where T : BaseModel
    {
        private BaseRepository<T> repository;

        public GenericController()
        {
            this.repository = new BaseRepository<T>();
        }

        [HttpGet]
        public Dictionary<string, dynamic> Get()
        {
            return repository.GetAll();
        }

        [HttpGet("{id}")]
        public T GetById(int id)
        {
            return repository.GetById(id);
        }

        [HttpPost]
        public Dictionary<string, dynamic> Post(T model)
        {
            return repository.Create(model);
        }

        [HttpDelete("{id}")]
        public Dictionary<string, dynamic> Delete(int id)
        {
            return repository.Delete(id);
        }

        [HttpPut]
        public Dictionary<string, dynamic> Put(T model)
        {
            return repository.Update(model);
        }
    }
}
