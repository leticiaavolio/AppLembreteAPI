using Microsoft.AspNetCore.Mvc;
using PrjAPILembretes.Context;
using PrjAPILembretes.Entities;
using PrjAPILembretes.models;
using System.Text.Json;

namespace PrjAPILembretes.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LembreteController:ControllerBase
    {
        //read only
        private readonly AppLembretesContext _contextoDB;

        public LembreteController(AppLembretesContext contextoDB)
        {
            _contextoDB = contextoDB;
        }
        [HttpPost]
        public IActionResult AddLembrete(Lembrete lembrete)//receber um lembrete
        {
            _contextoDB.Add(lembrete); //adicionar o lembrete recebido no banco de dados
            _contextoDB.SaveChanges(); // salvando as alterações no banco de dados
            return Ok(lembrete);//retorna o lembrete adicionado
        }

        [HttpGet("get/{id}")]
        public IActionResult GetLembrete(int id)//recebe o id do lembrete a ser exibido
        {
            var lembrete = _contextoDB.Lembretes.Find(id); ////pesquisa entre os lembretes do contexto aquele que possui o id recebido, guardando o lembrete na var
            if (lembrete == null)//verifica se foi encontrado algum lembrete
            {
                return NotFound();// se não encontrado, retornará erro 404 - NotFound 
            }
            return Ok(lembrete);//se for encontradom retornará o proprio lembrete

        }

        [HttpPut("update/{id}")]
        public IActionResult UpdateLembrete(int id, Lembrete lembrete)//recebe o id do lembrete a ser atualizado com as novas informações
        {
            var lembreteBanco = _contextoDB.Lembretes.Find(id);//pesquisa entre os lembretes do contexto aquele que possui o id recebido

            if (lembrete == null)//verifica se não for encontrado algum lembrete
            {
                return NotFound();// se não encontrado, retornará erro 404 - NotFound 
            }
            lembreteBanco.TituloLembrete = lembrete.TituloLembrete;//pega os dados do antigo e salva os atualizados

            lembreteBanco.CorpoLembrete = lembrete.CorpoLembrete;//pega os dados do antigo e salva os atualizados

            lembreteBanco.StatusLembrete = lembrete.StatusLembrete;//pega os dados do antigo e salva os atualizados

            _contextoDB.Lembretes.Update(lembreteBanco);//Atualiza o lembrete 

            _contextoDB.SaveChanges();//salva as alterações no banco de dados
            return Ok(lembreteBanco);//retorna o lembrete atualizado
        }
        [HttpDelete("del/{id}")]
        public IActionResult DelLembrete(int id)//recebe o id do lembrete a ser deletado
        {
            var lembrete = _contextoDB.Lembretes.Find(id);//pesquisa entre os lembretes do contexto aquele que possui o id recebido

            if (lembrete == null)//verifica se não for encontrado algum lembrete
            {
                return NotFound();// se não encontrado, retornará erro 404 - NotFound 
            }
            _contextoDB.Lembretes.Remove(lembrete);//Remove o lembrete do banco de dados

            _contextoDB.SaveChanges();//salva as alterações no banco de dados
            return Ok("Lembrete excluído!");//retorna o lembrete atualizado
        }
        [HttpGet("getall")]
        public IActionResult GetAll()//recebe o id do lembrete a ser deletado
        {
            var listaLembrete = _contextoDB.Lembretes;

            return Ok(listaLembrete);//retorna o lembrete atualizado
        }

    }
}
