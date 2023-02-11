using ControleDeUsuario02.Domain.IRepository;
using ControleDeUsuario02.InfraStructure.Persistency.DataContext;
using Microsoft.AspNetCore.Mvc;

namespace ControleDeUsuario02.API.Controllers {

    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase {

        private readonly Context _dbContext;
        private readonly IRepositoryDepartment _repositoryDepartment;

        public DepartmentController(Context dbContext, IRepositoryDepartment repositoryDepartment) {
            _dbContext = dbContext;
            _repositoryDepartment = repositoryDepartment;
        }

        // Obter TODOS
        [HttpGet]
        public ActionResult<IEnumerable<DepartmentResource>> Get() {
            var departments = _repositoryDepartment.GetAll();

            if (departments is null) {
                return NotFound("Nenhum departamento foi encotrado!");
            }
            return DepartmentResource.ConvertListDomainToListResource(departments);
        }

        // Obter por ID
        [HttpGet("{id:int}")]
        public ActionResult<DepartmentResource> Get(int id) {
            var department = _repositoryDepartment.GetById(id);

            if (department is null) {
                return NotFound("Departamento não encontrado!");
            }

            return DepartmentResource.DomainToResource(department);
        }

        // Obter por NOME
        [HttpGet("{name}")]
        public ActionResult<List<DepartmentResource>> Get(string name) {
            var departments = _repositoryDepartment.GetByName(name);

            if (departments is null) {
                return NotFound("Departamento(s) não encontrado(s)!");
            }

            return DepartmentResource.ConvertListDomainToListResource(departments);
        }

        // Adicionar NOVO
        [HttpPost]
        public ActionResult<DepartmentResource> Post(DepartmentResource department) {
            if (department is null) return BadRequest();

            var departmentDomain = _repositoryDepartment.CreateOne(department.ResourceToDomain());
            _dbContext.SaveChanges();

            return Ok(DepartmentResource.DomainToResource(departmentDomain));
        }

        // Atualizar por ID
        [HttpPut("{id:int}")]
        public ActionResult<DepartmentResource> Put(int id, DepartmentResource department) {
            // Melhorar a implementação desse método
                  // Pegando o Departamento pelo id (GetById())

            if (id != department.Id) {
                return BadRequest();
            }

            var departmentDomain = _repositoryDepartment.Update(department.ResourceToDomain());
            _dbContext.SaveChanges();

            return Ok(DepartmentResource.DomainToResource(departmentDomain));
        }

        // Deletar por ID
        /*[HttpDelete("{id:int}")]
        public ActionResult<ProjectResource> Delete(int id) {
            var department = _repositoryDepartment.GetById(id);

            if (department is null) {
                return NotFound("Departamento não localizado! Impossível removê-lo.");
            }

            _repositoryDepartment.Delete(department);
            _dbContext.SaveChanges();

            return Ok(department);
        }*/
    }
}
