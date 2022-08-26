﻿using Microsoft.AspNetCore.Mvc;
using Data.Model;
using Data.Repository;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalController : ControllerBase
    {
        private AnimalRepository repository;

        public AnimalController()
        {
            this.repository = new AnimalRepository();
        }

        [HttpGet]
        public List<Animal> Get()
        {
            return repository.GetAll();
        }

        [HttpPost]
        public string Post(Animal model)
        {
            return repository.Create(model);
        }

        [HttpDelete]
        public string Delete(int id)
        {
            return repository.Delete(id);
        }

        [HttpPut]
        public string Update(Animal model)
        {
            return repository.Update(model);
        }
    }
}
