using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Data.Repository;
using Data.Model;

namespace WebApi.Controllers
{
    public class PlantaController : GenericController<PlantaModel, PlantaRepository>
    {
        public PlantaController() : base(new PlantaRepository())
        {
        }
    }
}
