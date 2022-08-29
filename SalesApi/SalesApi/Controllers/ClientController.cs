using Data.Model;
using Data.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SalesApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        ClientRepository clientRepository;

        public ClientController()
        {
            clientRepository = new ClientRepository();
        }

        [HttpGet]
        public Dictionary<string, dynamic> Get()
        {
            return clientRepository.GetAll();
        }

        [HttpPost]
        public Dictionary<string, dynamic> Post(ClientModel model)
        {
            return clientRepository.Create(model);
        }

        [HttpDelete]
        public Dictionary<string, dynamic> Delete(int id)
        {
            return clientRepository.Delete(id);
        }

        [HttpPut]
        public Dictionary<string, dynamic> Put(ClientModel model)
        {
            return clientRepository.Update(model);
        }
    }
}
