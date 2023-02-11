using ControleDeUsuario02.Domain.IRepository;
using ControleDeUsuario02.InfraStructure.Persistency.DataContext;
using Microsoft.AspNetCore.Mvc;

namespace ControleDeUsuario02.API.Controllers {

    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase {

        private readonly Context _dbContext;
        private readonly IRepositoryUser _repositoryUser;

        public UserController(Context dbContext, IRepositoryUser repositoryUser) {
            _dbContext = dbContext;
            _repositoryUser = repositoryUser;
        }


        // Obter TODOS
        [HttpGet]
        public ActionResult<List<UserResource>> GetAll() {
            var users = _repositoryUser.GetAll();

            if (users is null) {
                return NotFound("Nenhum usuário foi encontrado");
            }

            var usersResource = UserResource.ConvertListDomainToListResource(users);

            return usersResource;
        }

        // Obter por ID
        [HttpGet("{id:int}")]
        public ActionResult<UserResource> Get(int id) {
            var user = _repositoryUser.GetById(id);

            if (user is null) {
                return NotFound("Usuário não encontrado!");
            }

            var userResource = UserResource.DomainToResource(user);

            return userResource;
        }

        // Obter por NOME
        [HttpGet("{name}")]
        public ActionResult<List<UserResource>> Get(string name) {
            var users = _repositoryUser.GetByName(name);

            if (users is null) {
                return NotFound("Usuário(s) não encontrado(s)!");
            }

            var usersResource = UserResource.ConvertListDomainToListResource(users);

            return usersResource;
        }

        // Atualizar por ID
        [HttpPut]
        public ActionResult<UserResource> Put(int id, UserResource user) {

            var userDomain = user.ResourceToDomain();

            if (id != user.Id) {
                return BadRequest();
            }

            _repositoryUser.Update(userDomain);
            _dbContext.SaveChanges();

            return Ok(user);
        }

        // Deletar por ID
        [HttpDelete("{id:int}")]
        public ActionResult<UserResource> Delete(int id) {
            var user = _dbContext.Users.SingleOrDefault(u => u.Id == id);

            if (user is null) {
                return NotFound("Usuário não localizado! Impossível removê-lo.");
            }

            _repositoryUser.Delete(user);
            _dbContext.SaveChanges();

            return Ok(user);
        }
    }
}
