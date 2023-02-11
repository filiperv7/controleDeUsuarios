using ControleDeUsuario02.Domain.IRepository;
using ControleDeUsuario02.InfraStructure.Persistency.DataContext;
using Microsoft.AspNetCore.Mvc;

namespace ControleDeUsuario02.API.Controllers {

    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase {

        private readonly Context _dbContext;
        private readonly IRepositoryProject _repositoryProject;

        public ProjectController(Context dbContext, IRepositoryProject repositoryProject) {
            _dbContext = dbContext;
            _repositoryProject = repositoryProject;
        }

        // Obter TODOS
        [HttpGet]
        public ActionResult<IEnumerable<ProjectResource>> Get() {
            var projects = _repositoryProject.GetAll();

            if (projects is null) {
                return NotFound("Nenhum projeto foi encotrado!");
            }

            return ProjectResource.ConvertListDomainToListResource(projects);
        }

        // Obter por ID
        [HttpGet("{id:int}")]
        public ActionResult<ProjectResource> Get(int id) {
            var project = _repositoryProject.GetById(id);

            if (project is null) {
                return NotFound("Projeto não encontrado!");
            }

            return ProjectResource.DomainToResource(project);
        }

        // Obter por NOME
        [HttpGet("{name}")]
        public ActionResult<IEnumerable<ProjectResource>> Get(string name) {
            var projects = _repositoryProject.GetByName(name);

            if (projects is null) {
                return NotFound("Projeto(s) não encontrado(s)!");
            }

            return ProjectResource.ConvertListDomainToListResource(projects);
        }

        // Adicionar NOVO
        [HttpPost]
        public ActionResult<ProjectResource> Post(ProjectResource project) {
            if (project is null) return BadRequest();

            var projectDomain = _repositoryProject.Create(project.ResourceToDomain());
            _dbContext.SaveChanges();

            return Ok(ProjectResource.DomainToResource(projectDomain));
        }

        // Atualizar por ID
        [HttpPut("{id:int}")]
        public ActionResult<ProjectResource> Put(int id, ProjectResource project) {

            if (id != project.Id) {
                return BadRequest();
            }

            var projectDomain = _repositoryProject.Update(project.ResourceToDomain());
            _dbContext.SaveChanges();

            return Ok(ProjectResource.DomainToResource(projectDomain));
        }

        // Deletar por ID
        /*[HttpDelete("{id:int}")]
        public ActionResult<ProjectResource> Delete(int id) {
            var project = _repositoryProject.GetById(id);

            if (project is null) {
                return NotFound("Projeto não localizado! Impossível removê-lo.");
            }

            _repositoryProject.Delete(project);
            _dbContext.SaveChanges();

            return Ok(ProjectResource.DomainToResource(project));
        }*/
    }
}
