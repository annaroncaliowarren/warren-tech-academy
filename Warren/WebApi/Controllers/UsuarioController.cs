﻿using Data.Model;
using Data.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : GenericController<UsuarioModel, UsuarioRepository>
    {
        public UsuarioController() : base(new UsuarioRepository())
        {
        }
    }
}
