using ControleDeUsuario02.API.Model.Resource;
using ControleDeUsuario02.Application;
using ControleDeUsuario02.Domain.IRepository;
using ControleDeUsuario02.InfraStructure.Persistency.DataContext;
using Microsoft.AspNetCore.Mvc;

namespace ControleDeUsuario02.API.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class UserFullController : ControllerBase {

        private readonly Context _dbContext;
        private readonly IRepositoryUser _repositoryUser;

        public UserFullController(Context dbContext, IRepositoryUser repositoryUser) {
            _dbContext = dbContext;
            _repositoryUser = repositoryUser;
        }

        // Obter TODOS COMPLETOS
        [HttpGet]
        public ActionResult<List<UserFullResource>> GetAll() {
            var users = _repositoryUser.GetAll();

            if (users is null) {
                return NotFound("Nenhum usuário foi encontrado");
            }

            var usersResource = UserFullResource.ConvertListDomainToListResource(users);

            return usersResource;
        }

        // Obter Usuário COMPLETO por ID
        [HttpGet("{id:int}")]
        public ActionResult<UserFullResource> GetAllCompleteById(int id) {
            var user = _repositoryUser.GetAllCompleteById(id);

            if (user is null) return NotFound("Nenhum usuário foi encontrado");

            var userResource = UserFullResource.DomainToResource(user);

            return userResource;
        }


        // Obter por Usuáiro COMPLETO por NOME
        [HttpGet("{name}")]
        public ActionResult<List<UserFullResource>> Get(string name) {
            var users = _repositoryUser.GetByName(name);

            if (users is null) {
                return NotFound("Usuário(s) não encontrado(s)!");
            }

            var usersResource = UserFullResource.ConvertListDomainToListResource(users);

            return usersResource;
        }


        // Adicionar NOVO Usuário COMPLETO
        [HttpPost]
        public ActionResult<UserFullResource> Post(UserFullResource fullUser) {
            var user = UserApplication.InsertFull(fullUser.Project.ResourceToDomain(), DepartmentResource.ConvertListResourceToListDomain(fullUser.Departments), fullUser.ResourceToDomain());

            if (user is null) return BadRequest();

            return Ok(UserFullResource.DomainToResource(user));
        }


        // Atualizar por ID
        [HttpPut("{id:int}")]
        public ActionResult<UserFullResource> Put(int id, UserFullResource user) {
            if (id != user.Id) return BadRequest();

            var userResource = UserResource.DomainToResource(_repositoryUser.Update(user.ResourceToDomain()));
            _dbContext.SaveChanges();

            return Ok(userResource);
        }
    }
}
