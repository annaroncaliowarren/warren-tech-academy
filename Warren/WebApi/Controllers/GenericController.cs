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
        private R repository;

        public GenericController(R repo)
        {
            this.repository = repo;
        }

        [HttpGet("GetAll")]
        public Dictionary<string, dynamic> Get()
        {
            return repository.GetAll();
        }

        [HttpGet("GetById/{id}")]
        public T GetById(int id)
        {
            return repository.GetById(id);
        }

        [HttpPost("Post")]
        public Dictionary<string, dynamic> Post(T model)
        {
            return repository.Create(model);
        }

        [HttpDelete("Delete/{id}")]
        public Dictionary<string, dynamic> Delete(int id)
        {
            return repository.Delete(id);
        }

        [HttpPut("Put")]
        public Dictionary<string, dynamic> Put(T model)
        {
            return repository.Update(model);
        }
    }
}
