using Data.Model;
using Data.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenericController<T, R> : ControllerBase where T : BaseModel where R : BaseRepository<T>
    {
        private R _repository;

        public GenericController()
        {
            this._repository = Activator.CreateInstance<R>();
        }

        [HttpGet]
        public Dictionary<string, dynamic> Get()
        {
            return _repository.GetAll();
        }

        [HttpGet("{id}")]
        public T GetById(int id)
        {
            return _repository.GetById(id);
        }

        [HttpPost]
        public Dictionary<string, dynamic> Post(T model)
        {
            return _repository.Create(model);
        }

        [HttpDelete("{id}")]
        public Dictionary<string, dynamic> Delete(int id)
        {
            return _repository.Delete(id);
        }

        [HttpPut]
        public Dictionary<string, dynamic> Put(T model)
        {
            return _repository.Update(model);
        }
    }
}
