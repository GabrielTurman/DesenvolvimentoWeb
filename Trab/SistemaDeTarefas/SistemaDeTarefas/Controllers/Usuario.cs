using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaDeTarefas.Models;

namespace SistemaDeTarefas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Usuario : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<UsuarioModel>> BuscarUsuario()
        {
            return Ok();
        }
    }
}
