using Microsoft.AspNetCore.Mvc;
using PrjAPILembretes.models;
using PrjAPILembretes.DTO;
using System.Text.Json;

namespace PrjAPILembretes.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LembreteController:ControllerBase
    {
        [HttpPost("add")]
        public IActionResult AddLembrete()
        {

        }
        [HttpDelete("del/{id}")]
        public IActionResult DelLembrete()
        {

        }
        [HttpGet("all")]
        public IActionResult GetAll()
        {

        }
        [HttpGet("get/{id}")]
        public IActionResult GetLembrete()
        {

        }
        [HttpPut("update/{id}")]
        public IActionResult AtualizarLembrete()
        {

        }
    }
}
