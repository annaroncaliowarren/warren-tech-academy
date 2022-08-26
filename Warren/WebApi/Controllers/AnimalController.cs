﻿using Microsoft.AspNetCore.Mvc;
using Data.Model;
using Data.Repository;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalController : ControllerBase
    {
        [HttpGet]
        public Animal Get()
        {
            Animal a1 = new Animal
            {
                Id = 1,
                Especie = "Cachorro",
                Nome = "Janis",
                Peso = 8.4f
            };

            return a1;
        }

        [HttpPost]
        public string Post(Animal model)
        {
            AnimalRepository repo = new AnimalRepository();

            return repo.Create(model);
        }
    }
}
