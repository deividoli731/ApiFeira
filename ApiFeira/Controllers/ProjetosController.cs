using ApiFeira.Models;
using ApiFeira.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ApiFeira.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProjetosController : ControllerBase
    {
        private readonly IProjetoRepository _repository;

        public ProjetosController(
            IProjetoRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public IActionResult Cadastrar(Projeto projeto)
        {
            bool sucesso =
                _repository.AdicionarProjeto(projeto);

            if (!sucesso)
            {
                return BadRequest(
                    "Já existe um projeto com esse número.");
            }

            return Ok("Projeto cadastrado com sucesso.");
        }

        [HttpGet]
        public IActionResult Listar()
        {
            var projetos =
                _repository.ListarProjetos();

            return Ok(projetos);
        }

        [HttpPost("visitas")]
        public IActionResult RegistrarVisita(Visita visita)
        {
            bool sucesso =
                _repository.RegistrarVisita(visita);

            if (!sucesso)
            {
                return BadRequest(
                    "Projeto não encontrado.");
            }

            return Ok("Visita registrada com sucesso.");
        }

        [HttpGet("visitas/{numero}")]
        public IActionResult ConsultarVisitas(int numero)
        {
            var visitas =
                _repository.ConsultarVisitas(numero);

            return Ok(visitas);
        }
    }
}