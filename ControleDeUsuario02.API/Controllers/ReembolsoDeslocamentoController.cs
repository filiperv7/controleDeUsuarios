using AutoMapper;
using ControleDeUsuario02.API.Model.Resource;
using ControleDeUsuario02.Domain.IRepository;
using ControleDeUsuario02.Domain.Model;
using ControleDeUsuario02.InfraStructure.Persistency.DataContext;
using Microsoft.AspNetCore.Mvc;

namespace ControleDeUsuario02.API.Controllers {

    [Route("api/[controller]")]
    [ApiController]
    public class ReembolsoDeslocamentoController : ControllerBase {

        private readonly Context _dbContext;
        private readonly IRepositoryReembolsoDeslocamento _repositoryReembolsoDeslocamento;
        private readonly IMapper _mapper;

        public ReembolsoDeslocamentoController(Context dbContext, IRepositoryReembolsoDeslocamento repositoryReembolsoDeslocamento, IMapper mapper) {
            _dbContext = dbContext;
            _repositoryReembolsoDeslocamento = repositoryReembolsoDeslocamento;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<List<ReembolsoDeslocamentoResource>> GetAll() {
            var reembolsos = _repositoryReembolsoDeslocamento.GetAll();

            if (reembolsos is null) {
                return NotFound("Nenhum reeembolso encontrado");
            }

            var test = _mapper.Map<List<ReembolsoDeslocamentoResource>>(reembolsos);

            return Ok(test);
        }

        [HttpPost]
        public ActionResult<ReembolsoDeslocamentoResource> Post(ReembolsoDeslocamentoResource reembolsoDeslocamento) {
            if (reembolsoDeslocamento is null) return BadRequest();

            var reembolsoCriado = _repositoryReembolsoDeslocamento.Create(_mapper.Map<ReembolsoDeslocamento>(reembolsoDeslocamento));
            _dbContext.SaveChanges();

            return Ok(_mapper.Map<ReembolsoDeslocamentoResource>(reembolsoCriado));
        }
    }
}
