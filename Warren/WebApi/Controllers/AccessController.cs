using Data.Model;
using Data.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.DTO;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccessController : ControllerBase
    {
        [HttpPost("Logon")]
        public UsuarioModel Logon(UsuarioDto usuarioDto) 
        {
            UsuarioRepository repository = new UsuarioRepository();
            UsuarioModel model = repository.Logon(usuarioDto.Email, usuarioDto.Senha);
            return model;
        }
    }
}
