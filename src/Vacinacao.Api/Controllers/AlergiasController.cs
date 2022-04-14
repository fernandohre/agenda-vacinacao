using Microsoft.AspNetCore.Mvc;
using Vacinacao.Core.Domain.Dto;
using Vacinacao.Core.Interfaces.Services;

namespace Vacinacao.Api.Controllers
{
    [ApiController]
    [Route("/alergias")]
    public class AlergiasController : ControllerBase
    {
        private IService<AlergiaDto> _service;
        public AlergiasController(IService<AlergiaDto> service) 
        {
            _service = service;
        }
        [HttpPost("cadastrar")]
        public IActionResult Insert(AlergiaDto alergia) 
        { 
            _service.Insert(alergia);

            return Ok(new 
            { 
                mensagem = "Cadastrado com sucesso!"
            });
        }
        [HttpPost("atualizar")]
        public IActionResult Update(AlergiaDto alergia) 
        {
            _service.Update(alergia, alergia.Id.GetValueOrDefault());

            return Ok(new 
            { 
                mensagem = "Atualizado com sucesso!"
            });
        }
        [HttpPost("excluir")]
        public IActionResult Delete(int key) 
        { 
            _service.Delete(key);

            return Ok(new 
            { 
                mensagem = "Excluído com sucesso!"
            });
        }
        [HttpGet]
        public JsonResult GetAll() 
        { 
            IEnumerable<AlergiaDto> itens = _service.GetAll();

            return new JsonResult(new
            {
                dados = itens
            });
        }
    }
}
