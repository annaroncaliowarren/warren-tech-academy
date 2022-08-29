using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Data.Repository;
using Data.Model;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlantaController : GenericController<PlantaModel>
    {
    }
}
